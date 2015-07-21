﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIMS
{
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
        }
        public void SetNotifyInfo(int percent, string message)
        {
            this.labelProgress.Text = message;
            this.progressBar1.Value = percent;
        } 
    }
}