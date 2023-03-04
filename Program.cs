using System;

namespace SOLID_22._02._2023
{
    interface TIpe_Monet
    {
        int Money_Convert(int Count_Money);
    }
    class MoneyUSD : TIpe_Monet
    {
        public int Money_Convert(int Count_Money)
        {
            return Count_Money * 40;
        }

        internal void Money_Convert()
        {
            throw new NotImplementedException();
        }
    }
    class MoneyEUR : TIpe_Monet
    {
        public int Money_Convert(int Count_Money)
        {
            return Count_Money * 39;
        }

        internal MoneyUSD Money_Convert()
        {
            throw new NotImplementedException();
        }
    }
    class MoneyUAH : TIpe_Monet
    {
        public int Money_Convert(int Count_Money)
        {
            return Count_Money;
        }

        internal void Money_Convert()
        {
            throw new NotImplementedException();
        }
    }

    //интерфейс с одним методом , но 3 класса которые реализуют 1 интерфейс!!!

    interface Check_interface
    {
        void CHEK_Print();
    }
    class CHECK_Print : Check_interface
    {
        public void CHEK_Print()
        {
            Console.WriteLine("Ваш чек напичатан, спасибо что выбрали наш банк!!!");
        }
    }
    class CKECK_Email : Check_interface
    {
        public void CHEK_Print()
        {
            Console.WriteLine("Ваш чек отправлен на вашу электронную почту, спасибо что выбрали наш банк!!!");
        }

    }
    class CKECK_NOPrint : Check_interface
    {
        public void CHEK_Print()
        {
            Console.WriteLine("Вы отказались печатать чек, спасибо что выбрали наш банк!!!");
        }
    }
    class Persone
    {
        private string Name;
        private int Age;


        public Persone() { }
        public Persone(string N, int A)
        {
            Name = N;
            Age = A;

        }
        public void Petrsone()
        {
            Console.Write("Bведите своё имя:");
            Name = Convert.ToString(Console.ReadLine());
            Console.Write("Bведите свой возраст:");
            Age = Convert.ToInt32(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine($"Имя:{Name}\nВозраст:{Age}\n");
        }
        public override string ToString()
        {
            return $"Имя:{Name}\nВозраст:{Age}\n";
        }
    }

    class Bancomat
    {
        private int Number_Card;
        private int Pin_Card;
        private int CountMoneyOnTheCard;
        private int Count_Money;// количество сколько хочешь снять с карты
        public Check_interface hECK;
        public TIpe_Monet Monet;
        public Bancomat() { }
        public Bancomat(int NC, int PC, int CMC, int CM)
        {
            Number_Card = NC;
            Pin_Card = PC;
            CountMoneyOnTheCard = CMC;
            Count_Money = CM;
        }
        public Bancomat(Check_interface cHECK)
        {
            hECK = cHECK;
        }
        public Bancomat(TIpe_Monet Mon)
        {
            Monet = Mon;
        }
        public void ShowMenu()
        {
            Console.Write("Введите номер карты:");
            Number_Card = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите PIN карты:");
            Pin_Card = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество денег на вашей карты:");
            CountMoneyOnTheCard = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество которое вы хотетите снять карты:");
            Count_Money = Convert.ToInt32(Console.ReadLine());
        }
        public void Show()
        {
            Console.WriteLine($"Номер карты:{Number_Card}\nPIN карты:{Pin_Card}\nКоличесво денег на карте{CountMoneyOnTheCard}\nКоличество для снятие денег:{Count_Money}\n");
        }
        public override string ToString()
        {
            return $"Номер карты:{Number_Card}\nPIN карты:{Pin_Card}\nКоличесво денег на карте{CountMoneyOnTheCard}\nКоличество для снятие денег:{Count_Money}\n";
        }
    }
    class Program
    {
        public static MoneyUSD TIpe_Monet { get; private set; }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Persone obj1 = new Persone();
            obj1.Petrsone();
            Console.WriteLine("\n");
            obj1.Print();
            Bancomat obj = new Bancomat();
            obj.ShowMenu();
            Console.WriteLine("\n");
            obj.Show();
            Console.WriteLine("1)Печатать чек\t2)Не печатать чек\t3)Отправить чек на почту\n");
            int A = Convert.ToInt32(Console.ReadLine());
            CHECK_Print cHECK = new CHECK_Print();
            CKECK_Email kECK_Email = new CKECK_Email();
            CKECK_NOPrint CKECK_NOPrint = new CKECK_NOPrint();
            if (A == 1)
            {
                cHECK.CHEK_Print();
            }
            if (A == 3)
            {
                kECK_Email.CHEK_Print();
            }
            if (A == 2)
            {
                CKECK_NOPrint.CHEK_Print();
            }
            Console.WriteLine("1)Перевод денег в доллары\t2)Перевод денег в Евро\t3)Не переводить деньги\n");
            int B = Convert.ToInt32(Console.ReadLine());
            MoneyUSD uSD = new MoneyUSD();
            MoneyEUR eUR = new MoneyEUR();
            MoneyUAH uAH = new MoneyUAH();
            if (B == 1)
            {
                uSD.Money_Convert();
            }
            if (B == 2)
            {
                eUR.Money_Convert();
            }
            if (B == 3)
            {
                uAH.Money_Convert();
            }
        }

    }

}
