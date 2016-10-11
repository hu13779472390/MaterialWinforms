﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaterialWinforms.Controls.Settings
{
    public partial class MaterialThemeSettings : MaterialUserControl
    {
        public MaterialThemeSettings()
        {
            InitializeComponent();
        }

        private void materialToggle1_CheckedChanged(object sender, EventArgs e)
        {
            ColorOverlay objOverlay = new ColorOverlay(PointToScreen(materialToggle1.Location), (materialToggle1.Checked ? MaterialSkinManager.Themes.DARK : MaterialSkinManager.Themes.LIGHT));
            objOverlay.Show();
        }
    }
}