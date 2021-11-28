using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudLibraryTests
{
    public partial class TestUpdateForm : CrudLibrary.UpdateForm
    {
        Test kek;
        public TestUpdateForm(Test temp_object)
        {
            InitializeComponent();
            kek = temp_object;
            SetElements(kek);
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            Object_Update(kek);
            Connection.db.SaveChanges();
        }
    }
}
