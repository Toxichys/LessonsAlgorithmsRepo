using System;

namespace MyHomework_Lesson_1_1
{
    public class PointClassDouble
    {
        public double X;
        public double Y;
        public static double PointDistance(PointClassDouble pointOne,PointClassDouble pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((float)((x * x) + (y * y)));
        }
    }
}
