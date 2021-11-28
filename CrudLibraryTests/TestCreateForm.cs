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
    public partial class TestCreateForm : CrudLibrary.CreateForm
    {
        public TestCreateForm()
        {
            InitializeComponent();
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            Object_Create(new Test());
        }
    }
}
