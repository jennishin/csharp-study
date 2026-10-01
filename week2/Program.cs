using System;
using System.Collections.Generic;

class Player
{
    public string name;
    public int hp;
    public int attackPower;

    public Player(string name)
    {
        this.name = name;
        hp = 100;
        attackPower = 15;
    }

    public void Attack(Enemy enemy)
    {
        enemy.hp -= attackPower;

        if (enemy.hp < 0)
        {
            enemy.hp = 0;
        }

        Console.WriteLine($"{name}의 공격!");
        Console.WriteLine($"{enemy.name}에게 {attackPower}의 데미지!");
        Console.WriteLine();
        Console.WriteLine($"{enemy.name}의 HP : {enemy.hp}");
    }
}

class Enemy
{
    public string name;
    public int hp;
    public int attackPower;

    public Enemy(string name, int hp, int attackPower)
    {
        this.name = name;
        this.hp = hp;
        this.attackPower = attackPower;
    }

    public void Attack(Player player)
    {
        player.hp -= attackPower;

        if (player.hp < 0)
        {
            player.hp = 0;
        }

        Console.WriteLine($"{name}의 공격!");
        Console.WriteLine($"{player.name}에게 {attackPower}의 데미지!");
        Console.WriteLine();
        Console.WriteLine($"{player.name}의 HP : {player.hp}");
        Console.WriteLine();
    }
}

class Game
{
    public static void ShowStatus(Player player, Enemy enemy)
    {
        Console.WriteLine();
        Console.WriteLine($"{player.name} hp : {player.hp}");
        Console.WriteLine($"{enemy.name} hp : {enemy.hp}");
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("=== Text RPG ===");

        Console.Write("플레이어 이름을 입력하세요 : ");
        string name = Console.ReadLine();

        Player player = new Player(name);

        List<Enemy> enemies = new List<Enemy>()
        {
            new Enemy("슬라임", 50, 5),
            new Enemy("최연수", 120, 8),
            new Enemy("롯데", 150, 10)
        };

        Random random = new Random();
        int index = random.Next(enemies.Count);

        Enemy enemy = enemies[index];

        Console.WriteLine();
        Console.WriteLine($"야생의 {enemy.name}이 나타났습니다!");

        ShowStatus(player, enemy);

        while (true)
        {
            Console.WriteLine("메뉴를 선택해주세요");
            Console.WriteLine("1. 공격");
            Console.WriteLine("2. 상태 확인");
            Console.WriteLine("3. 게임 종료");
            Console.WriteLine();

            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine();

                player.Attack(enemy);

                if (enemy.hp <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{enemy.name}을 쓰러뜨렸습니다!");
                    break;
                }

                Console.WriteLine();

                enemy.Attack(player);

                if (player.hp <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{player.name}이 쓰러졌습니다!");
                    break;
                }
            }
            else if (input == "2")
            {
                ShowStatus(player, enemy);
            }
            else if (input == "3")
            {
                Console.WriteLine("종료");
                break;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("잘못된 입력입니다.");
            }
        }
    }
}