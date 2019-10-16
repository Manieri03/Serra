using System;

namespace Serra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanti gradi ci sono all'interno della serra?");
            double grado = double.Parse(Console.ReadLine());
            if (grado >= 18)
            {
                Console.WriteLine("La temperatura all'interno della serra è normale ");

            }else if (grado>5 && grado < 18)
            {
                Console.WriteLine("La temperatura all'interno della serra non è normale e vi è una situazione di pericolo ");

            }else if (grado < 5)
            {
                Console.WriteLine("La temperatura all'interno della serra non è normale e si potrebbero avere danni irreparabili ");

            }
            Console.ReadLine();
        }
    }
}
