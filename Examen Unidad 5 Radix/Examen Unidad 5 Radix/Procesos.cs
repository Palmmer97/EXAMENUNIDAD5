using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_5_Radix
{
   
    class Procesos
    {
        int[] Array; 
        List<char> AgregarNUMEROaLETRAS = new List<char>();
        List<int> VALORSITO = new List<int>();
        List<string> AgregarLETRASaNUMEROS = new List<string>();
        public void Desarrollo() 
        {
            string ESCRITO = @"lorem ipsum dolor sit amet consectetur adipscing elit fusce varios 
augue vitae tincidunt viverra sem felis bibendum nisl id cursus diam leo sit amet urna dius ac massa est";
            foreach (char item in ESCRITO)
            {
                AgregarNUMEROaLETRAS.Add(item);
            }
            foreach (var item in AgregarNUMEROaLETRAS)
            {
                char abecedario = item;
                if (abecedario == 'a')
                {
                    VALORSITO.Add(1);
                }
                else if (abecedario == 'b')
                {
                    VALORSITO.Add(2);
                }
                else if (abecedario == 'c')
                {
                    VALORSITO.Add(3);
                }
                else if (abecedario == 'd')
                {
                    VALORSITO.Add(4);
                }
                else if (abecedario == 'e')
                {
                    VALORSITO.Add(5);
                }
                else if (abecedario == 'f')
                {
                    VALORSITO.Add(6);
                }
                else if (abecedario == 'g')
                {
                    VALORSITO.Add(7);
                }
                else if (abecedario == 'h')
                {
                    VALORSITO.Add(8);
                }
                else if (abecedario == 'i')
                {
                    VALORSITO.Add(9);
                }
                else if (abecedario == 'j')
                {
                    VALORSITO.Add(10);
                }
                else if (abecedario == 'k')
                {
                    VALORSITO.Add(11);
                }
                else if (abecedario == 'l')
                {
                    VALORSITO.Add(12);
                }
                else if (abecedario == 'm')
                {
                    VALORSITO.Add(13);
                }
                else if (abecedario == 'n')
                {
                    VALORSITO.Add(14);
                }
                else if (abecedario == 'o')
                {
                    VALORSITO.Add(15);
                }
                else if (abecedario == 'p')
                {
                    VALORSITO.Add(16);
                }
                else if (abecedario == 'q')
                {
                    VALORSITO.Add(17);
                }
                else if (abecedario == 'r')
                {
                    VALORSITO.Add(18);
                }
                else if (abecedario == 's')
                {
                    VALORSITO.Add(19);
                }
                else if (abecedario == 't')
                {
                    VALORSITO.Add(20);
                }
                else if (abecedario == 'u')
                {
                    VALORSITO.Add(21);
                }
                else if (abecedario == 'v')
                {
                    VALORSITO.Add(22);
                }
                else if (abecedario == 'w')
                {
                    VALORSITO.Add(23);
                }
                else if (abecedario == 'x')
                {
                    VALORSITO.Add(24);
                }
                else if (abecedario == 'y')
                {
                    VALORSITO.Add(25);
                }
                else if (abecedario == 'z')
                {
                    VALORSITO.Add(26);
                }
            }
            Array = new int[VALORSITO.Count];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = VALORSITO[i];
            }
            QuickSort(Array, 0, Array.Length - 1);
            Imprimir(Array.Length);
            Console.WriteLine("\n\n\n\n\n\n\n");
            foreach (int item in Array)
            {
                int LETRITA = item;
                if (LETRITA == 1)
                {
                    AgregarLETRASaNUMEROS.Add("a");
                }
                else if (LETRITA == 2)
                {
                    AgregarLETRASaNUMEROS.Add("b");
                }
                else if (LETRITA == 3)
                {
                    AgregarLETRASaNUMEROS.Add("c");
                }
                else if (LETRITA == 4)
                {
                    AgregarLETRASaNUMEROS.Add("d");
                }
                else if (LETRITA == 5)
                {
                    AgregarLETRASaNUMEROS.Add("e");
                }
                else if (LETRITA == 6)
                {
                    AgregarLETRASaNUMEROS.Add("f");
                }
                else if (LETRITA == 7)
                {
                    AgregarLETRASaNUMEROS.Add("g");
                }
                else if (LETRITA == 8)
                {
                    AgregarLETRASaNUMEROS.Add("h");
                }
                else if (LETRITA == 9)
                {
                    AgregarLETRASaNUMEROS.Add("i");
                }
                else if (LETRITA == 10)
                {
                    AgregarLETRASaNUMEROS.Add("j");
                }
                else if (LETRITA == 11)
                {
                    AgregarLETRASaNUMEROS.Add("k");
                }
                else if (LETRITA == 12)
                {
                    AgregarLETRASaNUMEROS.Add("l");
                }
                else if (LETRITA == 13)
                {
                    AgregarLETRASaNUMEROS.Add("m");
                }
                else if (LETRITA == 14)
                {
                    AgregarLETRASaNUMEROS.Add("n");
                }
                else if (LETRITA == 15)
                {
                    AgregarLETRASaNUMEROS.Add("o");
                }
                else if (LETRITA == 16)
                {
                    AgregarLETRASaNUMEROS.Add("p");
                }
                else if (LETRITA == 17)
                {
                    AgregarLETRASaNUMEROS.Add("q");
                }
                else if (LETRITA == 18)
                {
                    AgregarLETRASaNUMEROS.Add("r");
                }
                else if (LETRITA == 19)
                {
                    AgregarLETRASaNUMEROS.Add("s");
                }
                else if (LETRITA == 20)
                {
                    AgregarLETRASaNUMEROS.Add("t");
                }
                else if (LETRITA == 21)
                {
                    AgregarLETRASaNUMEROS.Add("u");
                }
                else if (LETRITA == 22)
                {
                    AgregarLETRASaNUMEROS.Add("v");
                }
                else if (LETRITA == 23)
                {
                    AgregarLETRASaNUMEROS.Add("w");
                }
                else if (LETRITA == 24)
                {
                    AgregarLETRASaNUMEROS.Add("x");
                }
                else if (LETRITA == 25)
                {
                    AgregarLETRASaNUMEROS.Add("y");
                }
                else if (LETRITA == 26)
                {
                    AgregarLETRASaNUMEROS.Add("z");
                }
            }
            Console.WriteLine("LETRAS ORDENADAS ");
            foreach (var item in AgregarLETRASaNUMEROS)
            {
                Console.Write(" ({0}) ", item);
            }
        }

        private void QuickSort(int[] Arrey, double I, double U) 
        {
            int t, Bryan, ANgel; 
            double Pivotito; 
            ANgel = Convert.ToInt32((I + U) / 2); 
            Pivotito = Arrey[ANgel]; 
            t = Convert.ToInt32(I); 
            Bryan = Convert.ToInt32(U); 
            do 
            {
                while (Arrey[t] < Pivotito) t++; 
                while (Arrey[Bryan] > Pivotito) Bryan--;

                if (t <= Bryan) 
                {

                    int Temporal = Arrey[t]; 
                    Arrey[t] = Arrey[Bryan]; 
                    Arrey[Bryan] = Temporal; 
                    t++; 
                    Bryan--; 

                }
            } while (t <= Bryan); 

            if (I < Bryan) 
            {
                QuickSort(Arrey, I, Bryan); 
            }
            if (t < U) 
            {
                QuickSort(Arrey, t, U); 
            }
        }

        private void Imprimir(int Tam) 
        {
            Console.WriteLine("\n\nNUMEROS ORDENADOS ");
            for (int i = 0; i < Tam; i++)  
            {
                Console.Write("("+Array[i]+")" + "   "); 
            }
        }











        private int[] A;
        public void METODOBURBUJA()
        {
            Console.WriteLine("Metodo Burbuja");
            Console.WriteLine("");
            Console.WriteLine("\nQue contengan solamente (0,1,2)");
            List<bool> Procesar = new List<bool>();
            Console.WriteLine("INTRODUCIR EL TAMAÑO DEL VECTOR");
            int cant = int.Parse(Console.ReadLine());
            A = new int[cant];
            for (int i = 1; i < A.Length; i++)
            {
            regreso:
                Console.Clear();
                Console.WriteLine("Introducir los valores, Recuerde solo valores [0,1,2]:", i + 1);
                string String = Console.ReadLine();
                foreach (var item in String)
                {
                    string Escrito = Convert.ToString(item);
                    if (Escrito== "0")
                    {
                        Procesar.Add(true);
                    }
                    else
                        if (Escrito=="1")
                        {
                          Procesar.Add(true);  
                        }
                    else
                            if (Escrito == "2")
                            {
                                Procesar.Add(true);
                            }
                            else
                            {
                                Procesar.Add(false);
                            }
                }
                if (Procesar.Contains(false) == true)
                {
                    Console.WriteLine(@"Error valor no admitido
solo ingrese valores relacionados con 0,1,2");
                    Console.ReadKey();
                    Procesar.Remove(false);
                    goto regreso;
                }
                else
                {
                    A[i] = int.Parse(String);
                }
            }


            Console.WriteLine("Sus numeros sin ordenar son: ");
            for (int i = 1; i < A.Length; i++)
            {
                Console.WriteLine( A[i]);
            }
          
            int aux;
            for (int i = 1; i <= A.Length; i++)
            {
                for (int j = 1; j < A.Length - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        aux = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = aux;
                    }
                }
            }
    
            Console.WriteLine("\n Los numeros ordenados son: ");
            for (int i = 1; i < A.Length; i++)
            {
                Console.WriteLine( A[i]);
            }

            Console.ReadKey();
  
        }


        private int[] C;
        private int[] V;
        public void CAPTURAR()
        {
            string linea;
            Console.WriteLine("INTRODUCIR EL TAMAÑO DEL VECTOR");
            int cant= int.Parse(Console.ReadLine());
            C = new int[cant];
            V = new int[cant];
            for (int F = 0; F < V.Length; F++)
            {
                Console.WriteLine("INGRESE EL NUMERO DE CONTROL " + (F + 1) + ": ");
                linea = Console.ReadLine();
                V[F] = int.Parse(linea);
                C[F] = int.Parse(linea);
            }
        }
        public void METODO_SHELL()
        {
            int ST = 0;
            int SW = 0;
            int AX = 0;
            int E = 0;
            ST = V.Length / 2;
            while (ST > 0)
            {
                SW = 1;
                while (SW != 0)
                {
                    SW = 0;
                    E = 1;
                    while (E <= (V.Length - ST))
                    {
                        if (V[E - 1] > V[(E - 1) + ST])
                        {
                            AX = V[(E - 1) + ST];
                            V[(E - 1) + ST] = V[E - 1];
                            V[(E - 1)] = AX;
                            SW = 1;
                        }
                        E++;
                    }
                }

                ST = ST / 2;
            }
        }
        public void RESULTADO()
        {

            Console.WriteLine("Vector ordenados mayor-menor :");
            int Contador = V.Length-1;
            do
            {
                Console.Write(V[Contador] + "  " + "\n");
                Contador--;
            } while (Contador >= 0);
            Console.WriteLine("Vector capturado:");
            for (int f = 0; f < V.Length; f++)
            {
                Console.Write(C[f] + "  " + "\n");
            }
            Console.ReadKey();
        }


        public void Radix()
        {


            
            Random Ran = new Random();
            Stack<int> Random = new Stack<int>();
            int[] V = new int[80];
            
            for (int a = 0; a < 80; a++)
            {
            Vuelve:
                int Val = Ran.Next(0, 99);
                if (Random.Contains(Val) == false)
                {
                    Random.Push(Val);
                }
                else { goto Vuelve; }

                int peque =0;
                foreach (var item in Random)
                {
                    V[peque] = item;
                    peque++;
                }
            }  
          RadixSort(V);
        }
       
         public void RadixSort(int[] Numeros)
        {
            int i, NumerosNegativos = 0, Tamaño = Numeros.Length, ContadorN = 0, ContadorP = 0, Maximo, Minimo;
            
            for (i = 0; i < Tamaño; i++)
            {
                if (Numeros[i] < 0)
                    NumerosNegativos++;
            }

            
            if (NumerosNegativos != 0)
            {
                int[] ArregloPositivos = new int[(Tamaño - NumerosNegativos)];
                int[] ArregloNegativos = new int[NumerosNegativos];
                for (i = 0; i < Tamaño; i++)
                {
                    if (Numeros[i] < 0)
                    {
                        ArregloNegativos[ContadorN] = Numeros[i];
                        ContadorN++;
                    }
                    else
                    {
                        ArregloPositivos[ContadorP] = Numeros[i];
                        ContadorP++;
                    }

                }

                
                Minimo = ArregloNegativos[0];
                Maximo = ArregloPositivos[0];


                
                ArregloNegativos[0] *= -1;
                for (i = 1; i < ArregloNegativos.Length; i++)
                {
                    ArregloNegativos[i] *= -1;
                    if (ArregloNegativos[i] > Minimo)
                        Minimo = ArregloNegativos[i];
                }
                for (i = 1; i < ArregloPositivos.Length; i++)
                {
                    if (ArregloPositivos[i] > Maximo)
                        Maximo = ArregloPositivos[i];
                }
                
                Ordena(ArregloNegativos);
                Ordena(ArregloPositivos);
               
                for (i = 0; i < ArregloNegativos.Length; i++)
                    ArregloNegativos[i] *= -1;
                Console.WriteLine("numeros ordenados \n");
                for (i = 0; i < ArregloPositivos.Length; i++)
                    Console.WriteLine(ArregloPositivos[i]);
            }
            else  
            {
                int[] ArregloPositivos = new int[Tamaño]; 
                for (i = 0; i < Tamaño; i++)
                {
                    ArregloPositivos[ContadorP] = Numeros[i];
                    ContadorP++; 
                }
                Maximo = ArregloPositivos[0]; 
                for (i = 1; i < ArregloPositivos.Length; i++) 
                {
                    if (ArregloPositivos[i] > Maximo)
                        Maximo = ArregloPositivos[i];
                }
                Ordena(ArregloPositivos); 
                Console.WriteLine("\nnumeros ordenados \n"); 
                for (i = 0; i < ArregloPositivos.Length; i++)
                    Console.WriteLine("({0}) {1}",i+1,ArregloPositivos[i] );
            }
        }


        private int[] Ordena(int[] ArregloBase)
        {
            int[] ATemporal = new int[ArregloBase.Length]; 
            int BitsEntero = 32; 
            int BitsGrupo = 2;         
            int[] ConteoArreglos = new int[1 << BitsGrupo];  
            int[] Valores = new int[1 << BitsGrupo];  
            int Grupos = (int)Math.Ceiling((double)BitsEntero / (double)BitsGrupo);  
            int Identificador = (1 << BitsGrupo) - 1; 
            for (int c = 0, Apoyo = 0; c < Grupos; c++, Apoyo += BitsGrupo)   
            {             
                for (int j = 0; j < ConteoArreglos.Length; j++) 
                {
                  ConteoArreglos[j] = 0;  
                }                     
                for (int i = 0; i < ArregloBase.Length; i++)  
                {
                ConteoArreglos[(ArregloBase[i] >> Apoyo) & Identificador]++;
                Valores[0] = 0; 
                }              
                for (int i = 1; i < ConteoArreglos.Length; i++)
                {
                    Valores[i] = Valores[i - 1] + ConteoArreglos[i - 1];
                }
                    
                for (int i = 0; i < ArregloBase.Length; i++) 
                {
                   ATemporal[Valores[(ArregloBase[i] >> Apoyo) & Identificador]++] = ArregloBase[i];
                }                                  
                ATemporal.CopyTo(ArregloBase, 0); 
            }
            return ArregloBase;
        }         
        }
    }


