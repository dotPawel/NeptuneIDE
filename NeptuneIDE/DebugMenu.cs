using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeptuneIDE
{
    public partial class DebugMenu : Form
    {
        public DebugMenu()
        {
            InitializeComponent();
        }

        private void cleardirButton_Click(object sender, EventArgs e)
        {
            Editor.dirPath = null;
        }

        private void cleardirnameButton_Click(object sender, EventArgs e)
        {
            Editor.dirName = null;
        }
    }
}
