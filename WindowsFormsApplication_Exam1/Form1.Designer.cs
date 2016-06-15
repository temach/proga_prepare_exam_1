namespace WindowsFormsApplication_Exam1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Author = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_PrintSorted = new System.Windows.Forms.Button();
            this.button_all_save2xml = new System.Windows.Forms.Button();
            this.button_separate_save2xml = new System.Windows.Forms.Button();
            this.button_add_from_xml = new System.Windows.Forms.Button();
            this.button_add_from_gui = new System.Windows.Forms.Button();
            this.listBox_Output = new System.Windows.Forms.ListBox();
            this.numericUpDown_Pages = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_DateAdded = new System.Windows.Forms.DateTimePicker();
            this.checkBox_Present = new System.Windows.Forms.CheckBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_search_author = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Pages)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(205, 18);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(182, 20);
            this.textBox_Name.TabIndex = 0;
            // 
            // textBox_Author
            // 
            this.textBox_Author.Location = new System.Drawing.Point(205, 45);
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.Size = new System.Drawing.Size(182, 20);
            this.textBox_Author.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_Price);
            this.panel1.Controls.Add(this.checkBox_Present);
            this.panel1.Controls.Add(this.dateTimePicker_DateAdded);
            this.panel1.Controls.Add(this.numericUpDown_Pages);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_Name);
            this.panel1.Controls.Add(this.textBox_Author);
            this.panel1.Location = new System.Drawing.Point(286, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 174);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pages:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date added:";
            // 
            // button_PrintSorted
            // 
            this.button_PrintSorted.Location = new System.Drawing.Point(13, 22);
            this.button_PrintSorted.Name = "button_PrintSorted";
            this.button_PrintSorted.Size = new System.Drawing.Size(125, 23);
            this.button_PrintSorted.TabIndex = 5;
            this.button_PrintSorted.Text = "Print Sorted";
            this.button_PrintSorted.UseVisualStyleBackColor = true;
            this.button_PrintSorted.Click += new System.EventHandler(this.button_PrintSorted_Click);
            // 
            // button_all_save2xml
            // 
            this.button_all_save2xml.Location = new System.Drawing.Point(13, 49);
            this.button_all_save2xml.Name = "button_all_save2xml";
            this.button_all_save2xml.Size = new System.Drawing.Size(125, 23);
            this.button_all_save2xml.TabIndex = 6;
            this.button_all_save2xml.Text = "Save ALL to xml";
            this.button_all_save2xml.UseVisualStyleBackColor = true;
            this.button_all_save2xml.Click += new System.EventHandler(this.button_all_save2xml_Click);
            // 
            // button_separate_save2xml
            // 
            this.button_separate_save2xml.Location = new System.Drawing.Point(13, 88);
            this.button_separate_save2xml.Name = "button_separate_save2xml";
            this.button_separate_save2xml.Size = new System.Drawing.Size(125, 23);
            this.button_separate_save2xml.TabIndex = 7;
            this.button_separate_save2xml.Text = "Save as separate xml files";
            this.button_separate_save2xml.UseVisualStyleBackColor = true;
            this.button_separate_save2xml.Click += new System.EventHandler(this.button_separate_save2xml_Click);
            // 
            // button_add_from_xml
            // 
            this.button_add_from_xml.Location = new System.Drawing.Point(13, 117);
            this.button_add_from_xml.Name = "button_add_from_xml";
            this.button_add_from_xml.Size = new System.Drawing.Size(125, 23);
            this.button_add_from_xml.TabIndex = 8;
            this.button_add_from_xml.Text = "Add from xml";
            this.button_add_from_xml.UseVisualStyleBackColor = true;
            this.button_add_from_xml.Click += new System.EventHandler(this.button_add_from_xml_Click);
            // 
            // button_add_from_gui
            // 
            this.button_add_from_gui.Location = new System.Drawing.Point(548, 192);
            this.button_add_from_gui.Name = "button_add_from_gui";
            this.button_add_from_gui.Size = new System.Drawing.Size(125, 23);
            this.button_add_from_gui.TabIndex = 9;
            this.button_add_from_gui.Text = "Add book from GUI";
            this.button_add_from_gui.UseVisualStyleBackColor = true;
            this.button_add_from_gui.Click += new System.EventHandler(this.button_add_from_gui_Click);
            // 
            // listBox_Output
            // 
            this.listBox_Output.FormattingEnabled = true;
            this.listBox_Output.Location = new System.Drawing.Point(38, 267);
            this.listBox_Output.Name = "listBox_Output";
            this.listBox_Output.Size = new System.Drawing.Size(635, 173);
            this.listBox_Output.TabIndex = 10;
            // 
            // numericUpDown_Pages
            // 
            this.numericUpDown_Pages.Location = new System.Drawing.Point(205, 67);
            this.numericUpDown_Pages.Name = "numericUpDown_Pages";
            this.numericUpDown_Pages.Size = new System.Drawing.Size(182, 20);
            this.numericUpDown_Pages.TabIndex = 8;
            // 
            // dateTimePicker_DateAdded
            // 
            this.dateTimePicker_DateAdded.Location = new System.Drawing.Point(205, 93);
            this.dateTimePicker_DateAdded.Name = "dateTimePicker_DateAdded";
            this.dateTimePicker_DateAdded.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker_DateAdded.TabIndex = 9;
            // 
            // checkBox_Present
            // 
            this.checkBox_Present.AutoSize = true;
            this.checkBox_Present.Location = new System.Drawing.Point(205, 119);
            this.checkBox_Present.Name = "checkBox_Present";
            this.checkBox_Present.Size = new System.Drawing.Size(164, 17);
            this.checkBox_Present.TabIndex = 10;
            this.checkBox_Present.Text = "This book is a present edition";
            this.checkBox_Present.UseVisualStyleBackColor = true;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(205, 143);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(182, 20);
            this.textBox_Price.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Price (only for non present books)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Print books of author";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_search_author
            // 
            this.textBox_search_author.Location = new System.Drawing.Point(143, 238);
            this.textBox_search_author.Name = "textBox_search_author";
            this.textBox_search_author.Size = new System.Drawing.Size(123, 20);
            this.textBox_search_author.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Author name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 452);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_search_author);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox_Output);
            this.Controls.Add(this.button_add_from_gui);
            this.Controls.Add(this.button_add_from_xml);
            this.Controls.Add(this.button_separate_save2xml);
            this.Controls.Add(this.button_all_save2xml);
            this.Controls.Add(this.button_PrintSorted);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Pages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Author;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.CheckBox checkBox_Present;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateAdded;
        private System.Windows.Forms.NumericUpDown numericUpDown_Pages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_PrintSorted;
        private System.Windows.Forms.Button button_all_save2xml;
        private System.Windows.Forms.Button button_separate_save2xml;
        private System.Windows.Forms.Button button_add_from_xml;
        private System.Windows.Forms.Button button_add_from_gui;
        private System.Windows.Forms.ListBox listBox_Output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_search_author;
        private System.Windows.Forms.Label label6;
    }
}

