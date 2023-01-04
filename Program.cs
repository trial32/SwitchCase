// See https://aka.ms/new-console-template for more information
int month =DateTime.Now.Month;

switch (month)
{
    case 1:
        Console.WriteLine("Ocak ayındasınız");
        break;
    case 2:
        Console.WriteLine("Şubat ayındasınız");
        break;
    case 3:
        Console.WriteLine("Mart ayındasınız");
        break;
    case 4:
        Console.WriteLine("Nisan ayındasınız");
        break;
    default: 
        Console.WriteLine("Yanlış veri girişi..");
    break;
}

switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış ayındayız");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("İlk bahar ayındayız");
        break;



    default:
    break;
}

