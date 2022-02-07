﻿using System;

namespace MyHomework_Lesson_1_1
{
    public struct PointStructDouble
    {
        public double X;
        public double Y;
        public static double PointDistance(PointStructDouble pointOne, PointStructDouble pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((float)((x * x) + (y * y)));
        }
    }
}
