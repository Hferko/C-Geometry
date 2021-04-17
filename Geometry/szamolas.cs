using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class szamolas
    {
        public double korker(int r)
        {
            double K = (2 * r * Math.PI);
            return K;
        }
        public double korter(int r)
        {
            double T = (r * r * Math.PI);
            return T;
        }
        public int negyker(int a, int b)
        {
            int K = (2 * (a + b));
            return K;
        }
        public int negyter(int a, int b)
        {
            int T = ((a * b));
            return T;
        }
        public double haromker(int a, int b, int c)
        {
            double h = (a + b + c);
            return h;
        }
        public double haromter(int a, int b, int c)
        {
            double h = (a + b + c);
            double s = h / 2;
            double heron = (s * (s - a) * (s - b) * (s - c));
            double T = Math.Sqrt(heron);
            return T;
        }
        public double szog(int a, int b)
        {
            double szog = 1 / (Math.Tan(Math.PI / b));
            double ter = (b * a * a) / 4;
            double alfa = ((b - 2) * (180 / b));
            return alfa;
        }
        public double beirtkor(int a, int b)
        {
            double rb = a / (2 * (Math.Tan(Math.PI / b)));
            return rb;
        }
        public double sokszog(int a, int b)
        {
            double szog = 1 / (Math.Tan(Math.PI / b));
            double ter = (b * a * a) / 4;            
            double rb = a / (2 * (Math.Tan(Math.PI / b)));
            double T = ter * szog;
            return T;
        }
        public double gombfelsz(int r)
        {
            double A = (4*r * r * Math.PI);
            return A;
        }
        public double gombterf(int r)
        {
            double V = (4 *Math.Pow(r,3)* Math.PI)/3;
            return V;
        }
        public double teglafelsz(int a, int b, int c)
        {
            double A = (a*b + a*c + b*c + a*c)*2;
            return A;
        }
        public double teglaterf(int a, int b, int c)
        {
            double V = (a * b * c);            
            return V;
        }
        public int gulaalap(int a, int b)
        {
            int alap = (a * b);
            return alap;
        }
        public double gulafelsz(int a, int b, int c)
        {
            double m = Math.Sqrt(((a / 2) * (a / 2)) + (c * c));
            double t1 = (a * m) / 2;
            double t2 = (b * m) / 2;
            int t = a * b;
            double A = (2 * t1) + (2 * t2) + t;
            return A;
        }
        public double gulaterf(int a, int b, int c)
        {
            double V = (a * b * c)/3;
            return V;
        }
        public double gulaoldal(int a, int b, int c)
        {
            double m = Math.Sqrt(((a / 2) * (a / 2)) + (c * c));
            double O = Math.Sqrt(((a / 2) * (a / 2)) + (m * m));            
            return O;
        }
        public double palast(int r, int a)
        {
            double palast = a*(2 * r * Math.PI);
            return palast;
        }
        public double hengfelsz(double P, double alap)
        {
            double A = P +(2 * alap);
            return A;
        }
        public double hengterf(int r, int a)
        {
            double V = a* (r * r * Math.PI);
            return V;
        }
        public double kuppalast(int r, int a)
        {
            double palast = r * Math.PI*(Math.Sqrt((a * a) + (r * r))); 
            return palast;
        }
        public double kupfelsz(double P, double alap)
        {
            double A = P + alap;
            return A;
        }
        public double hasab(int c, double alap)
        {
            double V = c * alap;
            return V;
        }
    }
}
