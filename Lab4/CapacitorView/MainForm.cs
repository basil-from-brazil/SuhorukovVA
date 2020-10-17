using CapacitorModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapacitorView
{
    /// <summary>
    /// Класс, описывающий главную форму
    /// </summary>
    public partial class MainForm : Form
    {
        private BindingList<CapacitorBase> _capacitors = new BindingList<CapacitorBase>();

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            DataCapacitorView.CreareTable(_capacitors, DataCapacitorsView);
        }

        /// <summary>
        /// Событие при добавлении нового конденсатора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCapacitorButton_Click(object sender, EventArgs e)
        {
            var capacitor = new CapacitorForm();

            capacitor.Show();

            //if (capacitor.ShowDialog() == DialogResult.OK)
            //{
            //    _capacitors.Add(capacitor.CapacitorCompleted);
            //}
        }
    }
}
