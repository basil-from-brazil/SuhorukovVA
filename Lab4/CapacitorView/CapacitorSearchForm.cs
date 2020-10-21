using CapacitorModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapacitorView
{
    /// <summary>
    /// Класс, описывающий форму для поиска конденсаторов
    /// </summary>
    public partial class CapacitorSearchForm : Form
    {

        /// <summary>
        /// Список конденсаторов из MainForm
        /// </summary>
        private BindingList<CapacitorBase> _capacitors;

        /// <summary>
        /// Список с найденными конденсаторами
        /// </summary>
        private BindingList<CapacitorBase> _capacitorsSearch = 
            new BindingList<CapacitorBase>();

        /// <summary>
        /// Событие при инициализации формы
        /// </summary>
        public CapacitorSearchForm(BindingList<CapacitorBase> capacitors)
        {
            InitializeComponent();

            _capacitors = capacitors;
        }

        /// <summary>
        /// Событие при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CapacitorSearchForm_Load(object sender, EventArgs e)
        {
            DataCapacitorView.CreareTable(_capacitorsSearch, DataSearchCapacitorsView);
            DielectricPermittivityRadioButton.Checked = true;
        }

        /// <summary>
        /// Событие про поиске по емкости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CapacityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _capacitorsSearch.Clear();
        }

        /// <summary>
        /// Событие при поиске по типу конденсатра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CapacitorTypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _capacitorsSearch.Clear();
        }

        /// <summary>
        /// Событие при закрытии формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseCapacitorSearchButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Поиск конденсаторов
        /// </summary>
        private void Search(bool isCapacitorTypeSearch = false)
        {
            _capacitorsSearch.Clear();

            try
            {
                foreach(var row in _capacitors)
                {
                    var isDielectricPermittivitySearch =
                        DielectricPermittivityRadioButton.Checked &&
                        row.DielectricPermittivity == 
                        double.Parse(SearchParameterTextBox.Text.Replace(',','.'), 
                        CultureInfo.InvariantCulture);

                    var isCapacitySearch = CapacityRadioButton.Checked &&
                        row.Capacity ==
                        double.Parse(SearchParameterTextBox.Text.Replace(',', '.'), 
                        CultureInfo.InvariantCulture);

                    if (!string.IsNullOrEmpty(SearchParameterTextBox.Text))
                    {
                        isCapacitorTypeSearch = CapacitorTypeRadioButton.Checked &&
                        row.CapacitorType == (char.ToUpper(SearchParameterTextBox.Text[0])
                        + SearchParameterTextBox.Text.Substring(1)).ToString();
                    }
                    else
                    {
                        throw new ArgumentNullException();
                    }
                    if (isDielectricPermittivitySearch || isCapacitySearch || isCapacitorTypeSearch)
                    {
                        _capacitorsSearch.Add(row);
                    }
                }
                if (!_capacitorsSearch.Any())
                {
                    MessageBox.Show("Конденсаторов не найдено!");
                }
            }
            catch (Exception exception)
            {
                if (exception is FormatException)
                {
                    MessageBox.Show("Вы ввели не число! Проверьте, пожалуйста!");
                }
                else if (exception is ArgumentNullException)
                {
                    MessageBox.Show("Введенная строка является пустой или null! " +
                        "Проверьте, пожалуйста!");
                }
            }
        }

        /// <summary>
        /// Событие при поиске конденсатора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchCapacitorButton_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
