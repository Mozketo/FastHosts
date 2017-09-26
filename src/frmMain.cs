using HW.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            var items = new Hosts().Read();
            foreach (var item in items)
            {
                Console.WriteLine($"Line:{item.I} {item.IsEnabled} '{item.Value}'");
            }
        }
    }
}
