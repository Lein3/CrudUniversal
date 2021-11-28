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
    public partial class TestReadForm : CrudLibrary.ReadForm
    {
        public TestReadForm()
        {
            InitializeComponent();
            var query = from table in Connection.db.Test select table;
            SetDataGrid(query);
            this.dataGridView.ClearSelection();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count < 1) MessageBox.Show("Запись не выбрана");
            else if (MessageBox.Show("Удалить выбранную запись?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var currentObject = Connection.db.Test.Where(a => a.ID == currentID).FirstOrDefault();
                Object_Delete(currentObject);
            }
            
        }
    }
}
