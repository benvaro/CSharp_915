namespace _18_OverloadOperators
{
    class Fraction
    {
        private int num;
        private int denom;

        public Fraction() : this(0, 1)
        {
        }
        public Fraction(int num, int denom)
        {
            this.num = num;
            this.denom = denom == 0 ? 1 : denom; // 5 / 0 --> 5/1 
            if (denom < 0)
            {
                this.num *= -1;
                this.denom *= -1;
            }
        }

        public int Num
        {
            get => this.num;
            set => this.num = value;
        }

        public int Denom
        {
            get => this.denom;
            set
            {
                this.denom = value == 0 ? 1 : value; // 5 / 0 --> 5/1 

            }
        }

        // Binary
        #region Binary operators
        public static Fraction operator +(Fraction a, Fraction b)
        {
            Fraction res = new Fraction();
            res.Denom = a.Denom * b.Denom;
            res.Num = a.Num * b.Denom + b.Num * a.Denom;

            return res;
        }
        public static Fraction operator +(Fraction a, int b)
        {
            Fraction res = new Fraction();
            res.Denom = a.Denom;
            res.Num = a.Num + b * a.Denom;

            return res;
        }
        public static Fraction operator +(int b, Fraction a)
        {
            return a + b;
        }


        public static Fraction operator -(Fraction a, Fraction b)
        {
            Fraction res = new Fraction();
            res.Denom = a.Denom * b.Denom;
            res.Num = a.Num * b.Denom - b.Num * a.Denom;

            return res;
        }

        public static bool operator <(Fraction a, Fraction b)
        {
            return a.Num * b.Denom < b.Num * a.Denom;
        }
        public static bool operator >(Fraction a, Fraction b)
        {
            return a.Num * b.Denom > b.Num * a.Denom;
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            if (ReferenceEquals(a, b))
                return true;
            if (a == null || b == null)
                return false;
            return a.Equals(b);
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }
        #endregion

        #region Unary operators
        // -- ++ ! - false true explicit/implicit
        public static Fraction operator -(Fraction a)
        {
            return new Fraction(-1 * a.Num, a.Denom);
        }

        public static Fraction operator ++(Fraction a)
        {
            a.Num++;
            a.Denom++;
            return a;
        }

        public static Fraction operator --(Fraction a)
        {
            a.Num--;
            a.Denom--;
            return a;
        }
        // true
        public static bool operator true(Fraction a)
        {
            return a.Num != 0;
        }
        public static bool operator false(Fraction a)
        {
            return a.Num == 0;
        }

        public static implicit operator double(Fraction a) // НЕЯВНЕ перетворення до типу double (тобто без втрати точності)
        {
            return (double)a.Num / a.Denom; // ???
        }
        public static explicit operator int(Fraction a) // ЯВНЕ перетворення до типу int 
        {
            return a.Num / a.Denom; // ???
        }
        //            тип приведення  оператор до якого типу приводимо (з якого типу)  
        public static implicit operator Fraction(double a)
        {
            Fraction res = new Fraction(); //1.93 - 193/100
            res.Num = (int)(a * 100);
            res.Denom = 100;
            return res;
        }
        #endregion

        public override bool Equals(object obj)
        {
            if (obj is Fraction)
            {
                Fraction temp = obj as Fraction;
                if (this.Num / this.Denom == temp.Num / temp.Denom)
                    return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return num ^ denom; // ?   101 ^ 010 = 111  
        }

        public override string ToString()
        {
            return $"{num}/{denom}";
        }
    }
}
