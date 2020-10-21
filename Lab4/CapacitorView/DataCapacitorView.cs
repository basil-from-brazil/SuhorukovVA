using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapacitorModel;

namespace CapacitorView
{
    /// <summary>
    /// Класс для создания таблицы желаемого формата
    /// </summary>
    public static class DataCapacitorView
    {
        /// <summary>
        /// Метод создания таблицы желаемого формата
        /// </summary>
        /// <param name="capacitors">Список конденсаторов</param>
        /// <param name="dataGridView">Таблица с конденсаторами</param>
        public static void CreareTable(BindingList<CapacitorBase> capacitors,
            DataGridView dataGridView)
        {
            dataGridView.DataSource = capacitors;

            dataGridView.Columns[0].HeaderText = "Диэлектрическая проницаемость";
            dataGridView.Columns[1].HeaderText = "Емкость, пкФ";
            dataGridView.Columns[2].HeaderText = "Тип конденсатора";

            dataGridView.AutoSizeColumnsMode =
               DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
