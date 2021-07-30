using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Chapter12_StoreRetrieveGUI // This program writes text to a file. 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // fil.AutoFlush = true; // This is a necessary setting. 
        }

        private StreamWriter fil;
        private StreamReader inFile;
        private string fileDirectory = "../../../data.txt";

        
        private void btnStoreSaying_Click(object sender, EventArgs e)
        {
            try
            {
                fil = new StreamWriter(fileDirectory, true);
                fil.AutoFlush = true; // This is a necessary setting. 
                fil.WriteLine(this.txtBoxWrite.Text);
                this.txtBoxWrite.Text = "";
                fil.Dispose();
            }
            catch (DirectoryNotFoundException dnfe)
            {
                lblMsg.Text = dnfe.Message;
            }
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            try
            {
                fil.Close();
                inFile.Close();
            }
            catch
            {

            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            string inValue;
            string nextValue;
            if (File.Exists(fileDirectory))
            {
                try
                {
                    inFile = new StreamReader(fileDirectory);

                    while((inValue = inFile.ReadLine()) != null)
                    {
                        this.txtBoxRead.Text += inValue;
                        if (!inFile.EndOfStream)
                        {
                            this.txtBoxRead.Text += ", ";
                        }
                    }

                    inFile.Dispose();
                }
                catch (System.IO.IOException ioe)
                {
                    lblMsg.Text = ioe.Message;
                }
            }
            else
            {
                lblMsg.Text = "File unavailable";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtBoxRead.Text = "";
        }
    }
}
