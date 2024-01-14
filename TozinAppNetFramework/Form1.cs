using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TozinAppNetFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var db = new mainEntities1();
            var goods = db.Goods.ToList();
            
            DataTable1BindingSource.DataSource = goods;
            this.reportViewer1.RefreshReport();
        }
    }
}