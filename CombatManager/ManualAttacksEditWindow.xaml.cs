/*
 *  ManualAttacksEditWindow.xaml.cs
 *
 *  Copyright (C) 2010-2012 Kyle Olson, kyle@kyleolson.com
 *
 *  This program is free software; you can redistribute it and/or
 *  modify it under the terms of the GNU General Public License
 *  as published by the Free Software Foundation; either version 2
 *  of the License, or (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 * 
 *  You should have received a copy of the GNU General Public License
 *  along with this program; if not, write to the Free Software
 *  Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 *
 */

﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CombatManager
{
	/// <summary>
	/// Interaction logic for ManualAttacksEditWindow.xaml
	/// </summary>
	public partial class ManualAttacksEditWindow : Window
	{
        private Monster _Monster;

		public ManualAttacksEditWindow()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

		private void OKButton_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            string attacks = MeleeTextBox.Text.Trim();
            if (attacks.Length == 0)
            {
                attacks = null;
            }
            _Monster.Melee = attacks;
            attacks = RangedTextBox.Text.Trim();
            if (attacks.Length == 0)
            {
                attacks = null;
            }
            _Monster.Ranged = attacks;
            Close();
		}

        public Monster Monster
        {
            get
            {
                return _Monster;
            }
            set
            {
                if (_Monster != value)
                {
                    _Monster = value;

                    this.DataContext = _Monster;

                    MeleeTextBox.Text = _Monster.Melee;
                    RangedTextBox.Text = _Monster.Ranged;
                }
            }
        }
	}
}