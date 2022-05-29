using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Number16
    {
        private string chislo;
        //bool is16 = false;
        //bool is2 = false;
        //bool is10 = false;

        public string Chislo
        {
            get { return chislo; }
        }

        public Number16(string chislo)
        {
            this.chislo = chislo;
            //if (vid == "16") is16 = true;
            //else if (vid == "2") is2 = true;
            //else if (vid == "10") is10 = true;
        }

        public void From16to10()
        {
            int chislo22 = Convert.ToInt32(this.chislo, 16);
            chislo = Convert.ToString(chislo22, 10);
            //is16 = false;
            //is10 = true;
            //  return chislo22;  
        }

        public static Number16 operator +(Number16 A, Number16 B)
        {
            Number16 C;
            int chislo22 = Convert.ToInt32(A.chislo, 16) + Convert.ToInt32(B.chislo, 16);
            C = new Number16(Convert.ToString(chislo22, 16));
            return C;
        }

        public static Number16 operator -(Number16 A, Number16 B)
        {
            Number16 C;
            int chislo = Convert.ToInt32(A.chislo, 16) - Convert.ToInt32(B.chislo, 16);
            C = new Number16(Convert.ToString(chislo, 16));
            return C;
        }

        public static Number16 operator *(Number16 A, Number16 B)
        {
            Number16 C;
            int chislo = Convert.ToInt32(A.chislo, 16) * Convert.ToInt32(B.chislo, 16);
            C = new Number16(Convert.ToString(chislo, 16));
            return C;
        }

        public static Number16 operator /(Number16 A, Number16 B)
        {
            Number16 C;
            int chislo = Convert.ToInt32(A.chislo, 16) / Convert.ToInt32(B.chislo, 16);
            C = new Number16(Convert.ToString(chislo, 16));
            return C;
        }
        //public void From2to16()
        //{
        //    if (is2 == true)
        //    {
        //        string chislo3;
        //        int chislo22 = Convert.ToInt32(this.chislo, 2);
        //        chislo3 = Convert.ToString(chislo22, 16);
        //        this.chislo = chislo3;
        //        is2 = false;
        //        is16 = true;
        //    }
        //    else Console.WriteLine("Проверьте систему счисления числа");
        //}

        public bool IsCorrect16()
        {
            char c;
            for (c = 'G'; c < 'Z'; c++)
            {
                if (chislo.Contains(c) == true) return false;
            }
            return true;
        }

        public static bool operator >(Number16 A, Number16 B)
        {
            int temp1 = Convert.ToInt32(A.chislo, 16);
            int temp2 = Convert.ToInt32(B.chislo, 16);
            return temp1 > temp2;
        }
        public static bool operator >=(Number16 A, Number16 B)
        {
            int temp1 = Convert.ToInt32(A.chislo, 16);
            int temp2 = Convert.ToInt32(B.chislo, 16);
            return temp1 >= temp2;
        }
        public static bool operator <(Number16 A, Number16 B)
        {
            int temp1 = Convert.ToInt32(A.chislo, 16);
            int temp2 = Convert.ToInt32(B.chislo, 16);
            return temp1 < temp2;
        }

        public static bool operator <=(Number16 A, Number16 B)
        {
            int temp1 = Convert.ToInt32(A.chislo, 16);
            int temp2 = Convert.ToInt32(B.chislo, 16);
            return temp1 <= temp2;
        }

        public static bool operator ==(Number16 A, Number16 B)
        {
            int temp1 = Convert.ToInt32(A.chislo, 16);
            int temp2 = Convert.ToInt32(B.chislo, 16);
            return temp1 == temp2;
        }
        public static bool operator !=(Number16 A, Number16 B)
        {
            int temp1 = Convert.ToInt32(A.chislo, 16);
            int temp2 = Convert.ToInt32(B.chislo, 16);
            return temp1 != temp2;
        }

    }
}
