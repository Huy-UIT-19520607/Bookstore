﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Forms.Business
{
    public partial class frmBookReceipt_Add : Form
    {
        public frmBookReceipt_Add()
        {
            InitializeComponent();
            if (!ValidateInput.ValidOnlyLetterAndNumber(txtPublisher.Text, out errMsg))
        }

        
    }
}
