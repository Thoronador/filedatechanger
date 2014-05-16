/*
    Windows Forms application for changing file dates
    Copyright (C) 2014  Thoronador

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Windows.Forms;

namespace FileDateChanger
{
    public partial class FormMain : Form
    {
        private System.IO.FileInfo globalFI = null;
        private const string dateFormat = "dddd, dd. MMMM yyyy, HH:mm:ss";
        
        //constructor
        public FormMain()
        {
            InitializeComponent();
            initializeCustomValues();
        }


        /// <summary>
        /// sets initial values for DateTimePickers
        /// </summary>
        private void initializeCustomValues()
        {
            dateTimePickerAccess.CustomFormat = dateFormat;
            dateTimePickerAccess.Enabled = false;
            dateTimePickerAccess.Value = DateTime.Now;

            dateTimePickerModified.CustomFormat = dateFormat;
            dateTimePickerModified.Enabled = false;
            dateTimePickerModified.Value = DateTime.Now;

            dateTimePickerCreated.CustomFormat = dateFormat;
            dateTimePickerCreated.Enabled = false;
            dateTimePickerCreated.Value = DateTime.Now;

            btnChangeAccess.Enabled = false;
            btnChangeCreated.Enabled = false;
            btnChangeModified.Enabled = false;
        }


        /// <summary>
        /// updates labels and DateTimePickers with the data from the given FileInfo structure
        /// </summary>
        /// <param name="fi">structure that holds the information about the current file</param>
        private void updateDisplayedData(System.IO.FileInfo fi)
        {
            lblFileName.Text = fi.FullName;
            //fill in creation time
            lblCreatedData.Text = fi.CreationTime.ToString();
            dateTimePickerCreated.Value = fi.CreationTime;
            dateTimePickerCreated_ValueChanged(dateTimePickerCreated, null);
            //fill in time of last modification
            lblModifiedData.Text = fi.LastWriteTime.ToString();
            dateTimePickerModified.Value = fi.LastWriteTime;
            dateTimePickerModified_ValueChanged(dateTimePickerModified, null);
            //time of last access
            lblAccessData.Text = fi.LastAccessTime.ToString();
            dateTimePickerAccess.Value = fi.LastAccessTime;
            dateTimePickerCreated_ValueChanged(dateTimePickerAccess, null);
        }


        /// <summary>
        /// enables all three DateTimePickers
        /// </summary>
        private void enablePickers()
        {
            dateTimePickerAccess.Enabled = true;
            dateTimePickerModified.Enabled = true;
            dateTimePickerCreated.Enabled = true;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (ofdFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = ofdFile.FileName;
                if (System.IO.File.Exists(filename))
                {
                    globalFI = new System.IO.FileInfo(filename);
                    updateDisplayedData(globalFI);
                    enablePickers();
                }//if exists
                else
                {
                    MessageBox.Show("Die angegebene Datei existiert nicht!");
                    return;
                }
            } //if

        }


        /// <summary>
        /// returns the DateTime value with milliseconds set to zero
        /// </summary>
        /// <param name="dt">a DateTime value</param>
        /// <returns>DateTime value with zero milliseconds</returns>
        private static DateTime ignoreMilliseconds(DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, 0);
        }

        private void dateTimePickerCreated_ValueChanged(object sender, EventArgs e)
        {
            if (null == globalFI)
                return;
            int cmp = ignoreMilliseconds(dateTimePickerCreated.Value).CompareTo(ignoreMilliseconds(globalFI.CreationTime));
            btnChangeCreated.Enabled = (cmp != 0);
        }

        private void dateTimePickerModified_ValueChanged(object sender, EventArgs e)
        {
            if (null == globalFI)
                return;
            int cmp = ignoreMilliseconds(dateTimePickerModified.Value).CompareTo(ignoreMilliseconds(globalFI.LastWriteTime));
            btnChangeModified.Enabled = (cmp != 0);
        }

        private void dateTimePickerAccess_ValueChanged(object sender, EventArgs e)
        {
            if (null == globalFI)
                return;
            int cmp = DateTime.Compare(ignoreMilliseconds(dateTimePickerAccess.Value), ignoreMilliseconds(globalFI.LastAccessTime));
            btnChangeAccess.Enabled = (cmp != 0);
        }

        private void btnChangeCreated_Click(object sender, EventArgs e)
        {
            globalFI.CreationTime = dateTimePickerCreated.Value;
            updateDisplayedData(globalFI);
        }

        private void btnChangeModified_Click(object sender, EventArgs e)
        {
            globalFI.LastWriteTime = dateTimePickerModified.Value;
            updateDisplayedData(globalFI);
        }

        private void btnChangeAccess_Click(object sender, EventArgs e)
        {
            globalFI.LastAccessTime = dateTimePickerAccess.Value;
            updateDisplayedData(globalFI);
        }
    }
}
