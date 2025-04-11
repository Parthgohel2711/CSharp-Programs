using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBox
{
    public partial class MessageBox: Form
    {
        public MessageBox()
        {
            InitializeComponent();
        }

        static MessageBox M;
        static String Button_id;

        public static String Show(String Message, String Title, String Btn, String Image)
        {
            //M is Object Of This Page
            
            //Difine Object of This Form
            M = new MessageBox();
            
            //Set Message Text Pass From Calling Method
            //Text is Name of RichtextBox
            M.Text.Text = Message;
            
            //Set Title Text Pass From Calling Method
            //Title is Name of Label
            M.Title.Text = Title;
            
            //Set Button Text Pass From Calling Method
            if (Btn == "YesNo")
            {
                //Btn1,Btn2,Btn3 is Name of Button
                //Set Button Location As X and Y
                
                M.Btn1.Text = "Yes";
                M.Btn1.Location = new Point(33, 261);
                M.Btn2.Text = "No";
                M.Btn2.Location = new Point(174, 261);
                M.Btn3.Visible = false;

            }
            else if (Btn == "Ok")
            {
                M.Btn1.Text = "Ok";
                M.Btn1.Location = new Point(104, 261);
                M.Btn2.Visible = false;
                M.Btn3.Visible = false;
            }
            else if (Btn == "AbortRetryCancel")
            {
                M.Btn1.Text = "Abort";
                M.Btn1.Location = new Point(9, 261);
                M.Btn2.Text = "Retry";
                M.Btn2.Location = new Point(104, 261);
                M.Btn3.Text = "Cancel";
                M.Btn3.Location = new Point(199, 261);
            }
            else if (Btn == "RetryCancel")
            {
                M.Btn1.Text = "Retry";
                M.Btn1.Location = new Point(33, 261);
                M.Btn2.Text = "Cancel";
                M.Btn2.Location = new Point(174, 261);
                M.Btn3.Visible = false;
            }
            else if (Btn == "YesNoCancel")
            {
                M.Btn1.Text = "Yes";
                M.Btn1.Location = new Point(9, 261);
                M.Btn2.Text = "No";
                M.Btn2.Location = new Point(104, 261);
                M.Btn3.Text = "Cancel";
                M.Btn3.Location = new Point(199, 261);
            }
            else if (Btn == "OkCancel")
            {
                M.Btn1.Text = "Ok";
                M.Btn1.Location = new Point(33, 261);
                M.Btn2.Text = "Cancel";
                M.Btn2.Location = new Point(174, 261);
                M.Btn3.Visible = false;
            }

            //Image is Name PictureBox
            //Set Image Path And Take Image Name as a String For Show Image
            
            M.Image.Image = new Bitmap("D:\\CSharp-Program\\MessageBox\\MessageBox\\Resources\\" + Image + ".png");
            M.ShowDialog();
            return Button_id;
        }



        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (Btn1.Text == "Yes")
            {
                Button_id = "1";
                M.Dispose();
            }
            else if (Btn1.Text == "Ok")
            {
                Button_id = "4";
                M.Dispose();
            }
            else if (Btn2.Text == "Abort")
            {
                Button_id = "5";
                M.Dispose();
            }
            else if (Btn2.Text == "Retry")
            {
                Button_id = "6";
                M.Dispose();
            }
            else
            {
                Button_id = "8";
                M.Dispose();
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (Btn1.Text == "No")
            {
                Button_id = "2";
                M.Dispose();
            }
            else if (Btn1.Text == "Cancel")
            {
                Button_id = "3";
                M.Dispose();
            }
            else if (Btn2.Text == "Retry")
            {
                Button_id = "6";
                M.Dispose();
            }
            else
            {
                Button_id = "8";
                M.Dispose();
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (Btn1.Text == "Cancel")
            {
                Button_id = "3";
                M.Dispose();
            }
            else if (Btn2.Text == "Ignore")
            {
                Button_id = "7";
                M.Dispose();
            }
            else
            {
                Button_id = "8";
                M.Dispose();
            }
        }
    }
}
