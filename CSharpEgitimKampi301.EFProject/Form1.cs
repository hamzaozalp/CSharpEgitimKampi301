using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //İşlemler Burada
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //İşlemler Burada
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //İşlemler Burada
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //İşlemler Burada
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //İşlemler Burada
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //İşlemler Burada
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Guide guide = new Guide();
            guide.GuideName = txtName.Text;
            guide.GuideSurname = txtSurname.Text;
            db.Guide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla eklendi");
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

        private void btnList1_Click(object sender, EventArgs e)
        {
            var values = db.Guide.ToList();
            //dataGridView1.DataSource = values;
            dataGridView2.DataSource = values;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //bak mesela forma iki kere tıkladım beni üstteki form
            //loada attı 
            //datagridviewa tıkladım beni click kısımına attı;
            //sen formda nereye iki kere tıklarsan
            //onla ilgili kısıma atar 
            //hocamızın işine yaramadığında bunlar şuanlık
            //hocamız tıklamamış tıklamadığından kaynaklı olarak
            //hocamız da bu kodlar çıkmıyor 
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var removeValue = db.Guide.Find(id);
            db.Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla silindi");
        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);
            var updateValue = db.Guide.Find(id);
            updateValue.GuideName = txtName.Text;
            updateValue.GuideSurname= txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla güncellendi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnGetById1_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);
            var values=db.Guide.Where(x=> x.GuideId ==id).ToList();
            dataGridView2.DataSource = values;
        }
    }
}
