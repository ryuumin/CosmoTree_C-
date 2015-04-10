using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmoTree
{
    public partial class ProfileEdit : MyBaseForm
    {
        public ProfileEdit()
        {
            InitializeComponent();
        }
   
        private void DisssionButton_Click(object sender, EventArgs e)
        {
            UpdateProfile();
            FormController.age = Agelabel.Text;
            //ページ遷移処理
            MyPage myPage = new MyPage();
            FormController.createForm(myPage, this);
        }

        private void UpdateProfile()
        {
            String url = "http://ecl.secret.jp/imazumi/C/EditProfile.php?UserName="+FormController.userName+"&Age="+AgeTextBox.Text;

            string html = ServerController.sendMySQL(url);

        }
    }
}
