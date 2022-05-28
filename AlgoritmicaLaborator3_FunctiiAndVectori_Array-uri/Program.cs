using System;

namespace AlgoritmicaLaborator3_FunctiiAndVectori_Array_uri
{
    class Program
    {

        //static void Main(string [] args)
        //{

        //    //Ex1 Scrieti un program care sa calculeze maximul a trei numere citite de la
        //    //tastatura.Ex: se citeste 3,15,4 Vom afisa 15

        //    int a = CitireNumere();
        //    int b = CitireNumere();
        //    int c = CitireNumere();

        //    int[] numere = { a, b, c };

        //    int maxim, z = numere.Length;

        //    maxim = numere[0];

        //    for(int i = 0; i < z; i++)
        //    {
        //        if(numere[i] > maxim)
        //        {
        //            maxim = numere[i];
        //        }

        //    }

        //    Console.WriteLine("Maxim-ul celor 3 numere este : " + maxim);
        //}// ex1

        //static void Main(string[] args)
        //{
        //    //Ex2 Scrieti un program care va citi de la tastatura un numar intreg pozitiv
        //    //si va afisa valoarea acestuia in basa 2.Ex: se citeste 42, vom afisa 101010


        //    int numar = CitireNumere();

        //    int rezultat = 0 , putere = 1;

        //    while(numar != 0)
        //    {
        //        int cifra = numar % 2;

        //        rezultat = rezultat + cifra * putere;

        //        putere = putere * 10;

        //        numar = numar / 2;
        //    }

        //    Console.WriteLine("Cifra in baza 10 introduza de catre utilizator se afiseazqa in baza 2 astfel  :  " + rezultat);
        //} // ex 2

        //static void Main(string[] args)
        //{
        //    //Ex3 Scrieti un program care determina daca un numar n citit de la tastatura
        //    //este un patrat perfect.

        //    int numar = CitireNumere();

        //    if(numar < 0)
        //    {
        //        Console.WriteLine("Introduce-tin un numar pozitiv ! Incercati din nou !");
        //    }
        //    else
        //    {
        //        double rezultat = Math.Sqrt(numar) * Math.Sqrt(numar);

        //        if(rezultat == numar)
        //        {
        //            Console.WriteLine("Numarul introdus este patrat perfect ! ");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Numarul introdus de dumneavoastra nu este patrat perfect ! ");
        //        }
        //    }


        //}  // ex 3


        //static void Main(string[] args)
        //{
        //    //Ex4 Se citesc numere de la tastatură până la apariția lui zero. Să se
        //    //determine suma lor.


        //    int numar = CitireNumere();
        //    int suma;

        //    suma = numar;

        //    string AfisareRezultat = "Suma numerelor pana la aparitia lui 0 introduse de dumneavoastra este : ";

        //    while (numar != 0)
        //    {

        //       numar = int.Parse(Console.ReadLine());

        //        suma += numar;
        //    }

        //    Console.WriteLine(AfisareRezultat + suma);
        //}  // ex 4

        //static void Main(string[] args)
        //{
        //    //Ex5 Se citesc numere de la tastatură până când se introduc două numere
        //    //consecutive egale.Să se determine suma tuturor numerelor citite

        //    int numar = -1, numarX = -2, suma = 0;

        //    afisareMesajconsola();

        //    static void afisareMesajconsola()
        //    {
                

        //        Console.WriteLine("Suma numerelor introduse de dumneavoastra pana la aparitia numarului introdus consecutiv este : ");

        //    }

        //    string mesajAfisareRezultat = "Suma a celor numere introduse de dumneavoastra este : ";

       

        //    while(numar != numarX)
        //    {
                
           
        //       numarX = numar;

        //        numar = int.Parse(Console.ReadLine());

        //       suma += numar;
        //    }
      
        //    Console.WriteLine(mesajAfisareRezultat + suma);

        //}// 5

        //static void Main(string[] args)// ex 7
        //{
        //    //Ex7 Se citesc doua numere de la tastatura. Scrieti un program care va
        //    //calcula cel mai mare divizor comun al numerelor

        //    Console.WriteLine("Introduce-ti cele dou numere dorite de la tatstatura pentru a calcula cel mai mare divizor comun a numerelor ! '\n");

        //    Console.WriteLine("Introduce-ti primul numar ! ");

        //    int primulNumar = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Introduce-ti cel de-al doi-lea numar ! ");

        //    int ultimulNumar = int.Parse(Console.ReadLine());

        // //   int cmmdmc;

        //    while(primulNumar != ultimulNumar)
        //    {
        //        if(primulNumar > ultimulNumar)
                
        //           primulNumar -= ultimulNumar;
                
        //        else
                
        //            ultimulNumar -= primulNumar;
                

        //    }
        //    Console.WriteLine("Cel mai mare divizor comun ale numerelor introduze de dumneavoastra este : " + primulNumar);
        //}


        //static void Main(string[] args) // ex 8
        //{
        //    //Ex8 Scrie un program care afiseaza numerele de la 1 la N. Daca numarul
        //    //este multiplu de 3, sa se afiseze Fizz, daca este multiplu de 3 sa se afiseze
        //    //Buzz, daca e multiplu si de 3 si de 5(ex: 15) sa se afiseze FizzBuzz, in restul
        //    //cazurilor sa se afiseze numarul.


        //    Console.WriteLine("Introduceti un numar n de la tatstatura ! ");

        //    int n = int.Parse(Console.ReadLine());

        //    for(int i = 1; i < n + 1; i++)
        //    {
        //        if(i % 3 == 0)
                
        //            Console.WriteLine("Fizz ");

                

        //        if(i % 5 == 0)
                
        //            Console.WriteLine("Buzz ");

        //        else
        //        {
        //            if (i % 3 != 0 || i % 5 != 0)

        //                Console.WriteLine(i + " ");
        //        }
               
                
        //    }
        //}



        static int CitireNumere()
        {
            int x;

            Console.WriteLine("Introduce-ti numerele dorite de dumneavoastra !");

            x = int.Parse(Console.ReadLine());

            return x;
        }
    }
}