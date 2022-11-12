using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Init skin
            //MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            //skinManager.AddFormToManage(this);
            //skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900, 
            //    MaterialSkin.Primary.BlueGrey900, 
            //    MaterialSkin.Primary.Blue500, 
            //    MaterialSkin.Accent.Orange700, 
            //    MaterialSkin.TextShade.WHITE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
