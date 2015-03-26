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

        public Regist(MyBaseForm parent)
        {
            InitializeComponent();
            parentForm = parent;
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
            WebClient wc = new WebClient();

            //URLにパラメータをくっつける
            Stream st = wc.OpenRead("http://ecl.secret.jp/imazumi/CreateUser/CreateUser.php?UserName=dddd&Password=dadfdsfa&age=20");

            Encoding enc = Encoding.GetEncoding("Shift_JIS");
            StreamReader sr = new StreamReader(st, enc);
            string html = sr.ReadToEnd();
            sr.Close();

            st.Close();

            //成功したら１が返ってくる
            if (html == "1") {
                ErrorMessageLabel.Text = "ユーザ登録に成功しました！";
                //ページ遷移処理
                ProfileEdit profile = new ProfileEdit(this);
                FormController.createForm(profile, this);
            }else{
                ErrorMessageLabel.Text = "ユーザ登録に失敗しました・・・";
            }
        }
    }
}
