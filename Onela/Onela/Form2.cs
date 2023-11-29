﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Onela
{
    public partial class Frm2 : Form
    {
        public ListContacts listContacts = new ListContacts();
        public Contact _contact;
        public Frm1 GetFrm1;
        public static string _firstName = "";
        public static string _lastName = "";
        public static string _numberPhone = "";

        public Frm2(Frm1 frm1)
        {
            InitializeComponent();
            GetFrm1 = frm1;
        }
        private void button_createContacts_Click(object sender, EventArgs e)
        {
            _firstName = textBox_firstnameNewContacts.Text;
            _lastName = textBox_lastnameNewContacts.Text;
            _numberPhone = textBox_numberNewContacts.Text;

            _contact = new Contact(_firstName, _lastName, _numberPhone);
            listContacts.addContact(_contact);

            this.Close();
            GetFrm1.Show();
            GetFrm1.UpdateListBox(listContacts);
        }
    }
}
