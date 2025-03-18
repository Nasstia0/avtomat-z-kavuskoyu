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

//Замовлення напою(+ оплата)	
Console.WriteLine("Hi bitches! Do you want some coffee?");
Console.WriteLine("1. zavantazhennia avtomatu vodoyu, kofiyok, chayok, cukor");
Console.WriteLine("2.vyvid statystyky nayavnosti skladovyh dla napoyiv");
Console.WriteLine("3. zmina cin na napoi");
Console.WriteLine("4.vyluchennia gotivki");
public class drink
{
    public string name { get; set; }
    public int capacity { get; set; }
    public float price { get; set; }
    public string composition { get; set; }
}

public class admin
{
    public string ingredient { get; set; }
    public int amount { get; set; }
}
