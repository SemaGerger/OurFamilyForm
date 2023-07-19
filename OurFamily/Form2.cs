using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace OurFamily
{
    public partial class Form2 : Form
    {
        int a;
        int b;
        
        DataTable dataTable = new DataTable();
        DataTable dataTable2 = new DataTable();
        Form3 form3 = new Form3();
       
        public Form2()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tarihlbl.Text = DateTime.Now.ToString();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dataTable.Columns.Add("Explanation");
            dataTable.Columns.Add("Balance");
            dataTable2.Columns.Add("Expenditure");
            dataTable2.Columns.Add("Price");

        }
        private void button1_Click(object sender, EventArgs e) //gelirbtn
        {
            
            aciklamaGelirTxt.Focus();
            if (aciklamaGelirTxt.Text != null || tutartGelirTxt.Text != null)
            {
                DataRow dataRow =dataTable.NewRow();
                dataRow["Balance"] = tutartGelirTxt.Text;
                dataRow["Explanation"] = aciklamaGelirTxt.Text;
               
                dataTable.Rows.Add(dataRow);
                dataGridViev1.DataSource = dataTable;

                int toplam =0;
                
                    for (int i = 0; i < dataGridViev1.Rows.Count; i++)
                    {
                        toplam += Convert.ToInt32(dataGridViev1.Rows[i].Cells[1].Value);
                    }
                    gelirToplamlbl.Text = toplam.ToString();
                    aciklamaGelirTxt.Clear();
                    tutartGelirTxt.Clear();
            }
            else
            {
                MessageBox.Show("Enter User Name and Passwort");
            }

        }
        void VeriAl()
        {
            a = Convert.ToInt32(gelirToplamlbl.Text); //ilk sayıyı labeldan okuyorum
            b = Convert.ToInt32(giderToplamlbl.Text);

        }
        private void button2_Click(object sender, EventArgs e) //giderbtn
        {
            
                DataRow dataRow = dataTable2.NewRow();
                dataRow["Price"] = tutarGiderTxt.Text;
                dataRow["Expenditure"] = aciklamaGiderTxt.Text;

                dataTable2.Rows.Add(dataRow);
                dataGridView1.DataSource = dataTable2;
            if (aciklamaGiderTxt.Text != null && tutarGiderTxt.Text != null)
            {
                int toplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    
                    toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                }
                giderToplamlbl.Text = toplam.ToString();
                aciklamaGiderTxt.Clear();
                tutarGiderTxt.Clear();
            }
            else
            {
                MessageBox.Show("Açıklama veya Tutar girin");
            }

            VeriAl();
            int cikartma = a - b; //iki sayıyı çıkartıyorum
            farklbl.Text = cikartma.ToString(); //label1'e sonucu yazdırıyorum.


            if (a < b)
            {
                farklbl.ForeColor = Color.Red;
            }
        }
          
    private void kaydetBtn_Click(object sender, EventArgs e)
        {

            Form3 form2 = new Form3();

            if (farklbl.Text != null)
            {
              
                form3.kaydetBox.Items.Add(tarihlbl.Text + " \r Explanation: "
                                           + gelirToplamlbl.Text + " Expenditure: " + giderToplamlbl.Text + " \n Account: "
                                           + farklbl.Text);


                MessageBox.Show("Verilerin bizimle güvende ;)");
                form3.ShowDialog();

            }
            else
            {
                MessageBox.Show("Gider taplosunu da doldurman gerekiyor canım");
            }

   




        }
        private void button1_Click_1(object sender, EventArgs e) //gelir sil butonu
        {

            if (dataGridViev1.SelectedRows.Count > 0)
            {
                dataGridViev1.Rows.RemoveAt(dataGridViev1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lüffen silinecek satırı seçin.");
            }


        }
        private void button2_Click_1(object sender, EventArgs e) //gider sil butonu
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lüffen silinecek satırı seçin.");
            }
        }
    }
}
