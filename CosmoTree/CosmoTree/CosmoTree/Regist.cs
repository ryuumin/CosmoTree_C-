using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.IO;

namespace CosmoTree
{
    public partial class Regist : MyBaseForm
    {
    //    Form parentForm;

        public Regist()
        {
            InitializeComponent();
        }
        /*
        private void Regist_FormClosed(object sender, FormClosedEventArgs e)
        {
            //親クラスもClose
            if (parentForm != null) parentForm.Close();
        }
        */
        private void RegistButton_Click(object sender, EventArgs e)
        {
            //ユーザ名やパスが空白ならエラーメッセージを返す
            if (UserNameTextBox.Text == "") 
            {
                ErrorMessageLabel.Text = "ユーザ名を入力してください";
                return;
            }
            if (PasswordTextBox.Text == "")
            {
                ErrorMessageLabel.Text = "パスワードを入力してください";
                return;
            }
            

            //サーバと通信
            CreateUser();
        }

        private void CreateUser() 
        {
            String url = "http://ecl.secret.jp/imazumi/C/CreateUser.php?UserName=" + UserNameTextBox.Text + "&Password=" + PasswordTextBox.Text + "&age=20";

            string html = ServerController.sendMySQL(url);

            //成功したら0が返ってくる
            if (html == "0") {
                ErrorMessageLabel.Text = "ユーザ登録に成功しました！";
                FormController.userName = UserNameTextBox.Text;
                //ページ遷移処理
                ProfileEdit profile = new ProfileEdit();
                FormController.createForm(profile, this);
            }else{
                ErrorMessageLabel.Text = "ユーザ登録に失敗しました・・・" + html;
            }
        }
    }
}
