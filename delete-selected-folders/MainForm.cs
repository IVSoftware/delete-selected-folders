using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace delete_selected_folders
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Make an array of the checkboxes to use throughout the app.
            _checkboxes = Controls.OfType<CheckBox>().ToArray();

            // This provides a way to make sure the Clear button is
            // only enabled when one or more checkboxes is marked.
            foreach (CheckBox checkBox in _checkboxes)
            {
                checkBox.CheckedChanged += onAnyCheckboxChanged;
            }

            // Attach the 'Click' handler to the button if you 
            // haven't already done this in the form Designer.
            buttonClear.Enabled = false;
            buttonClear.Click += onClickClear;
        }
        const string basePath = @"D:\java\";
        CheckBox[] _checkboxes;

        private void onAnyCheckboxChanged(object sender, EventArgs e)
        {
            buttonClear.Enabled = _checkboxes.Any(_=>_.Checked);
        }

        private void onClickClear(object sender, EventArgs e)
        {
            // Get the checkboxes that are selected.
            CheckBox[] selectedCheckBoxes = 
                _checkboxes.Where(_ => _.Checked).ToArray();
            foreach (CheckBox checkBox in selectedCheckBoxes)
            {
                // Build the folder path
                string folderPath = Path.Combine(basePath, checkBox.Text);
                // Can't delete if it doesn't exist.
                if (Directory.Exists(folderPath)) 
                {
                    // Delete the directory and all its files and subfolders.
                    Directory.Delete(path: folderPath, recursive: true);
                }
                // Replace deleted folder with new, empty one.
                Directory.CreateDirectory(path: folderPath);
            }
        }
    }
}
