using FastHosts.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastHost
{
    public partial class Form1 : Form
    {
        public Form1()
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
