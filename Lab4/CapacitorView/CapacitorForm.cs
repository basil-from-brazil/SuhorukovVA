using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        /// Поле для создания конденсатора
        /// </summary>
        private CapacitorBase _capacitor;

        /// <summary>
        /// Флаг для внесения данных и закрытия формы
        /// </summary>
        private bool _isCorrect;

        /// <summary>
        /// Свойство для вывода данных о конденсаторе
        /// </summary>
        public CapacitorBase CapacitorCompleted
        {
            get
            {
                return _capacitor;
            }
        }


        /// <summary>
        /// Событие при нажатии на кнопку Плоский конденсатор
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlateCapacitorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _capacitor = new PlateCapacitor();
            SetVisible(_capacitor);
        }

        /// <summary>
        /// Событие при валидации данных TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlateAreaTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                TryConvertingToDouble(PlateAreaTextBox.Text,
                    out double doubleValue);
                if (_capacitor is PlateCapacitor plateCapacitor)
                {
                    plateCapacitor.PlateArea = doubleValue;
                }
                PlateAreaTextBox.BackColor = Color.Green;
            }
            catch (Exception exception)
            {
                if (exception is ArgumentNullException ||
                    exception is ArgumentOutOfRangeException)
                {
                    MessageBox.Show(exception.Message);
                    PlateAreaTextBox.BackColor = Color.Red;
                }
                else if (exception is FormatException)
                {
                    MessageBox.Show("Вы ввели не число! Проверьте, пожалуйста!");
                    PlateAreaTextBox.BackColor = Color.Red;
                }
            }
        }

        /// <summary>
        /// Преобразование string в double, 
        /// и замена точки на запятую в строке
        /// </summary>
        /// <param name="textValue">Преобразуемая строка</param>
        /// <param name="doubleValue">Преобразованная строка к типу double</param>
        /// <returns>Строку, преобразованную к типу double</returns>
        private double TryConvertingToDouble(string textValue, out double doubleValue)
        {
            return doubleValue = double.Parse(textValue.Replace('.', ','));
        }

        /// <summary>
        /// Событие при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CapacitorForm_Load(object sender, EventArgs e)
        {
            _capacitor = new PlateCapacitor();
            PlateCapacitorRadioButton.Checked = true;
            DielectricPermittivityTextBox.TabStop = false;
        }

        /// <summary>
        /// Событие при закрытии формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelCapacitorButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Установка видимых TextBox в зависимости от типа конденсатора
        /// </summary>
        /// <param name="capacitor">Конденсатор</param>
        private void SetVisible(CapacitorBase capacitor)
        {

            PlateAreaTextBox.Visible = false;
            PlateAreaLabel.Visible = false;
            GapBetweenPlatesTextBox.Visible = false;
            GapBetweenPlatesLabel.Visible = false;

            HeightOfCylinderTextBox.Visible = false;
            HeightOfCylinderLabel.Visible = false;
            ExterRadiusTextBox.Visible = false;
            ExterRadiusLabel.Visible = false;
            InterRadiusTextBox.Visible = false;
            InterRadiusLabel.Visible = false;
            switch (capacitor)
            {
                case PlateCapacitor _:
                    {
                        PlateAreaTextBox.Visible = true;
                        PlateAreaLabel.Visible = true;
                        GapBetweenPlatesTextBox.Visible = true;
                        GapBetweenPlatesLabel.Visible = true;
                        break;
                    }
                case CylindricalCapacitor _:
                    {
                        HeightOfCylinderTextBox.Visible = true;
                        HeightOfCylinderLabel.Visible = true;
                        ExterRadiusTextBox.Visible = true;
                        ExterRadiusLabel.Visible = true;
                        InterRadiusTextBox.Visible = true;
                        InterRadiusLabel.Visible = true;
                        break;
                    }
                case SphericalCapacitor _:
                    {
                        ExterRadiusTextBox.Visible = true;
                        ExterRadiusLabel.Visible = true;
                        InterRadiusTextBox.Visible = true;
                        InterRadiusLabel.Visible = true;
                        break;
                    }
                default:
                    {
                        throw new ArgumentException("The type of capacitor is unknown!");
                    }

            }
        }

        /// <summary>
        /// Событие при нажатии на кнопку Цилиндрический конденсатор
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CylindricalCapacitorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _capacitor = new CylindricalCapacitor();
            SetVisible(_capacitor);
        }

        /// <summary>
        /// Событие при нажатии на кнопку Сферический конденсатор
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SphericalCapacitorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _capacitor = new SphericalCapacitor();
            SetVisible(_capacitor);
        }

        private void GapBetweenPlatesTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                TryConvertingToDouble(GapBetweenPlatesTextBox.Text,
                    out double doubleValue);
                if (_capacitor is PlateCapacitor plateCapacitor)
                {
                    plateCapacitor.GapBetweenPlates = doubleValue;
                }
                GapBetweenPlatesTextBox.BackColor = Color.Green;
            }
            catch (Exception exception)
            {
                if (exception is ArgumentNullException ||
                    exception is ArgumentOutOfRangeException)
                {
                    MessageBox.Show(exception.Message);
                    GapBetweenPlatesTextBox.BackColor = Color.Red;
                }
                else if (exception is FormatException)
                {
                    MessageBox.Show("Вы ввели не число! Проверьте, пожалуйста!");
                    GapBetweenPlatesTextBox.BackColor = Color.Red;
                }
            }

        }

        private void HeightOfCylinderTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                TryConvertingToDouble(HeightOfCylinderTextBox.Text,
                    out double doubleValue);
                if (_capacitor is CylindricalCapacitor cylindricalCapacitor)
                {
                    cylindricalCapacitor.HeightOfCylinder = doubleValue;
                }
                HeightOfCylinderTextBox.BackColor = Color.Green;
            }
            catch (Exception exception)
            {
                if (exception is ArgumentNullException ||
                    exception is ArgumentOutOfRangeException)
                {
                    MessageBox.Show(exception.Message);
                    HeightOfCylinderTextBox.BackColor = Color.Red;
                }
                else if (exception is FormatException)
                {
                    MessageBox.Show("Вы ввели не число! Проверьте, пожалуйста!");
                    HeightOfCylinderTextBox.BackColor = Color.Red;
                }
            }
        }

        private void ExterRadiusTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                TryConvertingToDouble(ExterRadiusTextBox.Text,
                    out double doubleValue);
                if (_capacitor is CylindricalCapacitor cylindricalCapacitor)
                {
                    cylindricalCapacitor.ExterRadiusOfCylinder = doubleValue;
                }
                else if (_capacitor is SphericalCapacitor sphericalCapacitor)
                {
                    sphericalCapacitor.ExterRadiusOfSphere = doubleValue;
                }
                ExterRadiusTextBox.BackColor = Color.Green;
            }
            catch (Exception exception)
            {
                if (exception is ArgumentNullException ||
                    exception is ArgumentOutOfRangeException)
                {
                    MessageBox.Show(exception.Message);
                    ExterRadiusTextBox.BackColor = Color.Red;
                }
                else if (exception is FormatException)
                {
                    MessageBox.Show("Вы ввели не число! Проверьте, пожалуйста!");
                    ExterRadiusTextBox.BackColor = Color.Red;
                }
            }
        }

        private void InterRadiusTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                TryConvertingToDouble(InterRadiusTextBox.Text,
                    out double doubleValue);
                if (_capacitor is CylindricalCapacitor cylindricalCapacitor)
                {
                    cylindricalCapacitor.InterRadiusOfCylinder = doubleValue;
                }
                else if (_capacitor is SphericalCapacitor sphericalCapacitor)
                {
                    sphericalCapacitor.InterRadiusOfSphere = doubleValue;
                }
                InterRadiusTextBox.BackColor = Color.Green;
            }
            catch (Exception exception)
            {
                if (exception is ArgumentNullException ||
                    exception is ArgumentOutOfRangeException)
                {
                    MessageBox.Show(exception.Message);
                    InterRadiusTextBox.BackColor = Color.Red;
                }
                else if (exception is FormatException)
                {
                    MessageBox.Show("Вы ввели не число! Проверьте, пожалуйста!");
                    InterRadiusTextBox.BackColor = Color.Red;
                }
            }
        }

        private void DielectricPermittivityTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                TryConvertingToDouble(DielectricPermittivityTextBox.Text,
                    out double doubleValue);
                _capacitor.DielectricPermittivity = doubleValue;
                DielectricPermittivityTextBox.BackColor = Color.Green;
            }
            catch (Exception exception)
            {
                if (exception is ArgumentNullException ||
                    exception is ArgumentOutOfRangeException)
                {
                    MessageBox.Show(exception.Message);
                    DielectricPermittivityTextBox.BackColor = Color.Red;
                }
                else if (exception is FormatException)
                {
                    MessageBox.Show("Вы ввели не число! Проверьте, пожалуйста!");
                    DielectricPermittivityTextBox.BackColor = Color.Red;
                }
            }
        }

        /// <summary>
        /// Установить значение свойствам экземпляра класса 
        /// Плоский/Цилиндрический/Сферический конденсатор
        /// </summary>
        /// <param name="action">Делегат Action</param>
        private void SetValue(Action action)
        {
            try
            {
                action.Invoke();
                return;
            }
            catch (Exception exception)
            {
                _isCorrect = false;
                if (exception is ArgumentException)
                {
                    MessageBox.Show(exception.Message);
                }
                else if (exception is FormatException)
                {
                    MessageBox.Show("Вы ввели не число! Проверьте, пожалуйста!");
                }
            }
        }

        /// <summary>
        /// Ввод данных о плоском конденсаторе
        /// </summary>
        /// <returns>Созданный экземпляр класса Плоский конденсатор</returns>
        private PlateCapacitor GetNewPlateCapacitor()
        {
            var newPlateCapacitor = new PlateCapacitor();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    TryConvertingToDouble(PlateAreaTextBox.Text,
                        out double doubleValue);
                    newPlateCapacitor.PlateArea = doubleValue;
                }),
                new Action(() =>
                {
                    TryConvertingToDouble(GapBetweenPlatesTextBox.Text,
                        out double doubleValue);
                    newPlateCapacitor.GapBetweenPlates = doubleValue;
                }),
                new Action(() =>
                {
                    TryConvertingToDouble(DielectricPermittivityTextBox.Text,
                        out double doubleValue);
                    newPlateCapacitor.DielectricPermittivity = doubleValue;
                })
            };
            actions.ForEach(SetValue);
            return newPlateCapacitor;
        }

        /// <summary>
        /// Ввод данных о цилиндрическом конденсаторе
        /// </summary>
        /// <returns>Созданный экземпляр класса 
        /// Цилиндрический конденсатор</returns>
        private CylindricalCapacitor GetNewCylindricalCapacitor()
        {
            var newCylindricalCapacitor = new CylindricalCapacitor();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    TryConvertingToDouble(HeightOfCylinderTextBox.Text,
                        out double doubleValue);
                    newCylindricalCapacitor.HeightOfCylinder = doubleValue;
                }),
                new Action(() =>
                {
                    TryConvertingToDouble(ExterRadiusTextBox.Text,
                        out double doubleValue);
                    newCylindricalCapacitor.ExterRadiusOfCylinder = doubleValue;
                }),
                new Action(() =>
                {
                    TryConvertingToDouble(InterRadiusTextBox.Text,
                        out double doubleValue);
                    newCylindricalCapacitor.InterRadiusOfCylinder = doubleValue;
                }),
                new Action(() =>
                {
                    TryConvertingToDouble(DielectricPermittivityTextBox.Text,
                        out double doubleValue);
                    newCylindricalCapacitor.DielectricPermittivity = doubleValue;

                })
            };
            actions.ForEach(SetValue);
            return newCylindricalCapacitor;
        }

        /// <summary>
        /// Ввод данных о сферическом конденсаторе
        /// </summary>
        /// <returns>Созданный экземпляр класса 
        /// Сферический конденсатор</returns>
        private SphericalCapacitor GetNewSphericalCapacitor()
        {
            var newShericalCapacitor = new SphericalCapacitor();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    TryConvertingToDouble(ExterRadiusTextBox.Text,
                        out double doubleValue);
                    newShericalCapacitor.ExterRadiusOfSphere = doubleValue;
                }),
                new Action(() =>
                {
                    TryConvertingToDouble(InterRadiusTextBox.Text,
                        out double doubleValue);
                    newShericalCapacitor.InterRadiusOfSphere = doubleValue;
                }),
                new Action(() =>
                {
                    TryConvertingToDouble(DielectricPermittivityTextBox.Text,
                        out double doubleValue);
                    newShericalCapacitor.DielectricPermittivity = doubleValue;
                })
            };
            actions.ForEach(SetValue);
            return newShericalCapacitor;
        }

        /// <summary>
        /// Ввод данных о конденсаторах
        /// </summary>
        private void InsertData()
        {
            _isCorrect = true;
            switch (_capacitor)
            {
                case PlateCapacitor _:
                    {
                        _capacitor = GetNewPlateCapacitor();
                        break;
                    }
                case CylindricalCapacitor _:
                    {
                        _capacitor = GetNewCylindricalCapacitor();
                        break;
                    }
                case SphericalCapacitor _:
                    {
                        _capacitor = GetNewSphericalCapacitor();
                        break;
                    }
                default:
                    {
                        throw new ArgumentException("The type of capacitor is unknown!");
                    }
            }
        }

        /// <summary>
        /// Событие при добавлении нового конденсатора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKCapacitorButton_Click(object sender, EventArgs e)
        {
            InsertData();

            if (_isCorrect)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
