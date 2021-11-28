using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudLibrary
{
    public partial class ReadForm : Form
    {
        protected int currentID;
        protected int currentPage = 0;
        private List<Page> pages;
        private IQueryable<dynamic> currentQuery;

        public ReadForm()
        {
            InitializeComponent();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
        }

        public void SetDataGrid(IQueryable<dynamic> query)
        {
            currentQuery = query;
            SetPages(query.ToList().Count());
            this.comboBox_page.SelectedIndex = currentPage;
            this.dataGridView.DataSource = pages[currentPage].DisplayPage(query);
            this.dataGridView.ClearSelection();
            this.label_info.Text = "Всего записей: " + query.ToList().Count().ToString();
        }

        private void SetPages(int databaseSize)
        {
            pages = new List<Page>();
            for (int i = 0; i < databaseSize / Page.pageCount; i++)
                pages.Add(new Page(i, Page.pageCount));
            if (databaseSize % Page.pageCount != 0)
                pages.Add(new Page(pages.Count, databaseSize % Page.pageCount));
            this.comboBox_page.Items.Clear();
            foreach (var item in pages)
                this.comboBox_page.Items.Add(item.PageNumber + 1);
        }

        public void button_previousPage_Click(object sender, EventArgs e)
        {
            if (currentPage == 0)
                return;
            else
            {
                currentPage--;
                this.dataGridView.DataSource = pages[currentPage].DisplayPage(currentQuery);
            }
        }

        public void button_nextPage_Click(object sender, EventArgs e)
        {
            if (currentPage == pages.Count - 1)
                return;
            else
            {
                currentPage++;
                this.dataGridView.DataSource = pages[currentPage].DisplayPage(currentQuery);
            }
        }

        public void comboBox_page_SelectionChangeCommitted(object sender, EventArgs e)
        {
            currentPage = Convert.ToInt32(this.comboBox_page.SelectedIndex);
            this.dataGridView.DataSource = pages[currentPage].DisplayPage(currentQuery);
        }

        public void Object_Delete(dynamic currentObject)
        {           
            var currentClass = currentObject.GetType();
            var currentClassTable = InnerConnection.db.Set(currentClass);
            currentClassTable.Attach(currentObject);
            currentClassTable.Remove(currentObject);
            InnerConnection.db.SaveChanges();
            MessageBox.Show("Запись удалена");
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
