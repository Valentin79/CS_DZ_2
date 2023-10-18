namespace CS_Sem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var value = new Bits(7);
            var a = "";
            for (int j = 0; j < 8; j++)
            {
                a += value.GetBit(j) ? 1 : 0; // если i = true, записываем 1, иначе 0
            }
            a = string.Join("", a.Reverse());
            Console.WriteLine(a);

            value.SetBit(false, 2);
            Console.WriteLine(value.Value);


            long l = 1111111;
            int i = 22222;
            short s = 3333;
            byte b = 44;

            Bits res_long = l;
            Bits res_int = i;
            Bits res_short = s;
            Bits res_bit = b;

            Console.WriteLine($"{res_long}, {res_int}, {res_short}, {res_bit} ");
        }
    }
}
