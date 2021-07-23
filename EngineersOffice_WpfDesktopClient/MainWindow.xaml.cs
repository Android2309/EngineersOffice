using System.Windows;
using System.Windows.Controls;

namespace EngineersOffice_WpfDesktopClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Presenter presenter = new Presenter();

            //treeview вывод
            tvBeams.Selected += delegate { dataGrid.ItemsSource = presenter.GetBeams(); };
            tvSteels.Selected += delegate { dataGrid.ItemsSource = presenter.GetSteelGrades(); };
            tvBendingCoeffs.Selected += delegate { dataGrid.ItemsSource = presenter.GetBendingCoefficients(); };


            //CRUD кнопки
            //добавить
            btnAdd.Click += delegate
            {
                if (treeView.SelectedItem != null)
                {
                    presenter.OpenAddWindow($"{(treeView.SelectedItem as TreeViewItem).Header}", ref dataGrid);
                }
                else
                {
                    MessageBox.Show("Для добавления выберите каталог из списка баз данных", "Внимание!", MessageBoxButton.OK);
                }
            };

            //изменить
            btnEdit.Click += delegate
            {
                presenter.OpenEditWindow(dataGrid.SelectedItem, ref dataGrid);
            };

            //удалить
            btnDelete.Click += delegate {
                presenter.Delete(dataGrid.SelectedItem, ref dataGrid);
            };

            //справка
            menuHelp.Click += delegate
            {
                MessageBox.Show(
                    "Enginneers Office UI - приложение для управления базой данных ДЗ_22 \n " +
                    $"Функции: \n" +
                    $"1. Cоздание, удаление и изменение элементов базы данных (CRUD)\n",
                    "Справка",
                    MessageBoxButton.OK); ;
            };

            //выход
            menuExit.Click += delegate
            {
                MessageBoxResult result = MessageBox.Show(
                   $"Выйти?",
                   "Внимание!",
                   MessageBoxButton.YesNo
                   );

                if (result == MessageBoxResult.Yes)
                {
                    this.Close();
                }
            };
        }
    }
}
