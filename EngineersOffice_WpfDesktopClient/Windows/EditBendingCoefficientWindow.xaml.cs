using EngineersOffice_Library.Models;
using System;
using System.Windows;

namespace EngineersOffice_WpfDesktopClient.Windows
{
    /// <summary>
    /// Логика взаимодействия для EditBendingCoefficientWindow.xaml
    /// </summary>
    public partial class EditBendingCoefficientWindow : Window
    {
        public EditBendingCoefficientWindow(Presenter presenter, BendingCoefficient bendingCoefficient)
        {
            InitializeComponent();

            tbFlexibility.Text = bendingCoefficient.Flexibility.ToString();
            tb200.Text = bendingCoefficient.R_200.ToString();
            tb220.Text = bendingCoefficient.R_220.ToString();
            tb240.Text = bendingCoefficient.R_240.ToString();
            tb260.Text = bendingCoefficient.R_260.ToString();
            tb280.Text = bendingCoefficient.R_280.ToString();
            tb300.Text = bendingCoefficient.R_300.ToString();
            tb320.Text = bendingCoefficient.R_320.ToString();
            tb340.Text = bendingCoefficient.R_340.ToString();
            tb360.Text = bendingCoefficient.R_360.ToString();
            tb380.Text = bendingCoefficient.R_380.ToString();
            tb400.Text = bendingCoefficient.R_400.ToString();
            tb440.Text = bendingCoefficient.R_440.ToString();
            tb480.Text = bendingCoefficient.R_480.ToString();
            tb520.Text = bendingCoefficient.R_520.ToString();


            btnEdit.Click += delegate
            {
                bendingCoefficient.Flexibility = Convert.ToInt32(tbFlexibility.Text);
                bendingCoefficient.R_200 = Convert.ToInt32(tb200.Text);
                bendingCoefficient.R_220 = Convert.ToInt32(tb220.Text);
                bendingCoefficient.R_240 = Convert.ToInt32(tb240.Text);
                bendingCoefficient.R_260 = Convert.ToInt32(tb260.Text);
                bendingCoefficient.R_280 = Convert.ToInt32(tb280.Text);
                bendingCoefficient.R_300 = Convert.ToInt32(tb300.Text);
                bendingCoefficient.R_320 = Convert.ToInt32(tb320.Text);
                bendingCoefficient.R_340 = Convert.ToInt32(tb340.Text);
                bendingCoefficient.R_360 = Convert.ToInt32(tb360.Text);
                bendingCoefficient.R_380 = Convert.ToInt32(tb380.Text);
                bendingCoefficient.R_400 = Convert.ToInt32(tb400.Text);
                bendingCoefficient.R_440 = Convert.ToInt32(tb440.Text);
                bendingCoefficient.R_480 = Convert.ToInt32(tb480.Text);
                bendingCoefficient.R_520 = Convert.ToInt32(tb520.Text);


                presenter.EditBendingCoefficient(bendingCoefficient.Id, bendingCoefficient);
                MessageBox.Show("Коэффициент изменен", "", MessageBoxButton.OK);

                this.DialogResult = true;
            };
        }
    }
}
