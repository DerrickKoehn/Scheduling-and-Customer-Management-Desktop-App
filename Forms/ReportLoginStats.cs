using SoftwareII.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareII.Forms
{
    public partial class ReportLoginStats : Form
    {
        public ReportLoginStats()
        {
            InitializeComponent();

        }

        private void ReportLoginStats_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            progressBar.Width = this.Width;


        }

        private void ReportLoginStats_ResizeEnd(object sender, EventArgs e)
        {
            
            progressBar.Width = this.Width;
        }

        private void ReportLoginStats_Shown(object sender, EventArgs e)
        {
            messageLabel.Show();
            
            int loginTotal = 0;
            StreamReader streamReader = new StreamReader("login.txt");
            while (!streamReader.EndOfStream)
            {
                streamReader.ReadLine();
                loginTotal++;
                //progress bar graphic logic
                if (progressBar.Value < 100)
                {
                    System.Threading.Thread.Sleep(10);
                    progressBar.Value++;
                }
                
            }
            progressBar.Hide();
            messageLabel.Text = $"Over the lifespan of this program, there have been {loginTotal} login attempts.";
            
        }
    }
}
