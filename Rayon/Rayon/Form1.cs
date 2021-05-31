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

        public Boolean TzCheck() 
        {

            int tz = Int32.Parse(txtTz.Text);
            int[] tzChecking = { 21212121 } ;
            int[] arr = new int[ 8];
            int bikoret = tz % 10;
            int temp = 0, sum = 0,sum2 = 0;
            int tz2 = tz / 10;


            int[] toArray = Array.ConvertAll(tz2.ToString().ToArray(), x => (int)x);


            for (int i = 0; i < tzChecking.Length; i++) 
            {
                temp = arr[i] * tzChecking[i];
                if (temp > 10) {
                    sum += temp % 10 + 1;

                }
                else if(temp == 10)
                {
                    sum += 1;  
                }
                else
                {
                    sum += temp;
                }


            }
            sum2 = sum + bikoret;
            if ((sum2) % 10 == 0)
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
            else if (TzCheck() == false)
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

        
    }

    
}
