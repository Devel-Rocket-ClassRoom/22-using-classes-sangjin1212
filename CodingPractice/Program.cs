using System;
using System.Reflection.Metadata.Ecma335;

// README.md를 읽고 아래에 코드를 작성하세요.
//1
ClassName.MemberName();
//2
string square = Square.GetName();
Console.WriteLine(square);
//3
MyFirstClass.StaticMehod();
MyFirstClass my = new MyFirstClass();
my.InstanceMethod();
//4
Person person1 = new Person();
person1.Name = "홍길동";
person1.age = 25;
person1.Introduce();

Person person2 = new Person();
person2.Name = "김철수";
person2.age = 30;
person2.Introduce();
//5
Point point1 = new Point();
point1.X = 10;
point1.Y = 20;

Point point2 = point1;
point2.X = 100;
Console.WriteLine($"point1.X = {point1.X}");
Console.WriteLine($"point2.X = {point2.X}");
//6
PointStruct ps1 = new PointStruct();
ps1.X = 10;
PointStruct ps2 = ps1;
ps2.X = 100;
Console.WriteLine($"구조체: ps1.X = {ps1.X}, ps2.X = {ps2.X}");

PointClass pc1 = new PointClass();
pc1.X = 10;
PointClass pc2 = pc1;
pc2.X = 100;
Console.WriteLine($"클래스: pc1.X = {pc1.X}, pc2.X = {pc2.X}");
//7
Calculator calu = new Calculator();
Console.WriteLine($"3 + 5 = {calu.Add(3, 5)}");
Console.WriteLine($"3 * 5 = {calu.Multiply(3, 5)}");
//8
Player player1 = new Player();
player1.ShowInfo();
Player player2 = new Player("용사" , 150);
player2.ShowInfo();
//9
Stock stock = new Stock();
stock.CurrentPrice = 30;
Console.WriteLine($"주가 : {stock.CurrentPrice}");
//10
Product product = new Product();
product.Name = "노트북";
product.Price = 1500000;
Console.WriteLine($"{product.Name}: {product.Price}원 (수량: {product.Quantity})");
//11
Circle circle = new Circle();
circle.Radius = 5;
Console.WriteLine($"반지름: {circle.Radius}, 넓이: {circle.Area:f2}");
//12
Monster monster1 = new Monster();
monster1.Name = "고블린";
monster1.Health = 50;

Monster monster2 = new Monster
{
    Name = "오크",
    Health = 100
};

monster1.Attack();
monster2.Attack();

//13
Character character = new Character
{
    Name = "용사",
    Level = 10,
    job = "전사"
};
Console.WriteLine($"{character.Name} - Lv.{character.Level} {character.job}");
//14
Random random = new Random();

Console.WriteLine($"임의의 정수: {random.Next()}");
Console.WriteLine($"0 ~ 4: {random.Next(5)}");
Console.WriteLine($"1 ~ 9: {random.Next(10)}");
Console.WriteLine($"0.0 ~ 1.0: {random.NextDouble():f4}");

//15

Console.WriteLine("주사위를 5번 굴립니다.");
for (int i = 0; i < 5; i++)
{
    int dice = random.Next(1,7);
    Console.WriteLine($"{i+1}번째: {dice}");
}

//16
Person1 alice = new Person1("Alice", 25);
Person1 bob = new Person1("Bob", 30);
alice.SetFriend(bob);
class ClassName
{ 
    public static void MemberName()
    {
        Console.WriteLine("클래스의 멤버가 호출되어 실행됩니다.");
    }
}

class Square
{
    public static string GetName()
    {
        return "정사각형";
    }
}

class MyFirstClass
{
    public static void StaticMehod()
    {
        Console.WriteLine("[1] 정적 메서드");
    }

    public void InstanceMethod()
    {
        Console.WriteLine("[2] 인스턴스 메서드");
    }
}

//4
class Person
{
    public string Name;
    public int age;

    public void Introduce()
    {
        Console.WriteLine($"안녕하세요 {Name}입니다. {age}살입니다. ");
    }
}

//5
class Point
{
    public int X;
    public int Y;
}

//6
struct PointStruct
{
    public int X;
    public int Y;
}

//7
class PointClass
{
    public int X;
    public int Y;
}

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Multiply(int a, int b) => a * b;

}

//8
class Player
{
    private string _name;
    private int _health;

    public Player()
    {
        _name = "Unknown";
        _health = 100;
    }

    public Player(string name, int health)
    {
        _name = name;
        _health = health;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"이름: {_name}, 체력: {_health}");   
    }
}

//9
class Stock
{
    private decimal _CurrentPrice;

    public decimal CurrentPrice
    {
        get { return _CurrentPrice; }
        set { _CurrentPrice = value; }
    }    
}

//10
class Product
{ 
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; } = 1;
}

//11
class Circle
{
    public double Radius { get; set; }
    public double Area => Math.PI * Radius * Radius;
}

//12
class Monster
{
    public string Name;
    public int Health;

    public void Attack()
    {
        Console.WriteLine($"{Name}이(가) 공격합니다!");
    }
}

//13
class Character
{
    public string Name { get; set; }
    public int Level{ get; set; }
    public string job{ get; set; }
}

//16
class Person1
{
    private string _Name;
    private int _age;

    public Person1(string Name, int age)
    {
        this._Name = Name;
        this._age = age;
    }

    public void SetFriend(Person1 friend)
    {
        friend.PrintFriendInfo(this);
    }
    public void PrintFriendInfo(Person1 person)
    {
        Console.WriteLine($"{_Name}의 친구는 {person._Name}입니다.");
    }
}
