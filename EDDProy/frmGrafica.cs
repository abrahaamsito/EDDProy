﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    public partial class frmGrafica : Form
    {
        public frmGrafica()
        {
            InitializeComponent();
        }
        public void ActualizaGrafica(Bitmap Img)
        {
            picGrafica.Image = Img;
        }
    }
}
