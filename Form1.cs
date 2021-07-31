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
        private StreamWriter fil;
        private StreamReader inFile;
        private string fileDirectory = "../../../data.txt";

        public Form1()
        {
            InitializeComponent();
            // fil.AutoFlush = true; // This is a necessary setting. 
        }

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
                    this.txtBoxRead.Text = "";
                    inFile = new StreamReader(fileDirectory);
                    while ((inValue = inFile.ReadLine()) != null)
                    {
                        this.txtBoxRead.Text += inValue;
                        if (!inFile.EndOfStream)
                        {
                            this.txtBoxRead.Text += ", ";
                        }
                    }

                    inFile.Dispose();
                }
                catch (System.IO.IOException ioe) // Unecessary full name.
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

        private void button1_Click(object sender, EventArgs e)
        {
            string inValue;
            if (File.Exists(fileDirectory))
            {
                try
                {
                    this.lstBoxData.Items.Clear();
                    inFile = new StreamReader(fileDirectory);
                    while((inValue = inFile.ReadLine()) != null)
                    {
                        this.lstBoxData.Items.Add(inValue);
                    }
                    inFile.Dispose();
                }
                catch (IOException ioe)
                {
                    lblMsg.Text = ioe.Message;
                }
            }
            else
            {
                lblMsg.Text = "File not found";
            }
        }

        private void deleteDataToolStripMenuItem_Click(object sender, EventArgs e) // This the menu control method.
        {
            try
            {
                File.WriteAllText(fileDirectory, "");
            }
            catch (IOException ioe)
            {
                lblMsg.Text = ioe.Message;
            }
        }
    }
}
