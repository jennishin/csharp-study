Console.WriteLine("=== Number Guessing Game ===");
Console.WriteLine("1. 게임 시작");
Console.WriteLine("2. 종료");

Console.Write("메뉴를 선택하세요: ");

int menu = int.Parse(Console.ReadLine());

if (menu == 1)
{
    int answer = new Random().Next(1, 101);

    while (true)
    {
        Console.Write("숫자를 입력하세요: ");
        int guess = int.Parse(Console.ReadLine());

        if (guess < answer)
        {
            Console.WriteLine("UP!");
        }
        else if (guess > answer)
        {
            Console.WriteLine("DOWN!");
        }
        else
        {
            Console.WriteLine("정답입니다!");
            break;
        }

    }
}
else if (menu == 2)
{
    Console.WriteLine("게임을 종료합니다.");
}