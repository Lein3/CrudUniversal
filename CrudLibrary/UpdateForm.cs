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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        public void SetElements(object currentObject, bool autoincrement = true)
        {
            dynamic properties;
            if (autoincrement)
                properties = currentObject.GetType().GetProperties().Where(a => !a.GetMethod.IsVirtual && a.Name != "ID");
            else
                properties = currentObject.GetType().GetProperties().Where(a => !a.GetMethod.IsVirtual);
            //установили текущие сущности и классы и таблицы и все это гавно

            List<object> currentValues = new List<object>();
            foreach (var property in properties)
                currentValues.Add(property.GetValue(currentObject));
            currentValues.Reverse();
            //взяли данные из объекта

            int i = 0;
            foreach (var control in panel_main.Controls)
                switch (control.GetType().Name)
                {
                    case "CustomField_bool":
                        var currentElement1 = (CheckBox)control;
                        if (Convert.ToBoolean(currentValues[i++]) == true)
                            currentElement1.Checked = true;
                        else
                            currentElement1.Checked = false;
                        break;

                    case "CustomField_combobox":
                        var currentElement2 = (ComboBox)control;
                        currentElement2.SelectedValue = Convert.ToInt32(currentValues[i++]);
                        break;

                    case "CustomField_date":
                        var currentElement3 = (DateTimePicker)control;
                        currentElement3.Value = Convert.ToDateTime(currentValues[i++]);
                        break;

                    case "CustomField_double":
                        var currentElement4 = (NumericUpDown)control;
                        currentElement4.Value = Convert.ToDecimal(currentValues[i++]);
                        break;

                    case "CustomField_int":
                        var currentElement5 = (NumericUpDown)control;
                        currentElement5.Value = Convert.ToInt32(currentValues[i++]);
                        break;

                    case "CustomField_string":
                        var currentElement6 = (TextBox)control;
                        currentElement6.Text = Convert.ToString(currentValues[i++]);
                        break;

                    default:
                        break;
                }
            //вставили данные
        }

        public void Object_Update_v(object currentObject, bool autoincrement = true)
        {
            var currentClass = currentObject.GetType();
            var currentClassTable = InnerConnection.db.Set(currentClass);
            currentClassTable.Attach(currentObject);
            dynamic properties;
            if (autoincrement)
                properties = currentObject.GetType().GetProperties().Where(a => !a.GetMethod.IsVirtual && a.Name != "ID");
            else
                properties = currentObject.GetType().GetProperties().Where(a => !a.GetMethod.IsVirtual);

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
            //перезаписали

            if (MessageBox.Show("Обновить запись с введенными данными?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {               
                InnerConnection.db.SaveChanges();
                MessageBox.Show("Запись обновлена");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            //сохранили
        }

        public dynamic Object_Update_f(object currentObject, bool autoincrement = true)
        {
            dynamic properties;
            if (autoincrement)
                properties = currentObject.GetType().GetProperties().Where(a => !a.GetMethod.IsVirtual && a.Name != "ID");
            else
                properties = currentObject.GetType().GetProperties().Where(a => !a.GetMethod.IsVirtual);

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
            //перезаписали

            return currentObject;
            //вернули
        }
    }
}
