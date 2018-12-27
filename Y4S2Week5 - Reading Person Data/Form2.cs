using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y4S2Week5___Reading_Person_Data
{
    public partial class Form2 : Form
    {
        Dictionary<string, IReading> dicDR = new Dictionary<string, IReading>();
        OpenFileDialog fd = new OpenFileDialog();
        public delegate void AddedHandler(List<object[]> lst);
        public event AddedHandler added;
        public Form2()
        {
            InitializeComponent();
            dicDR.Add("<Name>;<Age>;<Height>", new DataReading());
            dicDR.Add("Name = <Name>; Height = <Height>; Age = <Age>;", new DataReading2());
            cmbFormat.DataSource = dicDR.Keys.ToList();
            btnBrowse.Click += Button1_Click;
            btnImport.Click += BtnImport_Click;
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            IReading ir = dicDR[cmbFormat.SelectedItem.ToString()];
            List<object[]> obj = ir.GetData(new System.IO.StreamReader(fd.FileName));
            added?.Invoke(obj);
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = fd.ShowDialog();
            txtFileName.Text = fd.FileName;
        }
        
    }
}
