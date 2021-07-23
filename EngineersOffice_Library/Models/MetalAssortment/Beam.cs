namespace EngineersOffice_Library.Models.MetalAssortment
{
    public class Beam
    {
        public int Id { get; set; }
        //номер госта
        public string Standart { get; set; }

        //номер балки
        public string Number { get; set; }

        //высота профиля
        public float h { get; set; }

        //ширина профиля
        public float b { get; set; }

        //толщина стенки
        public float s { get; set; }

        //толщина полки
        public float t { get; set; }

        //радиус сопряжения стенки и полки
        public float r { get; set; }

        //площадь поперечного сечения
        public float F { get; set; }

        //линейная плотность
        public float lineDensity { get; set; }

        //момент инерции
        public float Ix { get; set; }
        public float Iy { get; set; }

        //момент сопротивления
        public float Wx { get; set; }
        public float Wy { get; set; }

        //статическийц момент инерции
        public float Sx { get; set; }

        //радиус инерци 
        public float i_x { get; set; }
        public float i_y { get; set; }
    }
}
