using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageUpload
{
    public partial class StudentDetails : Form
    {
        string connectionString = "Server=DESKTOP-T7TL75O\\SQLEXPRESS;Database=ImageUpload;Trusted_Connection=True;";
        string Gender;
        string Education;
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //image
            byte[] imageBit = null;
            FileStream fileStream = new FileStream(picUpload.ImageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            imageBit = binaryReader.ReadBytes((int)fileStream.Length);


            //Connection
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("StudentInsert", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Name", txtName.Text);
            command.Parameters.AddWithValue("Address", txtAddress.Text);
            command.Parameters.AddWithValue("Gender", Gender);
            command.Parameters.AddWithValue("Education",Education);
            command.Parameters.AddWithValue("Image", imageBit);

            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Saved Data");

            txtName.Text = txtAddress.Text  =  "";
            radioMale.Checked = false;
            radioFemale.Checked = false;
            checkUg.Checked = false;
            CheckPg.Checked = false;
            picUpload.Image = null;
          
        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void checkUg_CheckedChanged(object sender, EventArgs e)
        {
           if(checkUg.Checked == true && CheckPg.Checked == true)
            {
                Education = "UG";
                Education = "PG";
            }
           else if(CheckPg.Checked == true)
            {
                Education = "PG";
            }
            else if(checkUg.Checked == true)
            {
                Education = "UG";
            }
        }

        private void CheckPg_CheckedChanged(object sender, EventArgs e)
        {
            if (checkUg.Checked == true && CheckPg.Checked == true)
            {
                
                Education = "UG" + " " + "PG";
            }
            else if (CheckPg.Checked == true)
            {
                Education = "PG";
            }
            else if (checkUg.Checked == true)
            {
                Education = "UG";
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "JPG Files(*.jpg) | *.jpg | JPEG Files(*.jpeg) | *.jpeg | PNG Files(*.png) | *.png | All Files(*.*) | *.*";
            if(openDialog.ShowDialog() == DialogResult.OK)
            {
                String picLocation = openDialog.FileName.ToString();
                picUpload.ImageLocation = picLocation;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //Connection
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("Select Name,Address,Gender,Education,Image from Student_Details where Name ='" + txtName.Text +"' ;", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                    string name      = (string)reader["Name"];
                    string address   = (string)reader["Address"];
                    string gender    = (string)reader["Gender"];
                    string education = (string)reader["Education"];
                   

                txtName.Text = name;
                txtAddress.Text = address;

                //read radiobutton

                if(gender == "Male")
                {
                    radioMale.Checked = true;
                    radioFemale.Checked = false;
                }
                else
                {
                    radioMale.Checked = false;
                    radioFemale.Checked = true;
                }

                //read checkbox
                if(education == "UG")
                {
                    checkUg.Checked = true;
                }
                else
                {
                   
                    CheckPg.Checked = true;
                  
                }
              
                byte[] image = (byte[])(reader["Image"]);
                if(image == null)
                {
                    picUpload.Image = null;
                }
                else
                {
                    MemoryStream memoryStream = new MemoryStream(image);
                    picUpload.Image = System.Drawing.Image.FromStream(memoryStream);
                }
                

            }
        }
    }
}
