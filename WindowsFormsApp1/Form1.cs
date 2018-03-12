using GameInterface;
using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Assembly assembly;
        public Form1()
        {
            InitializeComponent();
        }

        private static void AddModule(Module module, TreeNode parent)
        {
            var newNode = new TreeNode(module.Name) { Tag = module };
            parent.Nodes.Add(newNode);



            foreach (var type in module.GetTypes())
            {

                if (typeof(IGame).IsAssignableFrom(type))
                {
                    AddType(type, newNode);
                }

            }
        }

#pragma warning disable CC0021 // Use nameof
        private static void AddType(Type type, TreeNode parent)
        {
            var newNode = new TreeNode(type.Name) { Tag = type };
            var memberTypeNode = new TreeNode(".ctors");
            TreeNode memberNode;

            foreach (var constructor in type.GetConstructors())
            {
                memberNode = new TreeNode(constructor.Name) { Tag = constructor };
                memberTypeNode.Nodes.Add(memberNode);
            }

            newNode.Nodes.Add(memberTypeNode);

            memberTypeNode = new TreeNode("Methods");
            foreach (var method in type.GetMethods())
            {
                var count = method.GetParameters().Length;
                var stringBuilder = new StringBuilder(method.Name).Append('(');
                foreach (var param in method.GetParameters())
                {
                    stringBuilder.Append(param.ParameterType);
                    if (param.Position < count - 1)
                    {
                        stringBuilder.Append(", ");
                    }
                }

                stringBuilder.Append(')');
                memberNode = new TreeNode(stringBuilder.ToString()) { Tag = method };
                memberTypeNode.Nodes.Add(memberNode);
            }

            newNode.Nodes.Add(memberTypeNode);
            memberTypeNode = new TreeNode("Properties");
            foreach (var property in type.GetProperties())
            {
                memberNode = new TreeNode(property.Name) { Tag = property };
                memberTypeNode.Nodes.Add(memberNode);
            }

            newNode.Nodes.Add(memberTypeNode);

            memberTypeNode = new TreeNode("Fields");
            foreach (var field in type.GetFields(
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static
                | BindingFlags.GetField))
            {
                var fieldInfo = field.FieldType.Name;
                fieldInfo += " " + field.Name;
                memberNode = new TreeNode(fieldInfo) { Tag = field };
                memberTypeNode.Nodes.Add(memberNode);
            }

            newNode.Nodes.Add(memberTypeNode);

            memberTypeNode = new TreeNode("Events");
            foreach (var @event in type.GetEvents())
            {
                var eventInfo = @event.Name;
                eventInfo += " Delegate Type=" + @event.EventHandlerType;
                memberNode = new TreeNode(eventInfo) { Tag = @event };
                memberTypeNode.Nodes.Add(memberNode);
            }

            newNode.Nodes.Add(memberTypeNode);

            parent.Nodes.Add(newNode);
        }


        private void OpenFileBtn_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK) { return; }

            TreeNode result = new TreeNode(dialog.SelectedPath);

            foreach (var file in Directory.GetFiles(dialog.SelectedPath))
            {
                if (file.EndsWith(".dll") || file.EndsWith(".exe"))
                {
                    this.assembly = Assembly.LoadFrom(file);
                    PopulateTree();
                }
            }

            DeleteEmptyNodes(this.TreeView.Nodes);
            
        }




        private void DeleteEmptyNodes(TreeNodeCollection nodes)
        {
            
           foreach (var n in nodes)
           {
                if(n != null)
                { 
                    foreach (var k in (n as TreeNode).Nodes)
                    {
                        var nodeCount = (k as TreeNode).Nodes.Count;
                        if( nodeCount == 0)
                        {
                            (n as TreeNode).Remove();
                        }
                    }
                }
            }

        }



        private void PopulateTree()
        {

            var newNode = new TreeNode(this.assembly.GetName().Name) { Tag = this.assembly };
            this.TreeView.Nodes.Add(newNode);


            foreach (var module in this.assembly.GetModules())
            {
                AddModule(module, newNode);
            }

        }


        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

            var type = this.TreeView.SelectedNode.Tag as Type;

            if (typeof(IGame).IsAssignableFrom(type))
            {
                var descriptionAttribute = type.GetCustomAttribute<DescriptionAttribute>(true);
            
                if (null == descriptionAttribute)
                {
                    this.descriptionRichTextBox.Text = "There is no Description";
                }
                else
                { 
                    this.descriptionRichTextBox.Text = descriptionAttribute.Description;
                }
            }
            else
            {
                this.descriptionRichTextBox.Text = String.Empty;
            }

            this.propertyGrid.SelectedObject = e.Node.Tag;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {

            double processorOut = 0;
            double processor = 0;

            int RAMOut = 0;
            int RAM = 0;

            int graphicOut = 0;
            int graphic = 0;

            if (Double.TryParse(textBoxProcessor.Text, out processorOut))
            {
                processor = processorOut;
            }
 

            if (int.TryParse(textBoxRAM.Text, out RAMOut))
            {
                RAM = RAMOut;
            }
      

            if (int.TryParse(textBoxGraphic.Text, out graphicOut))
            {
                graphic = graphicOut;
            }


            if (TreeView.SelectedNode != null)
            { 
                var type = this.TreeView.SelectedNode.Tag as Type;

                if( !(processor == 0 || RAM == 0 || graphic ==0) )
                {
                    if (type != null)
                    {
                        if (!(Activator.CreateInstance(type) is IGame callable))
                        {
                            throw new InvalidOperationException();
                        }

                        if (callable.Requirements(processor, RAM, graphic))
                        {
                            this.textBoxOutput.Text = "Yes.";
                        }
                        else
                        {
                            this.textBoxOutput.Text = "No.";
                        }
                    }
                }
                else
                {
                    this.textBoxOutput.Text = "Please entry correct parameters.";
                }
                
            }

        }

    }
}
