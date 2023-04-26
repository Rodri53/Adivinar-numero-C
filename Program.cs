class Program
{
    static void Main(string[] args)
    {
        int númeroQueAdivinar = new Random().Next(1, 16);
        int intentos = 3;
        Console.WriteLine("Tienes que adivinar un número entre 1 y 15 en tres intentos.");

        while (intentos > 0)
        {
            Console.WriteLine("Tienes " + intentos + " intentos.");
            Console.Write("Introduce tu número: ");
            int númeroIntroducido = Convert.ToInt32(Console.ReadLine());

            if (númeroIntroducido == númeroQueAdivinar)
            {
                Console.WriteLine("¡Felicidades, has ganado!");
                return;
            }
            else
            {
                intentos--;
                if (númeroIntroducido < númeroQueAdivinar)
                {
                    Console.WriteLine("El número a adivinar es mayor.");
                }
                else
                {
                    Console.WriteLine("El número a adivinar es menor.");
                }
            }
        }

        Console.WriteLine("¡Lo siento, has perdido! El número a adivinar era: " + númeroQueAdivinar);
    }
}
