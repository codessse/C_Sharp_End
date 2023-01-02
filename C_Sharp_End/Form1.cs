using CsvHelper;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq; 

namespace C_Sharp_End
{
    public partial class Form1 : Form
    {
        private FirestoreDb db;
        private Form2 f2 = new Form2();
        public Dictionary<string, object> SelectedName;
        //private Dictionary<int, string> JOB = new Dictionary<int, string> { { 1,"先鋒"},{ 2,"近衛"},{ 3,"重裝"}, { 4, "狙擊" }, { 5, "術士" }, { 6, "輔助" }, { 7, "醫療" }, { 8, "特種" } };
        public Form1()
        {
            InitializeComponent();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            FireStoreInit();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string start = StartCkBtn_Listen();
            string job = JobCkBtn_Listen();
            string _name = name.Text;

            DataGridViewRowCollection rows = dataGridView1.Rows;


            CollectionReference arkRef = db.Collection("ark");
            QuerySnapshot querySnapshot;
            if (!string.IsNullOrEmpty(_name))
            {
                Console.WriteLine("0");
                Query query = arkRef.WhereEqualTo("名字", _name);
                querySnapshot = await query.GetSnapshotAsync();
            }
            else if (!string.IsNullOrEmpty(start) && !string.IsNullOrEmpty(job))
            {
                //MessageBox.Show("start " + start + " job " + job);
                Console.WriteLine("1");
                Query query = arkRef.WhereEqualTo("稀有度", Int64.Parse(start)).WhereEqualTo("職業", job);
                querySnapshot = await query.GetSnapshotAsync();
            }
            else if (!string.IsNullOrEmpty(start))
            {
                Console.WriteLine("2");
                Query query = arkRef.WhereEqualTo("稀有度", Int64.Parse(start));
                querySnapshot = await query.GetSnapshotAsync();
            }
            else if (!string.IsNullOrEmpty(job))
            {
                Console.WriteLine("3");
                Query query = arkRef.WhereEqualTo("職業", job);
                querySnapshot = await query.GetSnapshotAsync();
            }
            else
            {
                Console.WriteLine("4");
                querySnapshot = await arkRef.GetSnapshotAsync();
            }

            Console.WriteLine("Select start {0}, job {1} ", start, job);
            Console.WriteLine("Document {0} returned ", querySnapshot.Documents.Count);
            Console.WriteLine("");
            if (querySnapshot.Documents.Count != 0)
            {
                foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
                {
                    Console.WriteLine("Document {0} returned ", documentSnapshot.Id);
                    Dictionary<string, object> res = documentSnapshot.ToDictionary();
                    //MessageBox.Show(res["名字"].ToString());
                    foreach (KeyValuePair<string, object> pair in res)
                    {

                        Console.WriteLine("{0}: {1}", pair.Key, pair.Value);

                    }
                    rows.Add(new object[] { res["名字"], res["稀有度"], res["職業"], res["特性"] });
                    Console.WriteLine("");


                }
            }

            else MessageBox.Show("Not Found");

        }

        private void ClearSelected()
        {
            foreach (Control c in startPanel.Controls)
            {
                if (((RadioButton)c).Checked)
                {
                    ((RadioButton)c).Checked = false;
                    break;
                }
            }

            foreach (Control c in jobPanel.Controls)
            {
                if (((RadioButton)c).Checked)
                {
                    ((RadioButton)c).Checked = false;
                    break;
                }
            }
        }


        private void FireStoreInit()
        {
            try
            {
                //string filepath = @"D:\Program\C#\C_Sharp_End\test-7fcac-firebase-adminsdk-yxi9e-bbbf9a7c71.json";
                //Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
                string projectid = "";
                db = FirestoreDb.Create(projectid);
                Console.WriteLine("Created Cloud Firestore client with project ID: {0}", projectid);
            }
            catch (Exception)
            {
                MessageBox.Show("Google FireStore Connect Failed");
                System.Environment.Exit(1);
            }
        }

        private string StartCkBtn_Listen()
        {
            string selected = "";
            foreach (Control c in startPanel.Controls)
            {
                if (((RadioButton)c).Checked)
                {
                    selected = c.Text.ToString();
                    break;
                }
            }
            //MessageBox.Show(index.ToString());
            return selected;
        }

        private string JobCkBtn_Listen()
        {
            string selected = "";
            List<string> jobSelectList = new List<string>();
            foreach (Control c in jobPanel.Controls)
            {
                if (((RadioButton)c).Checked)
                {
                    selected = c.Text.ToString();
                    break;
                }
            }
            //MessageBox.Show(tmp);
            return selected;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearSelected();
        }

        private async void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string index = e.RowIndex.ToString();
            //MessageBox.Show(dataGridView1.Rows[Int16.Parse(index)].Cells[0].Value.ToString());
            string _name = dataGridView1.Rows[Int16.Parse(index)].Cells[0].Value.ToString();
            CollectionReference arkRef = db.Collection("ark");
            Query query = arkRef.WhereEqualTo("名字", _name);
            QuerySnapshot querySnapshot = await query.GetSnapshotAsync();
            DocumentSnapshot documentSnapshot = querySnapshot.Documents[0];
            SelectedName = documentSnapshot.ToDictionary();
            f2.SelectedName = SelectedName;
            f2.ShowDialog();
        }



    }

}
