using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudLibrary
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        public void Object_Create_v(object currentObject, bool autoincrement = true)
        {
            var currentClass = currentObject.GetType();
            var currentClassTable = InnerConnection.db.Set(currentClass);
            dynamic properties;
            if (autoincrement)
                properties = currentObject.GetType().GetProperties().Where(a => !a.GetMethod.IsVirtual && a.Name != "ID");
            else
                properties = currentObject.GetType().GetProperties().Where(a => !a.GetMethod.IsVirtual);
            //установили текущие сущности и классы и таблицы и все это гавно

            List<object> currentValues = new List<object>();
            foreach (var control in panel_main.Controls)
                switch (control.GetType().Name)
                {
                    case "CustomField_bool":
                        var currentElement1 = (CheckBox)control;
                        if (currentElement1.Checked == true)
                            currentValues.Add(true);
                        else
                            currentValues.Add(false);
                        break;

                    case "CustomField_combobox":
                        var currentElement2 = (ComboBox)control;
                        currentValues.Add(currentElement2.SelectedValue);
                        break;

                    case "CustomField_date":
                        var currentElement3 = (DateTimePicker)control;
                        currentValues.Add(currentElement3.Value);
                        break;

                    case "CustomField_double":
                        var currentElement4 = (NumericUpDown)control;
                        currentValues.Add(Convert.ToDouble(currentElement4.Value));
                        break;

                    case "CustomField_int":
                        var currentElement5 = (NumericUpDown)control;
                        currentValues.Add(Convert.ToInt32(currentElement5.Value));
                        break;

                    case "CustomField_string":
                        var currentElement6 = (TextBox)control;
                        if (currentElement6.Text != "")
                            currentValues.Add(currentElement6.Text);
                        else
                            currentValues.Add(null);
                        break;                   

                    default:
                        break;
                }
            currentValues.Reverse();
            //взяли с панели данные

            int i = 0;
            foreach (var property in properties)
                property.SetValue(currentObject, currentValues[i++]);
            //установили свойства класса

            if (MessageBox.Show("Добавить запись с введенными данными?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                currentClassTable.Add(currentObject);
                InnerConnection.db.SaveChanges();
                MessageBox.Show("Запись добавлена");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            //сохранили
        }

        public dynamic Object_Create_f(object currentObject, bool autoincrement = true)
        {
            var currentClass = currentObject.GetType();
            var currentClassTable = InnerConnection.db.Set(currentClass);
            dynamic properties;
            if (autoincrement)
                properties = currentObject.GetType().GetProperties().Where(a => !a.GetMethod.IsVirtual && a.Name != "ID");
            else
                properties = currentObject.GetType().GetProperties().Where(a => !a.GetMethod.IsVirtual);
            //установили текущие сущности и классы и таблицы и все это гавно

            List<object> currentValues = new List<object>();
            foreach (var control in panel_main.Controls)
                switch (control.GetType().Name)
                {
                    case "CustomField_bool":
                        var currentElement1 = (CheckBox)control;
                        if (currentElement1.Checked == true)
                            currentValues.Add(true);
                        else
                            currentValues.Add(false);
                        break;

                    case "CustomField_combobox":
                        var currentElement2 = (ComboBox)control;
                        currentValues.Add(currentElement2.SelectedValue);
                        break;

                    case "CustomField_date":
                        var currentElement3 = (DateTimePicker)control;
                        currentValues.Add(currentElement3.Value);
                        break;

                    case "CustomField_double":
                        var currentElement4 = (NumericUpDown)control;
                        currentValues.Add(Convert.ToDouble(currentElement4.Value));
                        break;

                    case "CustomField_int":
                        var currentElement5 = (NumericUpDown)control;
                        currentValues.Add(Convert.ToInt32(currentElement5.Value));
                        break;

                    case "CustomField_string":
                        var currentElement6 = (TextBox)control;
                        if (currentElement6.Text != "")
                            currentValues.Add(currentElement6.Text);
                        else
                            currentValues.Add(null);
                        break;

                    default:
                        break;
                }
            currentValues.Reverse();
            //взяли с панели данные

            int i = 0;
            foreach (var property in properties)
                property.SetValue(currentObject, currentValues[i++]);
            //установили свойства класса

            return currentObject;
            //вернули
        }
    }
}
