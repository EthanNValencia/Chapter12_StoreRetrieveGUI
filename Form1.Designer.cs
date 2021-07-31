
namespace Chapter12_StoreRetrieveGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtBoxWrite = new System.Windows.Forms.TextBox();
            this.btnStoreSaying = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBoxRead = new System.Windows.Forms.TextBox();
            this.lstBoxData = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.deleteDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(12, 256);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(27, 20);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "***";
            // 
            // txtBoxWrite
            // 
            this.txtBoxWrite.Location = new System.Drawing.Point(12, 74);
            this.txtBoxWrite.Multiline = true;
            this.txtBoxWrite.Name = "txtBoxWrite";
            this.txtBoxWrite.Size = new System.Drawing.Size(213, 144);
            this.txtBoxWrite.TabIndex = 1;
            // 
            // btnStoreSaying
            // 
            this.btnStoreSaying.Location = new System.Drawing.Point(57, 224);
            this.btnStoreSaying.Name = "btnStoreSaying";
            this.btnStoreSaying.Size = new System.Drawing.Size(126, 29);
            this.btnStoreSaying.TabIndex = 2;
            this.btnStoreSaying.Text = "Store Data";
            this.btnStoreSaying.UseVisualStyleBackColor = true;
            this.btnStoreSaying.Click += new System.EventHandler(this.btnStoreSaying_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(240, 224);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(94, 29);
            this.btnReadFile.TabIndex = 3;
            this.btnReadFile.Text = "Read Data";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(381, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear Data Box";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBoxRead
            // 
            this.txtBoxRead.Location = new System.Drawing.Point(240, 74);
            this.txtBoxRead.Multiline = true;
            this.txtBoxRead.Name = "txtBoxRead";
            this.txtBoxRead.Size = new System.Drawing.Size(257, 144);
            this.txtBoxRead.TabIndex = 5;
            // 
            // lstBoxData
            // 
            this.lstBoxData.FormattingEnabled = true;
            this.lstBoxData.ItemHeight = 20;
            this.lstBoxData.Location = new System.Drawing.Point(512, 74);
            this.lstBoxData.Name = "lstBoxData";
            this.lstBoxData.Size = new System.Drawing.Size(152, 144);
            this.lstBoxData.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Get List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteDataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // deleteDataToolStripMenuItem
            // 
            this.deleteDataToolStripMenuItem.Name = "deleteDataToolStripMenuItem";
            this.deleteDataToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.deleteDataToolStripMenuItem.Text = "Delete Data";
            this.deleteDataToolStripMenuItem.Click += new System.EventHandler(this.deleteDataToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Input Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Text Box Output Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "List Box Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(676, 276);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstBoxData);
            this.Controls.Add(this.txtBoxRead);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnStoreSaying);
            this.Controls.Add(this.txtBoxWrite);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "File Writer and Reader";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtBoxWrite;
        private System.Windows.Forms.Button btnStoreSaying;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBoxRead;
        private System.Windows.Forms.ListBox lstBoxData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteDataToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

