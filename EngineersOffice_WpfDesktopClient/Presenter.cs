using EngineersOffice_Library.DataApi;
using EngineersOffice_Library.Models;
using EngineersOffice_Library.Models.MetalAssortment;
using EngineersOffice_WpfDesktopClient.Windows;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace EngineersOffice_WpfDesktopClient
{
    public class Presenter
    {
        BeamDataApi contextBeam;
        SteelGradeDataApi contextSteels;
        BendingCoefficientDataApi contextBendingCoeffs;
        public Presenter()
        {
            contextBeam = new BeamDataApi();
            contextSteels = new SteelGradeDataApi();
            contextBendingCoeffs = new BendingCoefficientDataApi();
        }

        #region получить данные из webapi
        //получить список двутавров
        public ObservableCollection<Beam> GetBeams()
        {
            return contextBeam.GetAllBeams().ToObservableCollection<Beam>();
        }

        //получить список сталей
        public ObservableCollection<SteelGrade> GetSteelGrades()
        {
            return contextSteels.GetSteelGrades("").ToObservableCollection<SteelGrade>();
        }

        //получить список изгиб коэффициентов
        public ObservableCollection<BendingCoefficient> GetBendingCoefficients()
        {
            return contextBendingCoeffs.GetAllBendingCoefficients().ToObservableCollection<BendingCoefficient>();
        }


        #endregion


        #region CRUD для кнопок в mainView
        //открыть
        public void OpenAddWindow(string itemType, ref DataGrid data)
        {
            switch (itemType)
            {
                case "Марочник сталей":
                    AddSteelGradeWindow addSteelGrade = new AddSteelGradeWindow(this);
                    addSteelGrade.ShowDialog();

                    if (addSteelGrade.DialogResult.Value)
                    {
                        data.ItemsSource = this.GetSteelGrades();
                    }
                    break;

                case "Двутавры":
                    AddBeamWindow addBeam = new AddBeamWindow(this);
                    addBeam.ShowDialog();

                    if (addBeam.DialogResult.Value)
                    {
                        data.ItemsSource = this.GetBeams();
                    }
                    break;
                case "Коэффициенты изгиба":
                    AddBendingCoefficientWindow addBendingCoefficient = new AddBendingCoefficientWindow(this);
                    addBendingCoefficient.ShowDialog();

                    if (addBendingCoefficient.DialogResult.Value)
                    {
                        data.ItemsSource = this.GetBendingCoefficients();
                    }
                    break;
                default:
                    MessageBox.Show("Для добавления выберите каталог из списка баз данных", "Внимание!", MessageBoxButton.OK);
                    break;
            }
        }

        //изменить
        public void OpenEditWindow(object item, ref DataGrid data)
        {
            if (item != null)
            {
                if (item.GetType().ToString().Contains("SteelGrade"))
                {
                    EditSteelGradeWindow editSteelGrade = new EditSteelGradeWindow(this, item as SteelGrade);
                    editSteelGrade.ShowDialog();

                    if (editSteelGrade.DialogResult.Value)
                    {
                        data.ItemsSource = this.GetSteelGrades();
                    }
                }

                if (item.GetType().ToString().Contains("Beam"))
                {
                    EditBeamWindow editBeam = new EditBeamWindow(this, item as Beam);
                    editBeam.ShowDialog();

                    if (editBeam.DialogResult.Value)
                    {
                        data.ItemsSource = this.GetBeams();
                    }
                }

                if (item.GetType().ToString().Contains("BendingCoefficient"))
                {
                    EditBendingCoefficientWindow editBendingCoefficient = new EditBendingCoefficientWindow(this, item as BendingCoefficient);
                    editBendingCoefficient.ShowDialog();

                    if (editBendingCoefficient.DialogResult.Value)
                    {
                        data.ItemsSource = this.GetBendingCoefficients();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент для изменения", "Внимание!", MessageBoxButton.OK);
            }
        }

        //удалить 
        public void Delete(object item, ref DataGrid data)
        {
            if (item != null)
            {
                if (item.GetType().ToString().Contains("SteelGrade"))
                {
                    DeleteSteelGrade(item as SteelGrade, ref data);
                }
                if (item.GetType().ToString().Contains("Beam"))
                {
                    DeleteBeam(item as Beam, ref data);
                }
                if (item.GetType().ToString().Contains("BendingCoefficient"))
                {
                    DeleteBendingCoefficient(item as BendingCoefficient, ref data);
                }
            }
            else
            {
                MessageBox.Show("Для удаления выберите элемент", "Внимание!", MessageBoxButton.OK);
            }
        }
        #endregion


        #region CRUD методы для каждого типа
        //добавить сталь
        public void AddSteelGrade(SteelGrade steelGrade)
        {
            try
            {
                contextSteels.AddSteelGrade(steelGrade);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //изменить сталь
        public void EditSteelGrade(int id, SteelGrade steelGrade)
        {
            try
            {
                contextSteels.EditSteelGrade(id, steelGrade);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //удалить сталь
        public void DeleteSteelGrade(SteelGrade steelGrade, ref DataGrid data)
        {

            MessageBoxResult result = MessageBox.Show(
                    $"Удалить сталь {steelGrade.Grade}?",
                    "Внимание!",
                    MessageBoxButton.YesNo
                    );

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    contextSteels.DeleteSteelGrade(steelGrade.Id);

                    data.ItemsSource = this.GetSteelGrades();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }



        //добавить двутавр
        public void AddBeam(Beam beam)
        {
            try
            {
                contextBeam.AddBeam(beam);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //изменить двутавр
        public void EditBeam(int id, Beam beam)
        {
            try
            {
                contextBeam.EditBeam(id, beam);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //удалить двутавр
        public void DeleteBeam(Beam beam, ref DataGrid data)
        {
            MessageBoxResult result = MessageBox.Show(
                    $"Удалить сталь {beam.Number}?",
                    "Внимание!",
                    MessageBoxButton.YesNo
                    );

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    contextBeam.DeleteBeam(beam.Id);

                    data.ItemsSource = this.GetBeams();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }



        //добавить изгибающий коэффициент
        public void AddBendingCoefficient(BendingCoefficient bendingCoefficient)
        {
            try
            {
                contextBendingCoeffs.AddBendingCoefficient(bendingCoefficient);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //изменить изгибающий коэффициент
        public void EditBendingCoefficient(int id, BendingCoefficient bendingCoefficient)
        {
            try
            {
                contextBendingCoeffs.EditBendingCoefficient(id, bendingCoefficient);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //удалить изгибающий коэффициент
        public void DeleteBendingCoefficient(BendingCoefficient bendingCoefficient, ref DataGrid data)
        {
            MessageBoxResult result = MessageBox.Show(
                    $"Удалить коэффициент id = {bendingCoefficient.Id}?",
                    "Внимание!",
                    MessageBoxButton.YesNo
                    );

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    contextBendingCoeffs.DeleteBendingCoefficient(bendingCoefficient.Id);

                    data.ItemsSource = this.GetBendingCoefficients();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        #endregion
    }

}
