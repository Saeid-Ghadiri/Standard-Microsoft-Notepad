

namespace Standard_Microsoft_Notepad
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public bool Changed { get; set; }
        public string FileName { get; set; }
        public string PathName { get; set; }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            Init();
        }
        private void Init()
        {
            Changed = false;
            FileName = string.Empty;
            PathName = string.Empty;
            Text = "Untitled - Notepad";
            mainTextBox.Text = string.Empty;
        }

        #region Menu File

        #region Menu File - New
        private void newToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (Changed == false)
            {
                Init();
            }
            else
            {
                System.Windows.Forms.DialogResult enmResult =
                    System.Windows.Forms.MessageBox.Show
                    (text: "آیا تمایل به ذخیره تغییرات دارید؟",
                    caption: "سوال",
                    buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
                    icon: System.Windows.Forms.MessageBoxIcon.Question,
                    defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
                    options: System.Windows.Forms.MessageBoxOptions.RightAlign |
                    System.Windows.Forms.MessageBoxOptions.RtlReading);

                if (enmResult == System.Windows.Forms.DialogResult.No)
                {
                    Init();
                }
                else
                {
                    Save();
                }
            }
        }
        #endregion / Menu File - New

        #region Menu File - Open
        private void openToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mainOpenFileDialog.FileName = string.Empty;
            mainOpenFileDialog.InitialDirectory = "C:\\";
            mainOpenFileDialog.Filter = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";

            System.Windows.Forms.DialogResult
                enmResult = mainOpenFileDialog.ShowDialog();

            if (enmResult == System.Windows.Forms.DialogResult.OK)
            {
                PathName =
                    mainOpenFileDialog.FileName;

                FileName =
                    System.IO.Path.GetFileName(PathName);

                Text = FileName;

                System.IO.StreamReader oStream = null;

                try
                {
                    oStream =
                        new System.IO.StreamReader
                        (path: PathName, encoding: System.Text.Encoding.UTF8);

                    mainTextBox.Text = oStream.ReadToEnd();

                    Changed = false;

                    mainTextBox.Focus();
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (oStream != null)
                    {
                        oStream.Close();
                        oStream.Dispose();
                        oStream = null;
                    }
                }
            }
        }
        #endregion /Menu File - Open

        #region Menu File - Save
        private void saveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }
        #endregion /Menu File - / Save

        #region Menu File - Save As
        private void saveAsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }
        #endregion /Menu File - / Save As

        #region Menu File - Page Setup
        private void pageSetupToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }
        #endregion /Menu File - / Page Setup

        #region Menu File - Print
        private void printToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }
        #endregion /Menu File - / Print

        #region Menu File - Exit
        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AppMessageBox msgbox =
                new AppMessageBox();

            msgbox.ApplicationExit();
        }
        #endregion /Menu File - / Exit

        private void mainTextBox_TextChanged(object sender, System.EventArgs e)
        {
            Changed = true;
        }
        private void Save()
        {
            mainSaveFileDialog.FileName = string.Empty;
            mainSaveFileDialog.InitialDirectory = "C:\\";
            mainSaveFileDialog.Filter = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";

            System.Windows.Forms.DialogResult
                enmResult = mainSaveFileDialog.ShowDialog();

            if (enmResult == System.Windows.Forms.DialogResult.OK)
            {
                // TODO: Saving file and changing some properties!
            }
        }

        #endregion / Menu File

        #region Menu Edit

        #region Menu Edit - 
        #endregion /Menu Edit - 

        #endregion /Menu Edit

        #region Menu Format

        #region Menu Format - 
        #endregion /Menu Format - 

        #endregion /Menu Format

        #region Menu View

        #region Menu View - 
        #endregion /Menu View - 

        #endregion /Menu View

        #region Menu Help

        #region Menu Help - About Notepad
        private void aboutNotepadToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //Hide();

            AboutNotepadForm f =
                new AboutNotepadForm();

            f.Show();
        }
        #endregion /Menu Help - / About Notepad

        #endregion /Menu Help


    }
}

