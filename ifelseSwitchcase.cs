Console.WriteLine("Rüya Manavına Hoşgeldiniz");
Console.WriteLine("Hangi Meyveyi Satın Almak İstersiniz ?");
Console.WriteLine("Elma => 2 TL");
Console.WriteLine("Armut => 3 TL");
Console.WriteLine("Çilek => 2 TL");
Console.WriteLine("Muz => 3 TL");
Console.WriteLine("Diğer Bütün Meyveler => 4 TL");

void ifile()
{
    string meyve = Console.ReadLine();
    meyve = meyve.ToLower();
    if (meyve == "elma")
    {
        Console.WriteLine("Seçtiğiniz Meyvenin Fiyatı: 2 TL'dir");
    }
    else if (meyve == "armut")
    {
        Console.WriteLine("Seçtiğiniz Meyvenin Fiyatı: 3 TL'dir");
    }
    else if (meyve == "çilek")
    {
        Console.WriteLine("Seçtiğiniz Meyvenin Fiyatı: 2 TL'dir");
    }
    else if (meyve == "muz")
    {
        Console.WriteLine("Seçtiğiniz Meyvenin Fiyatı: 3 TL");
    }
    else
    {
        Console.WriteLine("Bu meyvenin fiyatı: 4 TL");
    }
}
ifile();
void switchCase()
{
    string meyve = Console.ReadLine();
    meyve = meyve.ToLower();
    switch (meyve)
        {
        case "elma":
            Console.WriteLine("Seçtiğiniz Meyvenin Fiyatı: 2 TL'dir");
            break;
        case "armut":
            Console.WriteLine("Seçtiğiniz Meyvenin Fiyatı: 3 TL'dir");
            break;
        case "çilek":
            Console.WriteLine("Seçtiğiniz Meyvenin Fiyatı: 2 TL'dir");
            break;
        case "muz":
            Console.WriteLine("Seçtiğiniz Meyvenin Fiyatı: 3 TL'dir");
            break;
        default:
            Console.WriteLine("Bu Meyvenin Fiyatı: 4 TL'dir");
            break;

    }
}
switchCase();
// Bence switch case ile yapılması daha uygun çünkü direkt istenilen sonuca gidiyor.