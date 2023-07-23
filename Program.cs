namespace LiskovSubstutionPrincipleDemo
{

    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle()
        {
        }

        public Rectangle( int width, int height)
        {
            Width = width;
            Height = height;
                
        }

        public override string ToString()
        {
            return $"{nameof(Width)} : {Width} and {nameof(Height)} : {Height}";
        }
    }

    public class Square : Rectangle
    {
        public new int Width
        {
            set { base.Width = base.Height =value; }
        }

        public new int Height
        {
            set { base.Height = base.Width = value;}
        }
    }
    internal class Program
    {
        public static int Area(Rectangle r) => r.Width * r.Height;  
        static void Main(string[] args)
        {
            Rectangle rc = new Rectangle(3,4);
            Console.WriteLine($"{rc} Area of rectangel {Area(rc)}");

            Rectangle sq = new Square();
            sq.Width = 4;
            Console.WriteLine($"{sq} Area {Area(sq)}");

        }
    }
}