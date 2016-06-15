using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_Exam1
{
    public partial class Form1 : Form
    {
        private MyLibrary mylib = new MyLibrary(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void SetOutput(IEnumerable<MyBook> data)
        {
            if (data.Count() < 1)
            {
                return;
            }
            this.listBox_Output.Items.Clear();
            foreach (var item in data)
            {
                this.listBox_Output.Items.Add(item.ToString());
            }
            this.listBox_Output.Invalidate();
        }

        /// <summary>
        /// Opens a dialog to get path of file to open from te user.
        /// </summary>
        public static string OpenFileDialogGetPath()
        {
            OpenFileDialog file_dialog = new OpenFileDialog
            {
                InitialDirectory = AppDomain.CurrentDomain.BaseDirectory,
                Filter = "All files (*.*)|*.*",
                FilterIndex = 0,
                RestoreDirectory = true,
                Title = "Select a file...",
            };
            if (file_dialog.ShowDialog() == DialogResult.OK) {
                return file_dialog.FileName;
            }
            return null;
        }


         /// <summary>
        /// Opens the dialog to get the path at which to save the current data.
        /// </summary>
        /// <returns></returns>
        public static string SaveFileDialogGetPath()
        {
            SaveFileDialog file_dialog = new SaveFileDialog
            {
                InitialDirectory = AppDomain.CurrentDomain.BaseDirectory,
                Filter = "All files (*.*)|*.*",
                FilterIndex = 0,
                RestoreDirectory = true,
                Title = "Select where to save your file...",
            };
            if (file_dialog.ShowDialog() == DialogResult.OK) {
                return file_dialog.FileName;
            }
            return null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_add_from_gui_Click(object sender, EventArgs e)
        {
            var book = new MyBook();
            book.Author = this.textBox_Author.Text;
            book.Name = this.textBox_Name.Text;
            book.PageCount = this.numericUpDown_Pages.Value;
            book.Price = this.textBox_Price.Text;
            book.DateAdded = this.dateTimePicker_DateAdded.Value;
            book.IsPresent = this.checkBox_Present.Checked;
            mylib.AddBook(book);
        }

        private void button_PrintSorted_Click(object sender, EventArgs e)
        {
            SetOutput(mylib.GetData().OrderBy(bk => bk.DateAdded));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = mylib.PresentBooksOfAuthor(this.textBox_search_author.Text);
            SetOutput(data.OrderBy(bk => bk.DateAdded));
        }

        private void button_all_save2xml_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = SaveFileDialogGetPath();
                mylib.WriteOneFile(fname);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not write to file.");
                return;
            }
            MessageBox.Show("Saved to file");
        }

        private void button_separate_save2xml_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = SaveFileDialogGetPath();
                mylib.WriteManyFiles(fname);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not write to many files.");
                return;
            }
            MessageBox.Show("Saved to many files");
        }

        private void button_add_from_xml_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = OpenFileDialogGetPath();
                mylib.AddFromXmlFile(fname);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not read from file.");
                return;
            }
            MessageBox.Show("Read data from file");
        }
    }
}
