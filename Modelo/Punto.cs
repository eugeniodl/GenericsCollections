namespace Modelo
{
    public class Punto
    {
        private int x;
        private int y;

        public Punto(int px, int py)
        {
            x = px;
            y = py;
        }

        public override string ToString()
        {
            return string.Format($"X={x}, Y={y}");
        }
    }
}