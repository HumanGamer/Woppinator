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

namespace Woppinator
{
    public partial class MainForm : Form
    {
        private const string BaseTitle = "Woppinator";

        private WopFile _currentWopFile;

        private WopFile currentWopFile
        {
            get
            {
                return _currentWopFile;
            }
            set
            {
                _currentWopFile = value;
                if (_currentWopFile != null)
                {
                    _currentWopFile.OnDirtyChanged += dirty =>
                    {
                        UpdateTitle();
                    };
                }
                UpdateDisplay();
            }
        }
        private string currentPath;

        public MainForm()
        {
            InitializeComponent();

            currentWopFile = null;
            currentPath = "";
        }

        private void UpdateDisplay()
        {
            ewcMain.Enabled = currentWopFile != null;
            ewcMain.SelectedWopFile = currentWopFile;

            UpdateTitle();
            UpdateControls();
        }

        private void UpdateTitle()
        {
            if (currentWopFile == null)
                Text = BaseTitle;
            else
            {
                string path = Path.GetFileName(currentPath);
                if (string.IsNullOrEmpty(path))
                    path = "Untitled Wop";
                string endTitle = "]";
                if (currentWopFile.Dirty)
                    endTitle = "*]";
                Text = BaseTitle + " [" + path + endTitle;
            }
        }

        private void UpdateControls()
        {
            if (currentWopFile == null)
            {
                closeWopToolStripMenuItem.Enabled = false;
                saveAsToolStripMenuItem.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
                tsbSave.Enabled = false;
            }
            else
            {
                closeWopToolStripMenuItem.Enabled = true;
                saveAsToolStripMenuItem.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
                tsbSave.Enabled = true;
            }
        }

        private bool CheckDirty()
        {
            if (currentWopFile != null)
            {
                if (currentWopFile.Dirty)
                {
                    DialogResult result = MessageBox.Show(this,
                        "There are unsaved changes to the current file.\n\nWould you like to save them?",
                        "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        return !Save();
                    } else if (result == DialogResult.No)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void CloseWop()
        {
            if (CheckDirty())
                return;

            currentPath = "";
            currentWopFile = null;
        }

        private void New()
        {
            if (CheckDirty())
                return;

            currentPath = "";
            currentWopFile = new WopFile();
            //currentWopFile.Dirty = true;
        }

        public void Open(string path = "")
        {
            if (CheckDirty())
                return;

            if (!string.IsNullOrEmpty(path))
            {
                DoOpen(path);
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Object Preset Files|*.wop";

            DialogResult result = ofd.ShowDialog(this);
            if (result != DialogResult.Cancel)
            {
                string file = ofd.FileName;
                if (!string.IsNullOrEmpty(file))
                {
                    DoOpen(file);
                }
            }
        }

        private void DoOpen(string path)
        {
            if (!File.Exists(path))
                return;
            try
            {
                currentPath = path;
                currentWopFile = WopFile.Read(path);
            }
            catch
            {
                currentPath = "";
                currentWopFile = null;
            }
        }

        private bool Save()
        {
            if (currentWopFile == null)
                return true;
            if (string.IsNullOrEmpty(currentPath))
            {
                return SaveAs();
            }
            else
            {
                return DoSave(currentPath);
            }
        }

        private bool SaveAs()
        {
            if (currentWopFile == null)
                return true;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Object Preset Files|*.wop";

            DialogResult result = sfd.ShowDialog(this);
            if (result != DialogResult.Cancel)
            {
                string file = sfd.FileName;
                if (!string.IsNullOrEmpty(file))
                {
                    return DoSave(file);
                }
            }
            return false;
        }

        private bool DoSave(string path)
        {
            if (currentWopFile == null)
                return true;

            WopFile newWopFile = ewcMain.GetFinalWopFile();
            newWopFile.Save(path);

            currentPath = path;
            currentWopFile.Dirty = false;
            return true;
        }

        private void Exit()
        {
            Application.Exit();
        }

        private void About()
        {
            AboutDlg aboutDlg = new AboutDlg();
            aboutDlg.ShowDialog(this);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void closeWopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseWop();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CheckDirty())
            {
                e.Cancel = true;
            }
        }
    }
}
