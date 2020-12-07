using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Matr_Lab
{
    public class Matr_lab<T>
    {

        T[,] Matr1;
        public int n;
        public Matr_lab(int n)
        {
            if (n <= 0)
            {
                Exception ex = new ArgumentException("Отрицательной рамерноси быть не может");
                throw ex;
            }
            if ((typeof(T) != typeof(int)) && (typeof(T) != typeof(double)) && (typeof(T) != typeof(float)))
            {
                Exception ex = new ArgumentException("Тип не может быть таковым");
                throw ex;
            }
            this.n = n;
            Matr1 = new T[n, n];
        }
        public T this[int index1, int index2]
        {
            get
            {
                return Matr1[index1, index2];
            }

            set
            {
                Matr1[index1, index2] = value;
            }
        }
        static T Add<U>(U x, U y)
        {
            dynamic dx = x, dy = y;
            return dx + dy;
        }
        static T Mult<U>(U x, U y, U z)
        {
            dynamic dx = x, dy = y, dz = z;
            return dx * dy + dz;
        }
        public static Matr_lab<T> operator +(Matr_lab<T> obj1, Matr_lab<T> obj2)
        {
            int n1 = obj1.n;
            int n2 = obj2.n;
            if (n1 != n2)
            {
                Exception ex = new ArgumentException("Не совпадение размерностей матриц!");
                throw ex;
            }
            Matr_lab<T> c = new Matr_lab<T>(n1);
            for (int i = 0; i < n1; i++)
                for (int j = 0; j < n1; j++)
                {
                    c[i, j] = Add<T>(obj1[i, j], obj2[i, j]);
                }
            return c;
        }
        public static Matr_lab<T> operator *(Matr_lab<T> obj1, Matr_lab<T> obj2)
        {
            int n1 = obj1.n;
            int n2 = obj2.n;
            if (n1 != n2)
            {
                Exception ex = new ArgumentException("Не совпадение размерностей матриц!");
                throw ex;
            }
            Matr_lab<T> c = new Matr_lab<T>(n1);
            for (int i = 0; i < n1; i++)
                for (int j = 0; j < n1; j++)
                    for (int k = 0; k < n1; k++) 
                    {
                        c[i,j] = Mult<T>(obj1[i, k], obj2[k, j], c[i, j]);
                    }
            return c;
        }
        public void Rand (Func<int,int,T> f)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    Matr1[i, j] = f(i, j);
        }

    }
}
