using Worksheet11;

List<Book> books = new List<Book>();

while (true)
{
    Console.WriteLine("\n=== Bookshop Menu ===");
    Console.WriteLine("1. Add a Book");
    Console.WriteLine("2. Search for a Book by ISBN");
    Console.WriteLine("3. Update Inventory"); 
    Console.WriteLine("4. View All Books");
    Console.WriteLine("5. Exit");

    Console.Write("Enter your choice: ");
    string choice = Console.ReadLine();

    if (choice == "1")
    {
        AddNewBook();
    }
    else if (choice == "3")
    {
        // Update the inventory of a book
        Console.Write("Enter ISBN of the book to update: ");
        string isbnToUpdate = Console.ReadLine();
        Book b = FindBook(isbnToUpdate);

        if (b != null)
        {
            UpdateQuantity(b);
        }
        else
        {
            Console.WriteLine("Book not found!");
        }
    }
    else if (choice == "2")
    {
        // Search for a book by ISBN
        Console.Write("Enter ISBN of the book to search: ");
        string isbn = Console.ReadLine();
        Book b = FindBook(isbn);

        if (b != null)
        {
            Console.Write(b.GetData());
        }
        else {
            Console.WriteLine("Book not found!");                
        }        
    }
    else if (choice == "4")
    {
        PrintAllBooks();
    }
    else if (choice == "5")
    {        
        break;
    }
    else
    {
        Console.WriteLine("Invalid choice. Please try again.");
    }
}

void AddNewBook()
{
    // Add a new book
    Console.Write("Enter ISBN: ");
    string isbn = Console.ReadLine();
    Console.Write("Enter Title: ");
    string title = Console.ReadLine();
    Console.Write("Enter Author: ");
    string author = Console.ReadLine();
    Console.Write("Enter Price: ");
    double price = double.Parse(Console.ReadLine());
    Console.Write("Enter Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    Book newBook = new Book(isbn, title, author, price, quantity);
    books.Add(newBook);
    Console.WriteLine("Book added successfully!");
}

Book FindBook(string isbn)
{   
    foreach (var book in books)
    {
        if (book.Isbn == isbn)
        {
            return book;            
        }
    }

    return null;
}

void UpdateQuantity(Book b)
{
    Console.Write("Enter new quantity: ");
    int newQuantity = int.Parse(Console.ReadLine());

    b.Quantity = newQuantity;
    Console.WriteLine("Book inventory updated successfully!");
}

void PrintAllBooks()
{
    // View all books in the inventory
    if (books.Count == 0)
    {
        Console.WriteLine("No books in inventory.");
    }
    else
    {
        Console.WriteLine("Books in inventory:");
        foreach (Book book in books)
        {
            Console.WriteLine(book.GetData());
        }
    }
}