using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Berechnung
{
    class Berechnung
    {
        private const double o = 300;
        private const double u = 400;
        private const double kp = 300;
        private const double hb = 100;

        public double S3(double x, double y, double z)
        {

            double alphaMotor = 0;
            double up = 0;
            double d = 200;
            double alpha = 0;
            double beta = 0;
            double gamma = 0;
            double epsilon = 0;
            double zeta = 0;
            double delta = 0;
            double c3 = 0;
            double yx = 0;

            if (y > 0)
            {
                alpha = Math.Asin((y * Math.Sin(120 * (Math.PI / 180))) / u);
                beta = 60 * (Math.PI / 180) - alpha;
                up = (y * Math.Sin(beta)) / Math.Sin(alpha);
            }
            else if (y < 0)
            {
                y -= 2 * y;
                alpha = Math.Asin((y * Math.Sin(60 * (Math.PI / 180))) / u);
                beta = 120 * (Math.PI / 180) - alpha;
                up = (y * Math.Sin(beta)) / Math.Sin(alpha);
            }
            else
            {
                up = u;
            }

            if (x > 0)
            {
                yx = (x * Math.Sin(30 * (Math.PI / 180))) / Math.Sin(60 * (Math.PI / 180));
                d -= x / Math.Sin(60 * (Math.PI / 180));

                alpha = Math.Asin((yx * Math.Sin(120 * (Math.PI / 180))) / up);
                beta = 60 * (Math.PI / 180) - alpha;
                up = (yx * Math.Sin(beta)) / Math.Sin(alpha);
            }
            else if (x < 0)
            {
                x -= 2 * x;
                yx = (x * Math.Sin(30 * (Math.PI / 180))) / Math.Sin(60 * (Math.PI / 180));
                d += x / Math.Sin(60 * (Math.PI / 180));

                gamma = Math.Asin((yx * Math.Sin(60 * (Math.PI / 180))) / up);
                delta = 120 * (Math.PI / 180) - gamma;
                up = (yx * Math.Sin(delta)) / Math.Sin(gamma);
            }

            c3 = Math.Sqrt(Math.Pow(d, 2) + Math.Pow(z, 2));

            if ((c3 == o + up) && (d > 0))
            {
                alphaMotor = Math.Asin(z / c3);
            }
            else if ((c3 == o + up) && (d < 0))
            {
                alphaMotor = 180 * (Math.PI / 180) - Math.Asin(z / c3);
            }
            else if ((c3 == o + up) && (d == 0))
            {
                alphaMotor = 90 * (Math.PI / 180);
            }

            if ((c3 != o + up) && (d > 0))
            {
                epsilon = Math.Acos((Math.Pow(o, 2) + Math.Pow(c3, 2) - Math.Pow(up, 2)) / (2 * o * c3));
                zeta = Math.Sin(z / c3);

                alphaMotor = epsilon + zeta;
            }
            else if ((c3 != o + up) && (d < 0))
            {
                epsilon = Math.Acos((Math.Pow(o, 2) + Math.Pow(c3, 2) - Math.Pow(up, 2)) / (2 * o * c3));
                zeta = Math.Sin(z / c3);
                alphaMotor = 180 * (Math.PI / 180) - zeta + epsilon;
            }

            return alphaMotor * (180 / Math.PI);
        }
        public double S2(double x, double y, double z)
        {

            double alphaMotor = 0;
            double up = 0;
            double d = 200;
            double alpha = 0;
            double beta = 0;
            double gamma = 0;
            double epsilon = 0;
            double zeta = 0;
            double delta = 0;
            double c3 = 0;
            double yx = 0;

            if (y > 0)
            {
                alpha = Math.Asin((y * Math.Sin(120 * (Math.PI / 180))) / u);
                beta = 60 * (Math.PI / 180) - alpha;
                up = (y * Math.Sin(beta)) / Math.Sin(alpha);
            }
            else if (y < 0)
            {
                y -= 2 * y;
                alpha = Math.Asin((y * Math.Sin(60 * (Math.PI / 180))) / u);
                beta = 120 * (Math.PI / 180) - alpha;
                up = (y * Math.Sin(beta)) / Math.Sin(alpha);
            }
            else
            {
                up = u;
            }

            if (x < 0)
            {
                x -= 2 * x;
                yx = (x * Math.Sin(30 * (Math.PI / 180))) / Math.Sin(60 * (Math.PI / 180));
                d -= x / Math.Sin(60 * (Math.PI / 180));

                alpha = Math.Asin((yx * Math.Sin(120 * (Math.PI / 180))) / up);
                beta = 60 * (Math.PI / 180) - alpha;
                up = (yx * Math.Sin(beta)) / Math.Sin(alpha);
            }
            else if (x > 0)
            {
                yx = (x * Math.Sin(30 * (Math.PI / 180))) / Math.Sin(60 * (Math.PI / 180));
                d += x / Math.Sin(60 * (Math.PI / 180));

                gamma = Math.Asin((yx * Math.Sin(60 * (Math.PI / 180))) / up);
                delta = 120 * (Math.PI / 180) - gamma;
                up = (yx * Math.Sin(delta)) / Math.Sin(gamma);
            }

            c3 = Math.Sqrt(Math.Pow(d, 2) + Math.Pow(z, 2));

            if ((c3 == o + up) && (d > 0))
            {
                alphaMotor = Math.Asin(z / c3);
            }
            else if ((c3 == o + up) && (d < 0))
            {
                alphaMotor = 180 * (Math.PI / 180) - Math.Asin(z / c3);
            }
            else if ((c3 == o + up) && (d == 0))
            {
                alphaMotor = 90 * (Math.PI / 180);
            }

            if ((c3 != o + up) && (d > 0))
            {
                epsilon = Math.Acos((Math.Pow(o, 2) + Math.Pow(c3, 2) - Math.Pow(up, 2)) / (2 * o * c3));
                zeta = Math.Sin(z / c3);

                alphaMotor = epsilon + zeta;
            }
            else if ((c3 != o + up) && (d < 0))
            {
                epsilon = Math.Acos((Math.Pow(o, 2) + Math.Pow(c3, 2) - Math.Pow(up, 2)) / (2 * o * c3));
                zeta = Math.Sin(z / c3);
                alphaMotor = 180 * (Math.PI / 180) - zeta + epsilon;
            }

            return alphaMotor * (180 / Math.PI);
        }
        public double S1(double x, double y, double z)
        {
            double up = 0;
            double d = 200;
            double alphaMotor = 0;
            double epsilon = 0;
            double zeta = 0;
            double alpha = 0;
            double beta = 0;
            double c3 = 0;

            if (x < 0)
            {
                x -= 2 * x;
            }
            alpha = Math.Asin(x / u);
            beta = 90 * (Math.PI / 180) - alpha;
            up = u * Math.Sin(beta);
            d -= y;
            c3 = Math.Sqrt(Math.Pow(d, 2) + Math.Pow(z, 2));

            if ((c3 == o + up) && (d > 0))
            {
                alphaMotor = Math.Asin(z / c3);
            }
            else if ((c3 == o + up) && (d < 0))
            {
                alphaMotor = 180 * (Math.PI / 180) - Math.Asin(z / c3);
            }
            else if ((c3 == o + up) && (d == 0))
            {
                alphaMotor = 90 * (Math.PI / 180);
            }

            if ((c3 != o + up) && (d > 0))
            {
                epsilon = Math.Acos((Math.Pow(o, 2) + Math.Pow(c3, 2) - Math.Pow(up, 2)) / (2 * o * c3));
                zeta = Math.Sin(z / c3);

                alphaMotor = epsilon + zeta;
            }
            else if ((c3 != o + up) && (d < 0))
            {
                epsilon = Math.Acos((Math.Pow(o, 2) + Math.Pow(c3, 2) - Math.Pow(up, 2)) / (2 * o * c3));
                zeta = Math.Sin(z / c3);
                alphaMotor = 180 * (Math.PI / 180) - zeta + epsilon;
            }
            //Console.WriteLine("up " + up + " d " + d + " c3 " + c3 + " o " + o + " u " + u + " alpha " + alpha + " beta " + beta + " epsilon " + epsilon + " zeta " + zeta);
            return alphaMotor * (180 / Math.PI);
        }
    }
}

