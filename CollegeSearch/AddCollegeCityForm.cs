using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CollegeSearch
{
    public partial class AddCollegeCityForm : Form
    {
        string filename = @"C:\Users\dalli\source\repos\CollegeSearch\collegecity.txt";
        public AddCollegeCityForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Loads the text file that contains the colleges and cities before the text loads. Adds it's contents to a list that can be viewed in the listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCollegeCityForm_Load(object sender, EventArgs e)
        {
            StreamReader inputfile;
            try
            {
                inputfile = File.OpenText(filename);
                while (!inputfile.EndOfStream)
                {
                    LstBox.Items.Add(inputfile.ReadLine());
                }
                inputfile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);              
            }

        }
        /// <summary>
        /// We take the user input and append it to the end of the text file. We first make sure there is valid input. We concatenate the two user inputs from the text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string userCollege = TxtBoxCollege.Text;
            string userCity = TxtBoxCity.Text;
            if (userCollege != "" && userCity != "")
            {
                string collegecity = $"{userCollege},{userCity}";
                try
                {
                    StreamWriter outputfile = File.AppendText(filename);
                    outputfile.WriteLine(collegecity);
                    outputfile.Close();
                    LstBox.Items.Add(collegecity);
                    TxtBoxCity.Clear();
                    TxtBoxCollege.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
