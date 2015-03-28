using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.IO;

namespace CosmoTree
{
    class ServerController
    {
        public static MyBaseForm topPage;

        ServerController()
        {

        }

        //サーバ側のPHPファイルのパスとパラメータを付けたURLを引数にする
        //返り値はPHP文次第なので呼び出し元で制御する
        static public string sendMySQL(string url)
        {
            WebClient wc = new WebClient();

            //URLにパラメータをくっつける
            Stream st = wc.OpenRead(url);

            Encoding enc = Encoding.GetEncoding("Shift_JIS");
            StreamReader sr = new StreamReader(st, enc);
            string php_return = sr.ReadToEnd();
            sr.Close();
            st.Close();

            return php_return;
        }
    }


}
