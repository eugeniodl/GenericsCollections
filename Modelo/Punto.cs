namespace Modelo
{
    public class Punto
    {
        private int _x;
        private int _y;

        public Punto(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return String.Format($"X={_x}, Y={_y}");
        }
    }
}