using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace setul_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1();
            //ex2();
            //ex3();
            //ex4();
            //ex5();
            //ex6();
            //ex7();
            //ex8();
            //ex9();
            //ex10(); 
            //ex11();
            //ex12();
            //ex13();
            //ex14();
            //ex15();
            //ex16();
            //ex18();
            //ex19();
            //ex20();
            //ex21();
            //ex22();
            //ex23();
            //ex24();
            //ex25();
            //ex27();
            //ex28();
            //ex29();
        }

        private static void ex29()
        {
            Console.Write("Introduceti dimensiunea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            MergeSort(vector, 0, vector.Length - 1);

            Console.WriteLine("Vectorul sortat este: ");
            foreach (int val in vector)
                Console.Write(val + " ");
        }

        static void MergeSort(int[] vector, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                MergeSort(vector, left, mid);
                MergeSort(vector, mid + 1, right);

                Merge(vector, left, mid, right);
            }
        }

        static void Merge(int[] vector, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] Left = new int[n1];
            int[] Right = new int[n2];

            for (int z = 0; z < n1; ++z)
                Left[z] = vector[left + z];
            for (int t = 0; t < n2; ++t)
                Right[t] = vector[mid + 1 + t];

            int i = 0, j = 0;

            int k = left;
            while (i < n1 && j < n2)
            {
                if (Left[i] <= Right[j])
                {
                    vector[k] = Left[i];
                    i++;
                }
                else
                {
                    vector[k] = Right[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                vector[k] = Left[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                vector[k] = Right[j];
                j++;
                k++;
            }
        }


        private static void ex28()
        {
            Console.Write("Introduceti dimensiunea vectorului: ");
            int n=int.Parse(Console.ReadLine());
            int[] vector= new int[n]; 

            for(int i=0;i<n;i++)
            {
                Console.Write($"Elementul {i+1}: ");
                vector[i]= int.Parse(Console.ReadLine());
            }

            QuickSort(vector, 0, vector.Length - 1);

            Console.WriteLine("Vectorul sortat este: ");
            foreach (int val in vector)
                Console.Write(val + " ");
        }

        static void QuickSort(int[] vector, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(vector, low, high);

                QuickSort(vector, low, pi - 1);
                QuickSort(vector, pi + 1, high);
            }
        }

        static int Partition(int[] vector, int low, int high)
        {
            int pivot = vector[high];
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if (vector[j] < pivot)
                {
                    i++;
                    Swap(ref vector[i], ref vector[j]);
                }
            }
            Swap(ref vector[i + 1], ref vector[high]);
            return (i + 1);
        }

        static void Swap(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }

        private static void ex27()
        {
            Console.Write("Introduceti dimensiunea vectorului: ");
            int n= int.Parse(Console.ReadLine());

            int[] v= new int[n];

            for(int i=0;i<n;i++)
            {
                Console.Write($"Elementul {i+1}: ");
                v[i]=int.Parse(Console.ReadLine());
            }

            Console.Write($"Introduceti un index intre 0 si {n}: ");
            int poz= int.Parse(Console.ReadLine()) ;

            Array.Sort(v);
            Console.Write("Vectorul sortat: ");

            foreach(int element in v)
                Console.Write(element+ " ");

            Console.WriteLine($"Valoarea de la indexul {poz} după sortare este: {v[poz]}");
        }

        private static void ex25()
        {
            List<int> v1 = CitesteVector("v1");
            List<int> v3 = CitesteVector("v3");

            List<int> v = Interclasare(v1, v3);

            Console.WriteLine("Vectorul interclasat: " + string.Join(", ", v));
        }
        static List<int> Interclasare(List<int> v1, List<int> v2)
        {
            List<int> v = new List<int>();
            int i = 0, j = 0;

            while (i < v1.Count && j < v2.Count)
            {
                if (v1[i] <= v2[j])
                {
                    v.Add(v1[i]);
                    i++;
                }
                else
                {
                    v.Add(v2[j]);
                    j++;
                }
            }

            while (i < v1.Count)
            {
                v.Add(v1[i]);
                i++;
            }

            while (j < v2.Count)
            {
                v.Add(v2[j]);
                j++;
            }

            return v;
        }

        private static void ex24()
        {
            List<int> v1 = CitesteVector("v1");
            List<int> v2 = CitesteVector("v2");

            Console.WriteLine("Intersectia: " + string.Join(", ", Intersectia3(v1, v2)));
            Console.WriteLine("Reuniunea: " + string.Join(", ", Reuniunea3(v1, v2)));
            Console.WriteLine("Diferenta v1 - v2: " + string.Join(", ", Diferenta3(v1, v2)));
            Console.WriteLine("Diferenta v2 - v1: " + string.Join(", ", Diferenta3(v2, v1)));
        }
        static List<int> Intersectia3(List<int> v1, List<int> v2)
        {
            List<int> intersectie = new List<int>();

            for (int i = 0; i < v1.Count; i++)
            {
                if (v1[i] == 1 && v2[i] == 1)
                {
                    intersectie.Add(i);
                }
            }

            return intersectie;
        }

        static List<int> Reuniunea3(List<int> v1, List<int> v2)
        {
            List<int> reuniune = new List<int>();

            for (int i = 0; i < v1.Count; i++)
            {
                if (v1[i] == 1 || v2[i] == 1)
                {
                    reuniune.Add(i);
                }
            }

            return reuniune;
        }

        static List<int> Diferenta3(List<int> v1, List<int> v2)
        {
            List<int> diferenta = new List<int>();

            for (int i = 0; i < v1.Count; i++)
            {
                if (v1[i] == 1 && v2[i] == 0)
                {
                    diferenta.Add(i);
                }
            }

            return diferenta;
        }

        private static void ex23()
        {
            List<int> v1 = CitesteVector("v1");
            List<int> v2 = CitesteVector("v2");

            Console.WriteLine("Intersectia: " + string.Join(", ", Intersectia2(v1, v2)));
            Console.WriteLine("Reuniunea: " + string.Join(", ", Reuniunea2(v1, v2)));
            Console.WriteLine("Diferenta v1 - v2: " + string.Join(", ", Diferenta2(v1, v2)));
            Console.WriteLine("Diferenta v2 - v1: " + string.Join(", ", Diferenta2(v2, v1)));
        }
        static List<int> Intersectia2(List<int> v1, List<int> v2)
        {
            List<int> intersectie = new List<int>();
            int i = 0, j = 0;

            while (i < v1.Count && j < v2.Count)
            {
                if (v1[i] < v2[j])
                    i++;
                else if (v2[j] < v1[i])
                    j++;
                else
                {
                    intersectie.Add(v1[i]);
                    i++;
                    j++;
                }
            }

            return intersectie;
        }

        static List<int> Reuniunea2(List<int> v1, List<int> v2)
        {
            List<int> reuniune = new List<int>();
            int i = 0, j = 0;

            while (i < v1.Count && j < v2.Count)
            {
                if (v1[i] < v2[j])
                {
                    reuniune.Add(v1[i]);
                    i++;
                }
                else if (v2[j] < v1[i])
                {
                    reuniune.Add(v2[j]);
                    j++;
                }
                else
                {
                    reuniune.Add(v1[i]);
                    i++;
                    j++;
                }
            }

            while (i < v1.Count)
            {
                reuniune.Add(v1[i]);
                i++;
            }

            while (j < v2.Count)
            {
                reuniune.Add(v2[j]);
                j++;
            }

            return reuniune;
        }

        static List<int> Diferenta2(List<int> v1, List<int> v2)
        {
            List<int> diferenta = new List<int>();
            int i = 0, j = 0;

            while (i < v1.Count && j < v2.Count)
            {
                if (v1[i] < v2[j])
                {
                    diferenta.Add(v1[i]);
                    i++;
                }
                else if (v2[j] < v1[i])
                    j++;
                else
                {
                    i++;
                    j++;
                }
            }

            while (i < v1.Count)
            {
                diferenta.Add(v1[i]);
                i++;
            }

            return diferenta;
        }

        private static void ex22()
        {
            List<int> v1 = CitesteVector("v1");
            List<int> v2 = CitesteVector("v2");

            Console.WriteLine("Intersectia: " + string.Join(", ", Intersectia(v1, v2)));
            Console.WriteLine("Reuniunea: " + string.Join(", ", Reuniunea(v1, v2)));
            Console.WriteLine("Diferenta v1 - v2: " + string.Join(", ", Diferenta(v1, v2)));
            Console.WriteLine("Diferenta v2 - v1: " + string.Join(", ", Diferenta(v2, v1)));
        }
        static List<int> CitesteVector(string nume)
        {
            Console.WriteLine($"Introduceti numarul de elemente pentru vectorul {nume}:");
            int n = int.Parse(Console.ReadLine());

            List<int> v = new List<int>(n);
            Console.WriteLine($"Introduceti elementele vectorului {nume}, cu enter dupa fiecare valoare:");
            for (int i = 0; i < n; i++)
                v.Add(int.Parse(Console.ReadLine()));

            return v;
        }
        static List<int> Intersectia(List<int> v1, List<int> v2)
        {
            List<int> intersectia = new List<int>();

            foreach (int element in v1)
            {
                if (v2.Contains(element) && !intersectia.Contains(element))
                    intersectia.Add(element);
            }

            return intersectia;
        }

        static List<int> Reuniunea(List<int> v1, List<int> v2)
        {
            List<int> reuniunea = new List<int>(v1);

            foreach (int element in v2)
            {
                if (!reuniunea.Contains(element))
                    reuniunea.Add(element);
            }

            return reuniunea;
        }

        static List<int> Diferenta(List<int> v1, List<int> v2)
        {
            List<int> diferenta = new List<int>();

            foreach (int element in v1)
            {
                if (!v2.Contains(element))
                    diferenta.Add(element);
            }

            return diferenta;
        }

        private static void ex21()
        {
            Console.WriteLine("Introduceti numarul de elemente pentru primul vector:");
            int n1 = int.Parse(Console.ReadLine());

            List<int> v1 = new List<int>(n1);
            Console.WriteLine("Introduceti elementele primului vector, cu enter dupa fiecare:");
            for (int i = 0; i < n1; i++)
            {
                v1.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Introduceti numarul de elemente pentru al doilea vector:");
            int n2 = int.Parse(Console.ReadLine());

            List<int> v2 = new List<int>(n2);
            Console.WriteLine("Introduceti elementele celui de-al doilea vector, cu enter dupa fiecare:");
            for (int i = 0; i < n2; i++)
            {
                v2.Add(int.Parse(Console.ReadLine()));
            }

            int rezultat = ComparaVectori(v1, v2);

            if (rezultat < 0)
                Console.WriteLine("Primul vector ar trebui sa apara primul in dictionar ");
            else if (rezultat > 0)
                Console.WriteLine("Al doilea vector ar trebui sa apara primul in dictionar ");
            else
                Console.WriteLine("Vectorii sunt egali ");
        }
        static int ComparaVectori(List<int> v1, List<int> v2)
        {
            int n = Math.Min(v1.Count, v2.Count);

            for (int i = 0; i < n; i++)
            {
                if (v1[i] < v2[i])
                    return -1;
                if (v1[i] > v2[i])
                    return 1;
            }

            if (v1.Count < v2.Count)
                return -1;
            if (v1.Count > v2.Count)
                return 1;

            return 0;
        }


        private static void ex19()
        {
            Console.Write("Introducet lungimea vectorului in care vreti sa cautati: ");
            int n=int.Parse(Console.ReadLine());
            int[] s= new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                s[i]= int.Parse(Console.ReadLine());
            }

            Console.Write("Introduceti lungimea vectorului pe care doriti sa il cautati: ");
            int m= int.Parse(Console.ReadLine());
            int[] p = new int[m];

            for(int i = 0;i < m;i++)
            {
                Console.Write($"Elementul {i+1}: ");
                p[i]= int.Parse(Console.ReadLine());
            }

            int aparitii = 0;

            // Parcurgerea vectorului s
            for (int i = 0; i <= s.Length - p.Length; i++)
            {
                // Extragerea unei subsecvente din s de lungimea lui p
                int[] subsecventa = new int[p.Length];
                Array.Copy(s, i, subsecventa, 0, p.Length);

                // Compararea subsecventei cu p
                if (subsecventa.SequenceEqual(p))
                {
                    aparitii++;
                }
                Console.WriteLine($"Vectorul p apare in s de {aparitii} ori ");
            }
        }

        private static void ex18()
        {
            Console.Write("Introduceti gradul polinomului: ");
            int n = int.Parse(Console.ReadLine());
            double[] coeficienti = new double[n+1];

            Console.Write("Introduceti valoarea in care vreti sa calculati polinomul: ");
            double x = double.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.Write($"Introduceti coeficientul pentru x^{i}: ");
                coeficienti[i] = double.Parse(Console.ReadLine());
            }

            double rez = 0;
            for (int i = 0; i < coeficienti.Length; i++)
            {
                rez += coeficienti[i] * Math.Pow(x, i);
            }

            Console.WriteLine($"Valoarea polinomului in punctul {x} este: {rez}");
        }

        private static void ex16()
        {
            Console.Write("Introduceti dimensiunea vectoruui: ");
            int n= int.Parse(Console.ReadLine());
            int[] a = new int[n];

            for(int i=0;i<n;i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                a[i]= int.Parse(Console.ReadLine());
            }

            int cmmdc = a[0];
            for (int i = 1; i < a.Length; i++)
                cmmdc = Cmmdc(cmmdc, a[i]);
            
            Console.WriteLine($"Cel mai mare divizor comun al elementelor vectorului este {cmmdc} ");
        }

        static int Cmmdc(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
  

        private static void ex15()
        {
           Console.Write("Introduceti dimensiunea vectorului: ");
           int n= int.Parse(Console.ReadLine());
           int[] vector = new int[n];

           for(int i=0;i<n;i++)
           {
               Console.Write($"Introduceti elementul {i+1}: ");
               vector[i]= int.Parse(Console.ReadLine());
           }

           for (int i = 0; i < vector.Length; i++)
           {
               for (int j = i + 1; j < vector.Length; j++)
               {
                   // Daca se gaseste un duplicat, se inlocuieste cu ultimul element
                   if (vector[i] == vector[j])
                   {
                       vector[j] = vector[vector.Length - 1];
                       Array.Resize(ref vector, vector.Length - 1);
                       j--; // Se revine la elementul curent pentru a verifica daca nu cumva este duplicat
                   }
               }
           }
           foreach (int i in vector)
               Console.Write(i + " ");
            
        }

        private static void ex14()
        {
            Console.WriteLine("Introduceti numarul de elemente din vector:");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine($"Introduceți cele {n} elemente: ");

            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            MoveZerosToEnd(arr, n);
            Console.WriteLine("Vectorul dupa mutarea tuturor zerourilor la sfarsitul vectorului:");
            PrintArray14(arr, n);

        }
        static void MoveZerosToEnd(int[] arr, int n)
        {
            int cont = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] != 0)
                {
                    arr[cont++] = arr[i];
                }
            }

            while (cont < n)
                arr[cont++] = 0;
        }
        static void PrintArray14(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }

        private static void ex13()
        {
            Console.Write("Introduceti numarul de elemente din array: ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            Console.WriteLine($"Introduceti cele {n} numere");

            for (int i = 0; i < n; i++)
               a[i] = int.Parse(Console.ReadLine());
            
            InsertionSort(a);
            Console.WriteLine("Array-ul sortat: ");
            PrintArray(a);
        }
        static void InsertionSort(int[] a)
        {
            int n = a.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = a[i];
                int j = i - 1;

                while (j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j = j - 1;
                }
                a[j + 1] = key;
            }
        }

        private static void ex12()
        {
            Console.Write("Introduceti numarul de elemente din array: ");
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];
            Console.WriteLine($"Introduceti cele {n} numere");

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            SelectionSort(v);
            Console.WriteLine("Array-ul sortat:");
            PrintArray(v);
        }
        static void SelectionSort(int[] v)
        {
            int n = v.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (v[j] < v[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int aux = v[minIndex];
                v[minIndex] = v[i];
                v[i] = aux;
            }
        }

        static void PrintArray(int[] v)
        {
            int n = v.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine();
        }

        private static void ex11()
        {
            Console.Write("Introduceti n: ");
            int n = int.Parse(Console.ReadLine());

            bool[] ciur = new bool[n + 1];
            for (int i = 2; i <= n; i++)
                ciur[i] = true;

            for (int i = 2; i * i <= n; i++)
            {
                if (ciur[i])
                {
                    for (int j = i * i; j <= n; j += i)
                        ciur[j] = false;
                }
            }
            Console.Write("Numerele prime mai mici sau egale cu n sunt: ");
            for (int i = 2; i <= n; i++)
            {
                if (ciur[i])
                    Console.Write(i + " ");
            }

        }

        private static void ex10()
        {
            Console.Write("Introduceti dimensiunea vectorului: ");
            int n= int.Parse(Console.ReadLine());

            int[] vector=new int[n];

            Console.WriteLine("Introduceti elementele vectorului: ");
            
            for(int i=0;i<n;i++)
            {
                Console.Write($"Elementul {i+1}: ");
                vector[i]=int.Parse(Console.ReadLine());
            }

            Console.Write("Introduceti nr pe care doriti sa il cautati in vector: ");
            int k = int.Parse(Console.ReadLine());

            int poz = BinarySearch(vector, k);

            if (poz != -1)
                Console.WriteLine($"Elementul {k} se află pe pozitia: {poz} ");
            
            else
                Console.WriteLine($"Elementul {k} nu a fost găsit în vector ");
        }
        static int BinarySearch(int[] vector, int k)
        {
            int st = 0;
            int dr = vector.Length - 1;
            while (st <= dr)
            {
                int mij = st + (dr - st) / 2;

                if (vector[mij] == k)
                    return mij;

                if (vector[mij] < k)
                    st = mij + 1;

                else
                    dr = mij - 1;
            }

            return -1;
        }

            private static void ex9()
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int n=int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti numarul pentru a roti vectorul cu acesta spre stanga: ");
            int k=int.Parse(Console.ReadLine());

            int[] vector= new int[n];

            Console.WriteLine("Introduceti elementele vectorului: ");
            for(int i=0;i<n;i++)
            {
                Console.Write($"Introduceti elementul {i+1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }
            k = k % n;
            for (int j = 0; j < k; j++)
            {
                int primulEl = vector[0];
                for (int i = 0; i < n - 1; i++)
                    vector[i] = vector[i + 1];
                vector[n - 1] = primulEl;
            }
            foreach(var element in vector)
            {
                Console.Write(element+ " ");
            }
        }

        private static void ex8()
        {
            Console.Write("Introduceti dimensiunea vectorului: ");
            int n= int.Parse(Console.ReadLine());

            int[] v = new int[n];

            Console.WriteLine("Introduceti elementele vectorului: ");
            int i = 0;
            for(i=0;i<n;i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                v[i]=int.Parse(Console.ReadLine());
            }
            i = 0;
            int primulEl = v[0];
            for(i=1;i<=n-1;i++)
            {
                v[i-1] = v[i];
            }
            v[n-1] = primulEl;

            foreach(var element in v)
            {
                Console.Write(element + " ");
            }
        }

        private static void ex7()
        {
            Console.Write("Introduceti dimensiunea vectorului: ");
            int n= int.Parse(Console.ReadLine());

            int[] a = new int[n];

            Console.WriteLine("Introduceti elementele vectorului: ");
            int i = 0;
            for (i=0; i<n;i++)
            {
                Console.Write($"Elementul {i+1}: ");
                a[i]= int.Parse(Console.ReadLine());
            }
            Array.Reverse(a);
            foreach (var element in a)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        private static void ex6()
        {
            Console.Write("Introduceti dimensiunea vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            Console.WriteLine("Introduceti elementele vectorului:");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Vectorul inainte de stergere:");
            AfisareVector(vector);

            Console.Write("Introduceti pozitia k pentru stergere: ");
            int k = int.Parse(Console.ReadLine());

            if (k >= 0 && k < n)
            {
                for (int i = k; i < n - 1; i++)
                {
                    vector[i] = vector[i + 1];
                }
                Array.Resize(ref vector, n - 1);
                Console.WriteLine("Vectorul dupa stergere:");
                AfisareVector(vector);
            }
            else
            {
                Console.WriteLine("Pozitia k nu este valida.");
            }
        }

        static void AfisareVector(int[] vector)
        {
            foreach (var element in vector)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        private static void ex5()
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] vect = new int[n];
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Introduceti elementul {j + 1}: ");
                vect[j] = int.Parse(Console.ReadLine());
            }

            Console.Write("Introduceti numarul -e- care va inlocui numarul ce se afla pe pozitia k in vector:");
            int e = int.Parse(Console.ReadLine());

            Console.Write("Introduceti pozitia -k-: ");
            int k = int.Parse(Console.ReadLine());
            for (int j = 0; j < n; j++)
                if (j == k)
                    vect[j] = e;
            Console.Write("Vectorul schimbat este:");
            int i = 0;
            while (i < n)
            {
                Console.Write(' ');
                Console.Write(vect[i]);
                i++;
            }
            Console.Write(" ");
        }

        private static void ex4()
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            int pozMin = 0, pozMax = 0, contMin=1, contMax=1;
            for (int j = 1; j < n; j++)
            {
                if (a[j] < a[pozMin])
                {
                    pozMin = j;
                    contMin = 1;
                }
                else if (a[j] == a[pozMin])
                    contMin++;
                if (a[j] > a[pozMax])
                {
                    pozMax = j;
                    contMax = 1;
                }
                else if (a[j] == a[pozMax])
                {
                    contMax++;
                }
            }
            Console.WriteLine($"Valoarea minima a vectorului e {a[pozMin]}, apare de {contMin} ori si valoarea maxima e {a[pozMax]}, apare de {contMax} ori ");
    }

        private static void ex3()
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int n= int.Parse(Console.ReadLine());

            int[] a= new int[n]; 

            for(int i=0;i<n;i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                a[i]=int.Parse(Console.ReadLine());
            }
            int pozMin = 0, pozMax = 0;
            for(int j=1; j<n;j++)
            {
                if (a[j] < a[pozMin])
                    pozMin = j;
                if (a[j] > a[pozMax])
                    pozMax = j;
            }
            Console.WriteLine($"Valoarea minima a vectorului e {a[pozMin]} si valoarea maxima e {a[pozMax]} ");
        }

        private static void ex2()
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            Console.Write("Introduceti numarul cautat: ");
            int k = int.Parse(Console.ReadLine()); 
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                v[i] = int.Parse(Console.ReadLine());
            }
            int pozk = 0;
            int j = 0;
            while (j <= n)
            {
                if (v[j] == k)
                {
                    pozk = j;
                    break;
                }
                j++;
            }
            Console.WriteLine($"Numarul cautat {k} se afla in vector pe pozitia {pozk} ");
        }

        private static void ex1()
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma += vector[i];
            }
            Console.WriteLine($"Suma elementelor vectorului este: {suma} ");
        }
    }
}

