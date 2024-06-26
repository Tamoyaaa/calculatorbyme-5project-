namespace calculatorbyme_5project_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double first, second;
            string value;
            while (true) {
                {

                    Console.WriteLine("введите первое число:");
                    first = double.Parse(Console.ReadLine());

                    Console.WriteLine("введите второе число:");
                    second = double.Parse(Console.ReadLine());

                    Console.WriteLine("Выберите действие: '+' '-' '/' '*' '%' ");
                    var action = Console.ReadLine();

                    switch (action)
                    {
                        case "+":
                            Console.WriteLine(first + second);
                            continue;
                        case "%":
                            Console.WriteLine(first % second);
                            continue;
                        case "-":
                            Console.WriteLine(first - second);
                            continue;
                        case "*":
                            Console.WriteLine(first * second);
                            continue;
                        case "/":
                            if (second == 0)
                                Console.WriteLine(0);
                            else
                                Console.WriteLine(first / second);
                            continue;
                            

                        default:
                            Console.WriteLine("Ошибка");
                            continue;
                    }

                } 


            }
        }
    }         
}