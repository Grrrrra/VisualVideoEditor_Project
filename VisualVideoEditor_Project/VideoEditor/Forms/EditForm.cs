using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;
using System.Configuration; // 설정 파일을 다루기 위한 네임스페이스

namespace VisualVideoEditor_Project.VideoEditor.Forms
{
    public partial class EditForm : Form
    {
        private MetroStyleManager styleManager;

        public EditForm()
        {
            InitializeComponent();
            InitializeStyleManager();
        }

        private void InitializeStyleManager()
        {
            styleManager = new MetroStyleManager();
            styleManager.Owner = this; // 스타일 매니저의 소유자를 현재 폼으로 설정
        }
        private void EditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
