using EngineersOffice_Library.Models;
using System;
using System.Windows;

namespace EngineersOffice_WpfDesktopClient.Windows
{
    /// <summary>
    /// Логика взаимодействия для EditSteelGradeWindow.xaml
    /// </summary>
    public partial class EditSteelGradeWindow : Window
    {
        public EditSteelGradeWindow(Presenter presenter, SteelGrade steelGrade)
        {
            InitializeComponent();

            tbSteelGrade.Text = steelGrade.Grade;
            tbYeildStress.Text = steelGrade.YieldStress.ToString();
            tbTensileStrength.Text = steelGrade.TensileStrength.ToString();
            tbElongation.Text = steelGrade.Elongation.ToString();
            tbContraction.Text = steelGrade.Contraction.ToString();
            tbHB.Text = steelGrade.HB.ToString();



            btnEdit.Click += delegate {

                steelGrade.Grade = tbSteelGrade.Text;
                steelGrade.YieldStress = Convert.ToInt32(tbYeildStress.Text);
                steelGrade.TensileStrength = Convert.ToInt32(tbTensileStrength.Text);
                steelGrade.Elongation = Convert.ToInt32(tbElongation.Text);
                steelGrade.Contraction = Convert.ToInt32(tbContraction.Text);
                steelGrade.HB = Convert.ToInt32(tbHB.Text);

                presenter.EditSteelGrade(steelGrade.Id, steelGrade);
                MessageBox.Show("Материал изменен", "", MessageBoxButton.OK);

                this.DialogResult = true;
            };
        }
    }
}
