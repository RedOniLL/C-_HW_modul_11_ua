namespace C__HW_modul_11_ua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter choice: ");

            int c = int.Parse(Console.ReadLine());

            switch (c)
            {
                case 0:
                    using (Play play = new Play("Hamlet", "William Shakespeare", "Tragedy", 1601))
                    {
                        play.DisplayInfo();
                    }

                    Console.ReadLine();
                    break;
                case 1:
                    using (Store store = new Store("Groceries", "Main St. 1", "food"))
                    {
                        store.DisplayInfo();
                    }

                    Console.ReadLine();
                    break;
            }
        }
    }
}
