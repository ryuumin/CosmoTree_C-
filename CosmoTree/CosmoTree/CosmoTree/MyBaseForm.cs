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
    public partial class MyBaseForm : Form
    {
        protected MyBaseForm parentForm;

        public MyBaseForm()
        {
            InitializeComponent();
        }

        public MyBaseForm(MyBaseForm parent)
        {
            InitializeComponent();
            parentForm = parent;
        }


        //これは各フォームで名前を変えて書かないといけない
        protected void MyBaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //強制終了
            Application.Exit();
        }

       
    }
}
