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

namespace Y4S2Week5___Reading_Person_Data
{
    public partial class Form1 : Form
    {
        
        BindingList<Person> lstPerson = new BindingList<Person>();
        public Form1()
        {
            InitializeComponent();
            add();
            btnImport.Click += BtnImport_Click;
            dataGridView1.DataSource = lstPerson;
            
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.added += Frm_added;
            frm.Show();
        }

        private void Frm_added(List<object[]> lst)
        {
            foreach (object[] obj in lst)
            {
                lstPerson.Add(new Person(obj));
            }
        }

        private void add()
        {
            lstPerson.Add(new Person(new object[] { "Thor", "900", "1.90" }));
        }
    }
}
