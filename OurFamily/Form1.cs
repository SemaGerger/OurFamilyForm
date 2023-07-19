using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurFamily
{
    public partial class Form1 : Form
    {
        DataTable dataTable = new DataTable();
        Form2 form2 = new Form2();
        
        public Form1()
        {
            InitializeComponent();
            DbContext db = new DbContext();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[]
            user = new string[] { "se", "3", "Sema", "Gerger" };
            dataGridView2.Rows.Add(user);
            user = new string[] { "er", "4", "Erhan", "Kaya" };
            dataGridView2.Rows.Add(user);
            user = new string[] { "öz", "5", "Özlem", "Tepe" };
            dataGridView2.Rows.Add(user);
        }
        private void LoginBtn_Click(object sender, EventArgs e)//login
         
        {
            DataRow dataRow = dataTable.NewRow();
            string[]
          user = new string[2];
            user[0] = userNameTxt.Text;
            user[1] = passwordTxt.Text;

            dataGridView2.DataSource = dataTable;
            bool durum = false;
            foreach (var user1 in DbContext.UserList.ToList())
            {
                if (user[0] == userNameTxt.Text && user[1] == passwordTxt.Text)
                {
                    form2 = new Form2();
                    MessageBox.Show("Muhteşem Our Family deneyimine Hoşgeldiniz");
                    //form2.nameSurnameLbl.Text = user.Name + " " + user.Surname;
                    form2.Show();
                    durum = true;
                    this.Hide();
                    break;
                }

            }
            if (durum == false) 
                
                MessageBox.Show("Giriş Başarısız");
        }
        private void signRegBox_Click(object sender, EventArgs e)
        {
            bool durum = false;
            if (userNameRegBox.Text != null && passwordRegBox.Text != null )
            {
            string[]
            user = new string[4];
            user[0] = userNameRegBox.Text;
            user[1] = nameRegBox.Text;
            user[2] = surnameRegBox.Text;
            user[3] = passwordRegBox.Text;
                dataGridView2.Rows.Add(user);
                durum = true;   
            MessageBox.Show("Bravo " + nameRegBox.Text + "\n You are registered");

            }

            if (durum == false)
            {
                MessageBox.Show("Try Again");
            }
        }
         
    }
}
