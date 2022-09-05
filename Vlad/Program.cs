class Pks
{
    public static void Zadanie1(string word)
    {
        string a1 = "house";
        string a2 = "dog";
        string a3 = "cat";
        string p1 = "дом";
        string p2 = "собака";
        string p3 = "кот";
        if (word == a1)
            Console.WriteLine("Перевод " + p1);
        else if (word == a2)
            Console.WriteLine("Перевод " + p2);
        else if (word == a3)
            Console.WriteLine("Перевод " + p3);
        else
            Console.WriteLine("Такого слова нет в базе");
    }
    public static void Zadanie2()
    {
        double[] x = new double[5] {3,1,1,3,2};
        double[] y = new double[5] {1,2,3,1,3};
        double[] z = new double[5] {3,2,1,2,2};
        double[] a = new double[5];
        double[] b = new double[1];
        double[] sum = new double[1];
        for (int i = 0; i<5; i++)
        {
            a[i] = Math.Sqrt(Math.Abs(x[i] * y[i] * z[i]));
        }
        foreach(double i in a)
        {
            Console.WriteLine("a = "+ i);
        }
            sum[0] = Math.Pow(x[0], 2) - 2 * x[0] * y[0] + Math.Pow(y[0], 2);
        for (int i = 0; i<5; i++)
        {
            foreach(int num in sum)
            {
                b[0] += num;
            }
        }
            Console.WriteLine("b= " + b[0]);
    }
    public static void Main(String[] args)
    {
        Console.Write("Введите слово(house, cat или dog): ");
        Zadanie1(Console.ReadLine());
        Zadanie2();
        Console.ReadLine();
    }
}
