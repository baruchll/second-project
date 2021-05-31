using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rayon
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "FcfrmamSoDiqHtNn4AYVISfN6LSEHi5XGAO9Kp4N", 
            BasePath = "https://rayon-c214a-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public Boolean TzChecks
        {
            get
            {
                string s = txtTz.Text;
                int[] tzarr = new int[txtTz.Text.Length];

                for (int i = 0; i < txtTz.Text.Length; i++)
                {
                    tzarr[i] = int.Parse(s[i].ToString());
                }

                int[] check = { 1, 2, 1, 2, 1, 2, 1, 2 };

                int bikort = tzarr[s.Length - 1];//שווה לסיפרה האחרונה
                int tmp = 0;
                int sum = 0;

                for (int i = 0; i < check.Length; i++)
                {
                    tmp = tzarr[i] * check[i];
                    if (tmp > 10)
                    {
                        sum += tmp % 10 + 1;
                    }
                    else if (tmp == 10)
                    {
                        sum += 1;
                    }
                    else
                    {
                        sum += tmp;
                    }
                }
                if ((sum + bikort) % 10 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Boolean TzChecking()
        {
            string s = txtTz.Text;
            int[] tzarr = new int[txtTz.Text.Length];

            for (int i = 0; i < txtTz.Text.Length; i++)
            {
                tzarr[i] = int.Parse(s[i].ToString());
            }

            int[] check = { 1, 2, 1, 2, 1, 2, 1, 2 };

            int bikort = tzarr[s.Length - 1];//שווה לסיפרה האחרונה
            int tmp = 0;
            int sum = 0;

            for (int i = 0; i < check.Length; i++)
            {
                tmp = tzarr[i] * check[i];
                if (tmp > 10)
                {
                    sum += tmp % 10 + 1;
                }
                else if (tmp == 10)
                {
                    sum += 1;
                }
                else
                {
                    sum += tmp;
                }
            }
            if ((sum + bikort) % 10 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }









        private void Form1_Load(object sender, EventArgs e)
        {
            try 
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("יש שגיעה בשרת");
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTz_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKaba_TextChanged(object sender, EventArgs e)
        {
            
            
                
        }

        private void txtDapr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBagrut_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rezult_Click(object sender, EventArgs e)
        {
            int kaba2 = Int32.Parse(txtKaba.Text);
            int dapr2 = Int32.Parse(txtDapr.Text);
            int tz2 = Int32.Parse(txtTz.Text);
            int bagrut2 = Int32.Parse(txtBagrut.Text);
            Class1 user = new Class1()
            {
                name = txtName.Text,
                tz = txtTz.Text,
                kaba = txtKaba.Text,
                dapr = txtDapr.Text,
                bagrut = txtBagrut.Text

            };

            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtTz.Text) || String.IsNullOrEmpty(txtDapr.Text) || String.IsNullOrEmpty(txtKaba.Text) || String.IsNullOrEmpty(txtBagrut.Text))
            {
                string message = "יש תאים ריקים";
                MessageBox.Show(message);
            }
            else if (kaba2 < 41 || kaba2 > 56)
            {
                string messages = "קבא שגוי";
                MessageBox.Show(messages);
            }
            else if (dapr2 < 10 || dapr2 > 90)
            {
                string messages = "דפר שגוי";
                MessageBox.Show(messages);
            }
            else if (bagrut2 < 56 || dapr2 > 100)
            {
                string messages = "נכשלת בבגרות";
                MessageBox.Show(messages);
            }
            else if (TzChecking() == false)
            {
                string messages = "תז לא תקין";
                MessageBox.Show(messages);
            }


            else
            {

                var setter = client.Set("User/" + String.Format(txtTz.Text), user);
                string message = "עדכון פרטים לשרת בהצלחה";
                MessageBox.Show(message);
            }
            
        }

        private void profileCheck_Click(object sender, EventArgs e)
        {
            Class1 user = new Class1()
            {
                name = txtName.Text,
                tz = txtTz.Text,
                kaba = txtKaba.Text,
                dapr = txtDapr.Text,
                bagrut = txtBagrut.Text

            };
            if (TzChecking() == false)
            {
                string messages = "תז לא תקין";
                MessageBox.Show(messages);
            }
            else
            {
                var getter = client.Get("User/" + txtTz.Text);
                Class1 user2 = getter.ResultAs<Class1>();
                txtName.Text = user2.name;
                txtTz.Text = user2.tz;
                txtKaba.Text = user2.kaba;
                txtDapr.Text = user2.dapr;
                txtBagrut.Text = user2.bagrut;
            }


            
        }
    }

    
}
