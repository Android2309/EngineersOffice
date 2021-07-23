using EngineersOffice_Library.Models.MetalAssortment;
using System;
using System.Windows;

namespace EngineersOffice_WpfDesktopClient.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddBeamWindow.xaml
    /// </summary>
    public partial class AddBeamWindow : Window
    {
        public AddBeamWindow(Presenter presenter)
        {
            InitializeComponent();

            Beam addBeam = new Beam();

            tb_h.DataContext = addBeam;
            tb_b.DataContext = addBeam;
            tb_s.DataContext = addBeam;
            tb_t.DataContext = addBeam;
            tb_r.DataContext = addBeam;
            tb_F.DataContext = addBeam;
            tbLineDensity.DataContext = addBeam;
            tb_Ix.DataContext = addBeam;
            tb_Iy.DataContext = addBeam;
            tb_Wx.DataContext = addBeam;
            tb_Wy.DataContext = addBeam;
            tb_Sx.DataContext = addBeam;
            tb_ix.DataContext = addBeam;
            tb_iy.DataContext = addBeam;

            btnAdd.Click += delegate
            {
                try
                {
                    addBeam.Standart = tbStandart.Text;
                    addBeam.Number = tbNumber.Text;
                    addBeam.h = Convert.ToSingle(tb_h.Text);
                    addBeam.b = Convert.ToSingle(tb_b.Text);
                    addBeam.s = Convert.ToSingle(tb_s.Text);
                    addBeam.t = Convert.ToSingle(tb_t.Text);
                    addBeam.r = Convert.ToSingle(tb_r.Text);
                    addBeam.F = Convert.ToSingle(tb_F.Text);
                    addBeam.lineDensity = Convert.ToSingle(tbLineDensity.Text);
                    addBeam.Ix = Convert.ToSingle(tb_Ix.Text);
                    addBeam.Iy = Convert.ToSingle(tb_Iy.Text);
                    addBeam.Wx = Convert.ToSingle(tb_Wx.Text);
                    addBeam.Wy = Convert.ToSingle(tb_Wy.Text);
                    addBeam.Sx = Convert.ToSingle(tb_Sx.Text);
                    addBeam.i_x = Convert.ToSingle(tb_ix.Text);
                    addBeam.i_y = Convert.ToSingle(tb_iy.Text);

                    presenter.AddBeam(addBeam);

                    MessageBox.Show("Новый двутавр добавлен", "", MessageBoxButton.OK);

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
