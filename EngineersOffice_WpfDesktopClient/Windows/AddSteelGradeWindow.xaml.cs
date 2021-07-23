using EngineersOffice_Library.Models;
using System;
using System.Windows;

namespace EngineersOffice_WpfDesktopClient.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddSteelGradeWindow.xaml
    /// </summary>
    public partial class AddSteelGradeWindow : Window
    {
        public AddSteelGradeWindow(Presenter presenter)
        {
            InitializeComponent();

            SteelGrade addItem = new SteelGrade();
            tbSteelGrade.DataContext = addItem;
            tbYieldStress.DataContext = addItem;
            tbTensileStrength.DataContext = addItem;
            tbElongation.DataContext = addItem;
            tbContraction.DataContext = addItem;
            tbHB.DataContext = addItem;

            btnAdd.Click += delegate {

                try
                {
                    addItem.Grade = tbSteelGrade.Text;
                    addItem.YieldStress = Convert.ToInt32(tbYieldStress.Text);
                    addItem.TensileStrength = Convert.ToInt32(tbTensileStrength.Text);
                    addItem.Elongation = Convert.ToInt32(tbElongation.Text);
                    addItem.Contraction = Convert.ToInt32(tbContraction.Text);
                    addItem.HB = Convert.ToInt32(tbHB.Text);

                    presenter.AddSteelGrade(addItem);
                    MessageBox.Show("Новый материал добавлен", "", MessageBoxButton.OK);

                    this.DialogResult = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }



            };
        }
    }
}
