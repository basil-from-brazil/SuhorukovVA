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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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
            #if !DEBUG
            AddRandomCapacitorButton.Visible = false;
            #endif
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

            if (capacitor.ShowDialog() == DialogResult.OK)
            {
                _capacitors.Add(capacitor.CapacitorCompleted);
            }
        }

        /// <summary>
        /// Событие при удалении конденсатора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteCapacitorButton_Click(object sender, EventArgs e)
        {
            var countOfRows = DataCapacitorsView.SelectedRows.Count;
            for (int i = 0; i < countOfRows; i++)
            {
                _capacitors.RemoveAt(DataCapacitorsView.SelectedRows[0].Index);
            }
        }

        /// <summary>
        /// Событие при генерации случайного конденсатора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRandomCapacitorButton_Click(object sender, EventArgs e)
        {
            _capacitors.Add(RandomCapacitor.GetRandomCapacitor());
        }

        /// <summary>
        /// Событие при сериализации и сохранении файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter= "vas files (*.vas)|*.vas";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var binaryFormatter = new BinaryFormatter();
                    var filePath = saveFileDialog.FileName;

                    using (var fileStream = new FileStream(filePath,
                        FileMode.OpenOrCreate))
                    {
                        binaryFormatter.Serialize(fileStream, _capacitors);
                        MessageBox.Show("Файл был сохранен!");
                    }

                }
            }
        }

        /// <summary>
        /// Событие при загрузке файла и десериализации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadCapacitor_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "vas files (*.vas)|*.vas";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var formatter = new BinaryFormatter();
                    var filePath = openFileDialog.FileName;

                    try
                    {
                        using (var fileStream = new FileStream(filePath,
                        FileMode.OpenOrCreate))
                        {
                            var newCapacitors = (BindingList<CapacitorBase>)formatter.
                                Deserialize(fileStream);

                            foreach (var capacitor in newCapacitors)
                            {
                                _capacitors.Add(capacitor);
                            }
                        }
                    }

                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
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
            var capacitorSearch = new CapacitorSearchForm(_capacitors);
            capacitorSearch.Show();
        }
    }
}
