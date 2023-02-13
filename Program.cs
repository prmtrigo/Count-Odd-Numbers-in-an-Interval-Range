namespace Count_Odd_Numbers_in_an_Interval_Range;
class Program
{
    static void OddNumbers(int x, int y){
        
        int contador = 0;

        for (int i= x; i<= y; i++){
            if(i%2 != 0){
                contador++;
            }
        }

        Console.Write("A quantidade de números ímpares é: " + contador);
    }

    static void Main(string[] args)
    {
        
        Console.WriteLine("Vamos contar a Quantidade de Números ímpares entre X e Y: ");
        Console.WriteLine("Insira X: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insira Y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if(x > y){
            Console.WriteLine("X não pode ser maior que Y, insira outro valor: ");
            y = Convert.ToInt32(Console.ReadLine());
        }

        OddNumbers(x, y);
    }
}
