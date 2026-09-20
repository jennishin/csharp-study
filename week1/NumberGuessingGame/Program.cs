ShowMenu();

int menu = int.Parse(Console.ReadLine());

if (menu == 1)
{
    PlayGame();
}
else if (menu == 2)
{
    Console.WriteLine("게임을 종료합니다.");
}

static void ShowMenu()
{
    Console.WriteLine("=== Number Guessing Game ===");
    Console.WriteLine("1. 게임 시작");
    Console.WriteLine("2. 종료");

    Console.Write("메뉴를 선택하세요: ");
}

static void PlayGame()
{
    while (true)
    {
        int answer = new Random().Next(1, 101);
        int count = 0;

        while (true)
        {
            Console.Write("숫자를 입력하세요: ");
            int guess = int.Parse(Console.ReadLine());
            count++;

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
                Console.WriteLine($"시도 횟수: {count}");
                break;
            }

        }

        Console.Write("게임을 다시 시작하시겠습니까? (Y/N): ");
        string restart = Console.ReadLine();
        if (restart.ToUpper() != "Y")
        {
            break;
        }
    }
}