class Program
{
    static void Main(string[] args)
    {
        string Fruitty = "";
        Queue<char> QFruit = new Queue<char>();
        char FPiece;

        while (true)
        {
            FPiece = Console.ReadLine()[0];

            if (!(FPiece == 'L' || FPiece == 'M' || FPiece == 'S')) 
            { break; }

            if (FPiece == 'L')
            {
                QFruit.Push('1'); 
                Fruitty += "1";
            }
            else if (FPiece == 'M')
            {
                QFruit.Push('2'); 
                Fruitty += "2";
            }
            else if (FPiece == 'S')
            {
                QFruit.Push('3'); 
                Fruitty += "3";
            }
        }

        int i = 0;
        while (0 < QFruit.GetLength())
        {
            char temp = QFruit.Pop();
            if (temp == '1')
            {
                Fruitty += "22";
                QFruit.Push('2'); 
                QFruit.Push('2');
            }
            else if (temp == '2')
            {
                Fruitty += "333";
                QFruit.Push('3'); 
                QFruit.Push('3'); 
                QFruit.Push('3');
            }
            i++;
        }

        while (0 < QFruit.GetLength())
        {
            char temp = QFruit.Pop();
            if (temp == '1')
            {
                Fruitty += "22";
                QFruit.Push('2'); 
                QFruit.Push('2');
            }
            else if (temp == '2')
            {
                Fruitty += "333";
                QFruit.Push('3'); 
                QFruit.Push('3'); 
                QFruit.Push('3');
            }
            i++;
        }
        Console.WriteLine(Fruitty);
    }
}
