﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtOutput.Text = Convert.ToBase64String(Encoding.Unicode.GetBytes(txtString.Text));
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtString.Text = Encoding.Unicode.GetString(Convert.FromBase64String(txtOutput.Text));
        }
    }
}
