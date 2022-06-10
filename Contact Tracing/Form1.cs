using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class IdentityForm : Form
    {
        public IdentityForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btnsubmit_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\dell\source\repos\Contact Tracing\identityform.txt", true);
            file.WriteLine("Full Name: " + txtFullname.Text);
            file.WriteLine("Gender: " + txtGender.Text);
            file.WriteLine("Age: " + txtAge.Text);
            file.WriteLine("Religion: " + txtReligion.Text);
            file.WriteLine("Cilvil Status: " + txtCivilstatus.Text);
            file.WriteLine("Complete Address: " + txtCompleteaddress.Text);
            file.WriteLine("Email Address: " + txtEmailaddress.Text);
            file.WriteLine("Contact Number: " + txtcontactnum.Text);
            file.Close();

            StreamReader reader = new StreamReader(@"C:\Users\dell\source\repos\Contact Tracing\identityform.txt");
            String all = reader.ReadToEnd();
            MessageBox.Show(all, "Identity Form");

           
                
        }
        
    }
}
