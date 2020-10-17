using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CapacitorModel;

namespace CapacitorView
{
    public partial class CapacitorForm : Form
    {
        /// <summary>
        /// Инициализация формы
        /// </summary>
        public CapacitorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие проверки введенного текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            var textbox = sender as TextBox;
            if ((new Regex(@"^(\d*)(?:[,.](\d+))?$")).IsMatch(textbox.Text))
            {
                textbox.ForeColor = Color.Green;
            }
            else
            {
                textbox.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// Установка видимых полей формы в зависимости от типа конденсатора
        /// </summary>
        /// <param name="capacitor">Конденсатор</param>
        private void SetVisible(CapacitorBase capacitor)
        {
            
        }
    }
}
