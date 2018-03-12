namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.TreeView = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.textBoxProcessor = new System.Windows.Forms.TextBox();
            this.labelProcessor = new System.Windows.Forms.Label();
            this.labelRAM = new System.Windows.Forms.Label();
            this.textBoxRAM = new System.Windows.Forms.TextBox();
            this.labelGraphic = new System.Windows.Forms.Label();
            this.textBoxGraphic = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Location = new System.Drawing.Point(102, 25);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(247, 65);
            this.OpenFileBtn.TabIndex = 0;
            this.OpenFileBtn.Text = "OpenFile";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // TreeView
            // 
            this.TreeView.Location = new System.Drawing.Point(12, 120);
            this.TreeView.Name = "TreeView";
            this.TreeView.Size = new System.Drawing.Size(439, 827);
            this.TreeView.TabIndex = 1;
            this.TreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(472, 12);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.ReadOnly = true;
            this.descriptionRichTextBox.Size = new System.Drawing.Size(686, 98);
            this.descriptionRichTextBox.TabIndex = 4;
            this.descriptionRichTextBox.Text = "";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Location = new System.Drawing.Point(472, 120);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(686, 827);
            this.propertyGrid.TabIndex = 5;
            // 
            // textBoxProcessor
            // 
            this.textBoxProcessor.Location = new System.Drawing.Point(1391, 269);
            this.textBoxProcessor.Multiline = true;
            this.textBoxProcessor.Name = "textBoxProcessor";
            this.textBoxProcessor.Size = new System.Drawing.Size(100, 32);
            this.textBoxProcessor.TabIndex = 6;
            // 
            // labelProcessor
            // 
            this.labelProcessor.AutoSize = true;
            this.labelProcessor.Location = new System.Drawing.Point(1188, 272);
            this.labelProcessor.Name = "labelProcessor";
            this.labelProcessor.Size = new System.Drawing.Size(197, 29);
            this.labelProcessor.TabIndex = 7;
            this.labelProcessor.Text = "Processor (GHz):";
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.Location = new System.Drawing.Point(1188, 337);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(127, 29);
            this.labelRAM.TabIndex = 8;
            this.labelRAM.Text = "RAM (GB):";
            // 
            // textBoxRAM
            // 
            this.textBoxRAM.Location = new System.Drawing.Point(1391, 331);
            this.textBoxRAM.Name = "textBoxRAM";
            this.textBoxRAM.Size = new System.Drawing.Size(100, 35);
            this.textBoxRAM.TabIndex = 9;
            // 
            // labelGraphic
            // 
            this.labelGraphic.AutoSize = true;
            this.labelGraphic.Location = new System.Drawing.Point(1188, 395);
            this.labelGraphic.Name = "labelGraphic";
            this.labelGraphic.Size = new System.Drawing.Size(161, 29);
            this.labelGraphic.TabIndex = 10;
            this.labelGraphic.Text = "Graphic (MB):";
            // 
            // textBoxGraphic
            // 
            this.textBoxGraphic.Location = new System.Drawing.Point(1391, 389);
            this.textBoxGraphic.Name = "textBoxGraphic";
            this.textBoxGraphic.Size = new System.Drawing.Size(100, 35);
            this.textBoxGraphic.TabIndex = 11;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(1193, 645);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(360, 35);
            this.textBoxOutput.TabIndex = 12;
            this.textBoxOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(1193, 499);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(360, 125);
            this.buttonCheck.TabIndex = 14;
            this.buttonCheck.Text = "Will this game work on your computer?";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1609, 1358);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxGraphic);
            this.Controls.Add(this.labelGraphic);
            this.Controls.Add(this.textBoxRAM);
            this.Controls.Add(this.labelRAM);
            this.Controls.Add(this.labelProcessor);
            this.Controls.Add(this.textBoxProcessor);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.TreeView);
            this.Controls.Add(this.OpenFileBtn);
            this.Name = "Form1";
            this.Text = "Game checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button OpenFileBtn;
        private System.Windows.Forms.TreeView TreeView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.TextBox textBoxProcessor;
        private System.Windows.Forms.Label labelProcessor;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.TextBox textBoxRAM;
        private System.Windows.Forms.Label labelGraphic;
        private System.Windows.Forms.TextBox textBoxGraphic;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonCheck;
    }
}

