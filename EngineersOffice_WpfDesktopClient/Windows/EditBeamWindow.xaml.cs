using EngineersOffice_Library.Models.MetalAssortment;
using System;
using System.Windows;

namespace EngineersOffice_WpfDesktopClient.Windows
{
    /// <summary>
    /// Логика взаимодействия для EditBeamWindow.xaml
    /// </summary>
    public partial class EditBeamWindow : Window
    {
        public EditBeamWindow(Presenter presenter, Beam beam)
        {
            InitializeComponent();


            tbStandart.Text = beam.Standart;
            tbNumber.Text = beam.Number;
            tb_h.Text = beam.h.ToString();
            tb_b.Text = beam.b.ToString();
            tb_s.Text = beam.s.ToString();
            tb_t.Text = beam.t.ToString();
            tb_r.Text = beam.r.ToString();
            tb_F.Text = beam.F.ToString();
            tbLineDensity.Text = beam.lineDensity.ToString();
            tb_Ix.Text = beam.Ix.ToString();
            tb_Iy.Text = beam.Iy.ToString();
            tb_Wx.Text = beam.Wx.ToString();
            tb_Wy.Text = beam.Wy.ToString();
            tb_Sx.Text = beam.Sx.ToString();
            tb_ix.Text = beam.i_x.ToString();
            tb_iy.Text = beam.i_y.ToString();

            btnEdit.Click += delegate
            {
                beam.Standart = tbStandart.Text;
                beam.Number = tbNumber.Text;
                beam.h = Convert.ToSingle(tb_h.Text);
                beam.b = Convert.ToSingle(tb_b.Text);
                beam.s = Convert.ToSingle(tb_s.Text);
                beam.t = Convert.ToSingle(tb_t.Text);
                beam.r = Convert.ToSingle(tb_r.Text);
                beam.F = Convert.ToSingle(tb_F.Text);
                beam.lineDensity = Convert.ToSingle(tbLineDensity.Text);
                beam.Ix = Convert.ToSingle(tb_Ix.Text);
                beam.Iy = Convert.ToSingle(tb_Iy.Text);
                beam.Wx = Convert.ToSingle(tb_Wx.Text);
                beam.Wy = Convert.ToSingle(tb_Wy.Text);
                beam.Sx = Convert.ToSingle(tb_Sx.Text);
                beam.i_x = Convert.ToSingle(tb_ix.Text);
                beam.i_y = Convert.ToSingle(tb_iy.Text);


                presenter.EditBeam(beam.Id, beam);
                MessageBox.Show("Двутавр изменен", "", MessageBoxButton.OK);

                this.DialogResult = true;
            };



        }
    }
}
