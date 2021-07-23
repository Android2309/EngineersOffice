using EngineersOffice_Library.Models;
using System;
using System.Windows;

namespace EngineersOffice_WpfDesktopClient.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddBendingCoefficientWindow.xaml
    /// </summary>
    public partial class AddBendingCoefficientWindow : Window
    {
        public AddBendingCoefficientWindow(Presenter presenter)
        {
            InitializeComponent();
            BendingCoefficient addItem = new BendingCoefficient();

            tbFlexibility.DataContext = addItem;
            tb200.DataContext = addItem;
            tb220.DataContext = addItem;
            tb240.DataContext = addItem;
            tb260.DataContext = addItem;
            tb280.DataContext = addItem;
            tb300.DataContext = addItem;
            tb320.DataContext = addItem;
            tb340.DataContext = addItem;
            tb360.DataContext = addItem;
            tb380.DataContext = addItem;
            tb400.DataContext = addItem;
            tb440.DataContext = addItem;
            tb480.DataContext = addItem;
            tb520.DataContext = addItem;

            btnAdd.Click += delegate {

                try
                {
                    addItem.Flexibility = Convert.ToInt32(tbFlexibility.Text);
                    addItem.R_200 = Convert.ToInt32(tb200.Text);
                    addItem.R_220 = Convert.ToInt32(tb220.Text);
                    addItem.R_240 = Convert.ToInt32(tb240.Text);
                    addItem.R_260 = Convert.ToInt32(tb260.Text);
                    addItem.R_280 = Convert.ToInt32(tb280.Text);
                    addItem.R_300 = Convert.ToInt32(tb300.Text);
                    addItem.R_320 = Convert.ToInt32(tb320.Text);
                    addItem.R_340 = Convert.ToInt32(tb340.Text);
                    addItem.R_360 = Convert.ToInt32(tb360.Text);
                    addItem.R_380 = Convert.ToInt32(tb380.Text);
                    addItem.R_400 = Convert.ToInt32(tb400.Text);
                    addItem.R_440 = Convert.ToInt32(tb440.Text);
                    addItem.R_480 = Convert.ToInt32(tb480.Text);
                    addItem.R_520 = Convert.ToInt32(tb520.Text);

                    presenter.AddBendingCoefficient(addItem);
                    MessageBox.Show("Новый коэффициент добавлен", "", MessageBoxButton.OK);

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
