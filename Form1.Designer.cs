
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
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(12, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(79, 20);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "Enter Data";
            // 
            // txtBoxWrite
            // 
            this.txtBoxWrite.Location = new System.Drawing.Point(12, 42);
            this.txtBoxWrite.Multiline = true;
            this.txtBoxWrite.Name = "txtBoxWrite";
            this.txtBoxWrite.Size = new System.Drawing.Size(213, 147);
            this.txtBoxWrite.TabIndex = 1;
            // 
            // btnStoreSaying
            // 
            this.btnStoreSaying.Location = new System.Drawing.Point(56, 206);
            this.btnStoreSaying.Name = "btnStoreSaying";
            this.btnStoreSaying.Size = new System.Drawing.Size(126, 29);
            this.btnStoreSaying.TabIndex = 2;
            this.btnStoreSaying.Text = "Store Data";
            this.btnStoreSaying.UseVisualStyleBackColor = true;
            this.btnStoreSaying.Click += new System.EventHandler(this.btnStoreSaying_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(259, 206);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(94, 29);
            this.btnReadFile.TabIndex = 3;
            this.btnReadFile.Text = "Read Data";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear Data Box";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBoxRead
            // 
            this.txtBoxRead.Location = new System.Drawing.Point(259, 42);
            this.txtBoxRead.Multiline = true;
            this.txtBoxRead.Name = "txtBoxRead";
            this.txtBoxRead.Size = new System.Drawing.Size(257, 147);
            this.txtBoxRead.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(530, 245);
            this.Controls.Add(this.txtBoxRead);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnStoreSaying);
            this.Controls.Add(this.txtBoxWrite);
            this.Controls.Add(this.lblMsg);
            this.Name = "Form1";
            this.Text = "File Writer and Reader";
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
    }
}

