﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_MyPoint_Class
{
    public class MyPoint
    {
        private int X, Y;

        public MyPoint()
        {
            this.X = 0;
            this.Y = 0;
        }
        public MyPoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int getX()
        {
             return this.X;
        }
        public void setX(int x)
        {
            this.X = x;
        }
        public int getY()
        {
            return this.Y;
        }
        public void setY(int y)
        {
            this.Y = y;
        }
        public int[] getXY()
        {
            int[] xy = new int[2];
            xy[0] = this.X;
            xy[1] = this.Y;
            return xy;
        }
        public void setXY(int x, int y)
        {
            this.X = x;
            this.Y = y;          
        }
        public override string ToString()
        {
            return String.Format("({0},{1})", this.X, this.Y);
        }
        public double Distance(int x, int y)
        {
            int deltaX = this.X - x;
            int deltaY = this.Y - y;
            return Math.Sqrt(((deltaX)*(deltaX))+((deltaY)*(deltaY)));
        }
        public double Distance(MyPoint point)
        {
            return Distance(point.X, point.Y);
        }
        public double Distance()
        {
            return Distance(0, 0);
        }
    }
}
