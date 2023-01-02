using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;

namespace C_Sharp_End
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (open.ShowDialog() != DialogResult.OK) return;


            FireStoreInit(open.FileName);
        }

        private void FireStoreInit(string filepath)
        {
            try
            {
                FirestoreDb db;
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
                string projectid = "";
                db = FirestoreDb.Create(projectid);
                MessageBox.Show("Google FireStore Connect Success");
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Google FireStore Connect Failed");
                System.Environment.Exit(1);
                throw;
            }
        }
    }
}
