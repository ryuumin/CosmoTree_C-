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

        FormController() { 
        
        }

        static public void createForm(Form newForm, Form oldForm)
        {
            newForm.Show();
            newForm.Location = oldForm.Location;
            oldForm.Visible = false;
        }
    }

    
}
