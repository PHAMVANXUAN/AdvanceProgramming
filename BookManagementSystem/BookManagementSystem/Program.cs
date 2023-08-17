namespace BookManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookManage bookManage = new BookManage();
            int choice;
            while (true)
            {
                try
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Book Management System");

                        Console.WriteLine("1. Add Book");
                        Console.WriteLine("2. Show Book");
                        Console.WriteLine("3. Edit Book");
                        Console.WriteLine("4. Delete Book");
                        Console.WriteLine("5. Search Book by ID");
                        Console.WriteLine("Choose an option...");
                        choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.Clear();
                                bookManage.AddBook();
                                Console.ReadKey();
                                break;

                            case 2:
                                Console.Clear();
                                bookManage.ShowBook();
                                Console.ReadKey();
                                break;

                            case 3:
                                Console.Clear();
                                Console.WriteLine("Input Book's ID");
                                string iD = Console.ReadLine();
                                bookManage.EditBook(iD);
                                Console.ReadKey();
                                Console.Clear();
                                break;

                            case 4:
                                Console.Clear();
                                Console.WriteLine("Input Book's ID to delete");
                                string deleteID = Console.ReadLine();
                                bookManage.DeleteBook(deleteID);
                                Console.ReadKey();
                                Console.Clear();
                                break;

                            case 5:
                                Console.Clear();
                                Console.WriteLine("Input Book's ID");
                                string ID = Console.ReadLine();
                                bookManage.searchBook(ID);
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }
                    } while (choice != 0);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Number");
                }
            }
        }
    }
}