using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KasenovAE.Sprint7.Project.V6.Lib;

namespace Tyuiu.KasenovAE.Sprint7.Project.V6.NonStatic
{
    public partial class Form1 : Form
    {
        Controller ctr = new Controller();
        public Form1()
        {
            InitializeComponent();
            
            dataGridView1.DataSource = ctr.DT;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
