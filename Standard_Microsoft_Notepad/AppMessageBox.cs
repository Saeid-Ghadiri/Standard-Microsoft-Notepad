using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Microsoft_Notepad
{
     public class AppMessageBox : System.Object
    {
        public AppMessageBox() : base()
        {
        }

        #region Application Exit
        public void ApplicationExit()
        {
            //************************************************************************
            System.Windows.Forms.DialogResult enmResult =
                System.Windows.Forms.MessageBox.Show
                (text: "آیا به خروج از برنامه اطمینان دارید؟",
                caption: "سوال",
                buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
                icon: System.Windows.Forms.MessageBoxIcon.Question,
                defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
                options: System.Windows.Forms.MessageBoxOptions.RightAlign |
                System.Windows.Forms.MessageBoxOptions.RtlReading);

            if (enmResult == System.Windows.Forms.DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            //************************************************************************
        }

        #endregion / Application Exit
    }
}
