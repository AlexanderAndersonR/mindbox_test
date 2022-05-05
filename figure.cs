namespace mindbox_test
{
    public abstract class figure
    {
        public abstract double square();
    }
    public class circle : figure
    {
        public double radius { get; set; }
        public override double square()
        {
            if (radius>0)
            {
                return 3.14 * radius * radius;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
    public class triangle : figure
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public override double square()
        {
            double p = (a+b+c)/2;
            if (p > 0)
            {
               double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
               return s;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}