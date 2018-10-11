using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DecyzjaKredytowa
{
    public partial class Form3 : Form
    {
        
        private string info = Form2.GetInfo();

        //Konstruktor okna z podsumowaniem
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            ShowSummary();
        }
        
        private void ShowSummary()
        {

            textBox2.Text = info;


        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }
        //Metoda zamykająca aplikację po wyłączeniu okna
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
