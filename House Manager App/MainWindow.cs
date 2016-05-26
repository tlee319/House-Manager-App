using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Manager_App
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            Demo();
        }

        private void Demo()
        {
            ChoreManager.CreateChoreList(new DateTime(2016, 6, 6));
        }
    }
}
