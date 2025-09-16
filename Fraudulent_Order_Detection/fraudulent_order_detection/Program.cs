string[] orders = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"]; //string array oluşturma

foreach (string order in orders) //oluşturduğumuz array'i kullanarak döngüye sokma
{
    if (order.StartsWith("B")) //oluşturulan string array içerisinde "B" ile başlayan eleman tespiti
    {
        Console.WriteLine(order);
    }
}

