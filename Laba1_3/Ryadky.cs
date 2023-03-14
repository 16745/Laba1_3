namespace Laba1_3
{
    internal class Ryadky
    {
        public string ryadok = "";

        private bool result = true;
        //Конструктор
        public Ryadky()
        {

        }
        //Перевірка(Видає true якщо цифрові символи)
        public bool check()
        {

            for (int i = 0; i < ryadok.Length; i++)
            {
                if ((ryadok[i] >= '0' && ryadok[i] <= '9'))
                {
                    result = false;
                }
                else
                {
                    return true;
                }
            }
            if (result == false)
            {
                return false;
            }
            else return true;

        }
        //Метод обчислення довжини
        public int length()
        {
            return ryadok.Length;
        }
        //Метод обернення рядка
        public void invert()
        {
            string ryadokTmp = "";
            for (int i = ryadok.Length - 1; i >= 0; i--)
            {
                ryadokTmp += ryadok[i];
            }
            ryadok = ryadokTmp;
        }
        //Метод додавання символу в рядок
        public void add(string c)
        {
            if (c[0] >= '0' && c[0] <= '9' && c.Length == 1)
            {
                ryadok += c;
            }
        }
        //Метод зміни рядка
        public void change(string ryadokTmp)
        {
            ryadok = ryadokTmp;
        }



        //String* int
        public static Ryadky operator *(Ryadky r1, int i)
        {
            return new Ryadky { ryadok = r1.ryadok + i };
        }
        //int * String
        public static Ryadky operator *(int i, Ryadky r1)
        {
            return new Ryadky { ryadok = i + r1.ryadok };
        }
        //String+String
        public static Ryadky operator +(Ryadky r1, Ryadky r2)
        {
            return new Ryadky { ryadok = r1.ryadok + r2.ryadok };
        }
        //String==String
        public static bool operator ==(Ryadky r1, Ryadky r2)
        {
            return r1.ryadok == r2.ryadok;
        }
        public static bool operator !=(Ryadky r1, Ryadky r2)
        {
            return r1.ryadok != r2.ryadok;
        }
        //String--
        public static Ryadky operator --(Ryadky r1)
        {
            r1.ryadok = r1.ryadok.Substring(0, r1.ryadok.Length - 1);
            return new Ryadky
            {
                ryadok = r1.ryadok
            };
        }
        public static bool operator true(Ryadky r1)
        {
            return r1.ryadok != "";
        }
        public static bool operator false(Ryadky r1)
        {
            return r1.ryadok == "";
        }



        //деструктор
        ~Ryadky()
        {

        }
    }
}
