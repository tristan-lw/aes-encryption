﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES
{
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                flowLayoutPanel1.VerticalScroll.Value = e.NewValue;
            }
        }
    }
}
