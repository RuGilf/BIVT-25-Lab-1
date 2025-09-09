namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            if (a > 0 & b > 0 & c > 0)
            {
                return true;
            }
            if (a < 0 & b < 0 & c < 0)
            {
                return true;
            }
            if (a == 0 & b == 0 & c == 0)
            {
                return true;
            }
            return false;
        }
        public bool Task2(int a, int b)
        {
            if (a != 0)
            {
                if (b % a == 0)
                {
                    return true;
                }
            }
            if (b != 0)
            {
                if (a % b == 0)
                {
                    return true;
                }
            }
            return false;
        }
        public bool Task3(int a, int b)
        {
            if (a != 0 & b != 0)
            {
                if (a * a == b || a * a * a == b || b * b == a || b * b * b == a)
                {
                    return true;
                }
            }

            return false;
        }
        public double Task4(double d, double f, double g)
        {
            return (f * f - 4 * d * g);
        }
        public double Task5(double x)
        {
            if (x <= (-1))
            {
                return 1;
            }
            if (x > 1)
            {
                return (-1);
            }
            else
            {
                return (-1) * x;
            }
        }
        public bool Task6(double squareS, double circleS)
        {
            if (Math.Sqrt(squareS) * Math.Sqrt(2) <= Math.Sqrt(circleS / Math.PI) * 2)
            {
                return true;
            }

            return false;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            if (s == true)
            {
                if (t == true)
                {
                    answer = 6;
                }
                else
                {
                    if (f == true)
                    {
                        answer = 10;
                    }
                    else
                    {
                        answer = 2;
                    }
                }
            }
            else
            {
                if (t == true)
                {
                    answer = 3;
                }
                else
                {
                    if (f == true)
                    {
                        answer = 5;
                    }
                    else
                    {
                        answer = 1;
                    }
                }
            }
            return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            const int bank = 10000;
            double avrors = pupils / 7;
            avrors = Math.Ceiling(avrors);

            double sellery = bank - 5 * pupils;

            if (5 * pupils < bank)
            {
                if (sellery > 0)
                {
                    if (year % 4 == 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}

