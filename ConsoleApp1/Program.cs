// See https://aka.ms/new-console-template for more information
/*4. ------------------- Автомат гарячих напоїв. 
Створити ієрархію класів для подання гарячих напоїв Автомату(кава, чай, капучіно та ін.)
Створити програму для роботи Автомату у  режимах адмін та користувач
У режимі адміна передбачити 	
	Завантаження автомату водою, кава, чай, цукор
	Вивід статистики наявності складових для приготування напоїв
	Зміна цін на напої
	Вилучення кешу
У режимі користувача передбачити*/
Console.WriteLine("------------ Welcome to chayok-kofiyok ------------");
//Замовлення напою(+ оплата)	
Console.WriteLine("Hi bitches! Do you want some coffee?");
Console.WriteLine("1.zavantazhennia avtomatu vodoyu, kofiyok, chayok, cukor");
Console.WriteLine("2.vyvid statystyky nayavnosti skladovyh dla napoyiv");
Console.WriteLine("3.zmina cin na napoi");
Console.WriteLine("4.vyluchennia gotivki abo groshikiv z kartochki");
Console.WriteLine("5.prygotuvaty napiy ");

List<drink> napoyiList = new();


while (true)
{
    Console.Write("Select menu option: ");
    int option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            foreach (var com in napoyiList)
            {
                Console.WriteLine("-------------- napiy -------------");
                Console.WriteLine($"Name: {com.Name}");
                Console.WriteLine($"Capacity: {com.Capacity}ml");
            }
            break;
        case 2:
            var newNapiy = new drink();

            Console.Write("yakiy napiy vy hochete zamovyty? ");
            newNapiy.Name = Console.ReadLine();
            Console.Write("vvedit obyem napoyu: ");
            newNapiy.Capacity = double.Parse(Console.ReadLine());

            napoyiList.Add(newNapiy);
            break;
    }

    Console.WriteLine("natysnit dla prodovzhennia...");
    Console.ReadKey();
    Console.Clear();
}


public class drink
{
    public string Name { get; set; }
    public double Capacity { get; set; }
    public float Price { get; set; }i76i67i76677889
    public string Composition { get; set; }
}

public class admin
{
    public string Ingredient { get; set; }7i7i
    public int Amount { get; set; }
}rtfjfuftfr
