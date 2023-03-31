using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using dataacsseslayer;
using Logiclayer;

namespace NkatmanliProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Class1> perlist = Logicpersonel.llpersonellistele();
            dataGridView1.DataSource = perlist;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Class1 ent = new Class1();
            ent.Ad = txtad.Text;    
            ent.Soyad = txtsoyad.Text;
            ent.Sehir = txtsehir.Text;
            ent.Gorev = txtgörev.Text;
            ent.Maas = short.Parse(txtmaas.Text);
            Logicpersonel.LLpersonelekle(ent);

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            Class1 ent = new Class1();
            ent.Id=Convert.ToInt32(txtıd.Text);
            Logicpersonel.LLpersonelsil(ent.Id);
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            Class1 ent = new Class1();
            ent.Id = Convert.ToInt32(txtıd.Text);
            ent.Ad=txtad.Text;  
            ent.Soyad =txtsoyad.Text;
            ent.Gorev = txtgörev.Text;
            ent.Sehir = txtsehir.Text;
            ent.Maas = short.Parse(txtmaas.Text);
            Logicpersonel.LLpersonelgüncelle(ent);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int tıklanan = dataGridView1.SelectedCells[0].RowIndex;
            txtıd.Text = dataGridView1.Rows[tıklanan].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[tıklanan].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[tıklanan].Cells[2].Value.ToString();
            txtsehir.Text = dataGridView1.Rows[tıklanan].Cells[3].Value.ToString();
            txtgörev.Text = dataGridView1.Rows[tıklanan].Cells[4].Value.ToString();
            txtmaas.Text = dataGridView1.Rows[tıklanan].Cells[5].Value.ToString();
        }
    }
}
