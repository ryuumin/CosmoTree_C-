using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmoTree
{
    class FormController
    {
        public static MyBaseForm topPage;

        FormController()
        {

        }

        //�T�[�o����PHP�t�@�C���̃p�X�ƃp�����[�^��t����URL�������ɂ���
        //�Ԃ�l��PHP������Ȃ̂ŌĂяo�����Ő��䂷��
        static public string sendMySQL(string url)
        {
            WebClient wc = new WebClient();

            //URL�Ƀp�����[�^����������
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
