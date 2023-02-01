using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace NeptuneIDE
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void StartUp_Load(object sender, EventArgs e)
        {
            versionText.Text = "Build // " + Program.ver;

            Program.log("Loaded in StartUp");
            Program.log("Checking Neptune files");

            // check for neptune.data folder
            if (Directory.Exists(@"Neptune.data"))
            {
                Program.log("Neptune.data [OK]");
            }
            else
            {
                Program.log("Neptune.data [ERR]");
                try
                {
                    Directory.CreateDirectory(@"Neptune.data");
                    Program.log("Neptune.data [FIX]");
                }
                catch (Exception ex)
                {
                    Program.log("Cannot create Neptune.data [ERR]\nException : " + ex + "\n\nPress any key to exit.");
                    Console.ReadKey();
                    Application.Exit();
                }
            }
            // check for projects folder
            if (Directory.Exists(@"Neptune.data\Projects"))
            {
                Program.log(@"Neptune.data\Projects [OK]");
            }
            else
            {
                Program.log(@"Neptune.data\Projects [ERR]");
                try
                {
                    Directory.CreateDirectory(@"Neptune.data\Projects");
                    Program.log(@"Neptune.data\Projects [FIX]");
                }
                catch (Exception ex)
                {
                    Program.log("Cannot create Neptune.data/Projects [ERR]\nException : " + ex + "\n\nPress any key to exit.");
                    Console.ReadKey();
                    Application.Exit();
                }
            }

            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Program.log("Opening Selector");
            this.Hide();
            
            Form selector = new Editor();

            selector.Show();

            timer.Enabled = false;
        }
    }
}