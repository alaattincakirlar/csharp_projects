Random random = new Random(); // Random sınıfı kullanarak bir nesne oluşturma
int daysUntilExpiration = random.Next(12); // 0 - 11 arası rastgele sayı oluşturma metodu ve atama
int discountPercentage = 0;

if ((daysUntilExpiration <= 10) && (daysUntilExpiration > 5))
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if ((daysUntilExpiration <= 5) && (daysUntilExpiration > 1))
{
    Console.WriteLine("Your subscription expires in " + daysUntilExpiration + " days."); //Yazdırma metot 1
    discountPercentage = 10;
    Console.WriteLine("Renew now and save " + discountPercentage + "%.");
}

if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day.");
    discountPercentage = 20;
    Console.WriteLine($"Renew now and save {discountPercentage}%."); //Yazdırma metot 2
}

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired."); 
}