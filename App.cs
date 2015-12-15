﻿using Svg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jimney
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // base.OnPaintBackground(e);
        }

        private void App_Load(object sender, EventArgs e)
        {
            string resourceName = "jimney.Resources.Shapes.svg";
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                SvgDocument document = SvgDocument.Open<SvgDocument>(stream);
                overlayControlMain.Width = (int)document.Width;
                overlayControlMain.Height = (int)document.Height;
                overlayControlMain.Image = document.Draw();
            }
        }

        private void App_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                Close();
            }
        }
    }
}
