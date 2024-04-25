// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
// 오른쪽 벽면 삭제할지말지

// 챕터 0. 마을

// 초기 기본 스텟

int power = 10;
int defense = 5;
int hp = 100;
int gold = 1500;

while (true)
{
    // 시작

    Console.WriteLine(" ──────────────────────────────────────────────────────");
    Console.WriteLine("│ 마을에 온것을 환영하네.                              │");
    Console.WriteLine("│ ※ 이곳에선 던전에 들어가기 전 활동을 할 수 있습니다.│");
    Console.WriteLine("│                                                      │");

    Console.WriteLine("│ 1. 상태 보기                                         │");
    Console.WriteLine("│ 2. 인벤토리                                          │");
    Console.WriteLine("│ 3. 상점                                              │");
    Console.WriteLine("│                                                      │");

    Console.WriteLine("│ 원하는 행동을 선택해주세요.                          │");
    Console.WriteLine("│ >>                                                   │");
    Console.WriteLine(" ──────────────────────────────────────────────────────");

    int action = int.Parse(Console.ReadLine());
    Console.Clear();



    //캐릭터 정보 출력하기 
    //장비 장착 시 기본 스텟 상승시키기

    if (action == 1)
    {
        Console.WriteLine(" ──────────────────────────────────────────────────────");
        Console.WriteLine("│ 상태보기                                             │");
        Console.WriteLine("│ 캐릭터의 정보를 표시합니다                           │");
        Console.WriteLine("│                                                      │");

        Console.WriteLine("│ LV. 01                                               │");
        Console.WriteLine("│ 공격력 : " + power+ "                                          │");
        Console.WriteLine("│ 방어력 : " + defense+ "                                           │");
        Console.WriteLine("│ 체력   : " + hp + "                                         │");
        Console.WriteLine("│ 소지금 : " + gold + " G                                      │");

        Console.WriteLine("│                                                      │");
        Console.WriteLine("│ 0. 나가기                                            │");

        Console.WriteLine("│                                                      │");
        Console.WriteLine("│ 원하시는 행동을 해주세요.                            │");
        Console.WriteLine("│ >>                                                   │");
        Console.WriteLine(" ──────────────────────────────────────────────────────");

        Console.ReadLine();

        Console.Clear();
    }

    // 인벤토리 내용보기

    else if (action == 2)
    {
        Console.WriteLine(" ──────────────────────────────────────────────────────");
        Console.WriteLine("│ 인벤토리                                             │");
        Console.WriteLine("│ 보유 중인 아이템을 관리할 수 있습니다.               │");

        Console.WriteLine("│                                                      │");
        Console.WriteLine("│ [아이템 목록]                                        │");

        Console.WriteLine("│                                                      │");
        Console.WriteLine("│ 1. 장착 관리                                         │");
        Console.WriteLine("│ 0. 나가기                                            │");

        Console.WriteLine("│                                                      │");
        Console.WriteLine("│ 원하시는 행동을 해주세요.                            │");
        Console.WriteLine("│ >>                                                   │");
        Console.WriteLine(" ──────────────────────────────────────────────────────");

        Console.ReadLine();

        Console.Clear();
    }

    //상점 내용 보기

    else if (action == 3)
    {
        Console.WriteLine("〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓");
        Console.WriteLine("상점");
        Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");

        Console.WriteLine();
        Console.WriteLine("[보유골드]");
        Console.WriteLine(gold + " G");

        Console.WriteLine();
        Console.WriteLine("[아이템목록]");

        Console.WriteLine("- 수련자 갑옷    | 방어력 +5  | 수련에 도움을 주는 갑옷입니다.                   |  1000 G");
        Console.WriteLine("- 무쇠갑옷       | 방어력 +9  | 무쇠로 만들어져 튼튼한 갑옷입니다.               |  1800 G");
        Console.WriteLine("- 스파르타의 갑옷| 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.|  3500 G");
        Console.WriteLine("- 낡은 검        | 공격력 +2  | 쉽게 볼 수 있는 낡은 검 입니다.                  |  600 G");
        Console.WriteLine("- 청동 도끼      | 공격력 +5  |  어디선가 사용됐던거 같은 도끼입니다.            |  1500 G");
        Console.WriteLine("- 스파르타의 창  | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다.  |  2700 G");

        Console.WriteLine();
        Console.WriteLine("1. 아이템 구매");
        Console.WriteLine("0. 나가기");

        Console.WriteLine();
        Console.WriteLine("원하시는 행동을 해주세요.");
        Console.WriteLine(">>");
        Console.WriteLine("〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓");



        // 아이템 구매 페이지

        int buyAction = int.Parse(Console.ReadLine());

        if (buyAction == 1) // else if 이거 추가해야함
        {
                Console.Clear();
                Console.WriteLine("〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓");
                Console.WriteLine("[아이템목록]");

                Console.WriteLine(1 + " - 수련자 갑옷    | 방어력 +5  | 수련에 도움을 주는 갑옷입니다.                   |  1000 G");
                Console.WriteLine(2 + " - 무쇠갑옷       | 방어력 +9  | 무쇠로 만들어져 튼튼한 갑옷입니다.               |  1500 G");
                Console.WriteLine(3 + " - 스파르타의 갑옷| 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.|  3500 G");
                Console.WriteLine(4 + " - 낡은 검        | 공격력 +2  | 쉽게 볼 수 있는 낡은 검 입니다.                  |  600 G");
                Console.WriteLine(5 + " - 청동 도끼      | 공격력 +5  |  어디선가 사용됐던거 같은 도끼입니다.            |  1500 G");
                Console.WriteLine(6 + " - 스파르타의 창  | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다.  |  2500 G");

                Console.WriteLine();
                Console.WriteLine("1. 아이템 구매");
                Console.WriteLine("0. 나가기");

                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 해주세요.");
                Console.WriteLine(">>");
                Console.WriteLine("〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓");

            int itemNumber = int.Parse(Console.ReadLine()); // 번호입력 후 구매하기

            if (itemNumber <= 6) // 0~6번 고르기
            {
                Console.WriteLine("구매할 아이템 번호를 입력하세요: ");
                int choice = int.Parse(Console.ReadLine());

                BuyItem(choice);
            }
            else if (buyAction == 0)
            {
                 // 0. 나가기
            }

            else
            {
                Console.WriteLine("숫자를 알맞게 입력해주세요."); // 0~6을 제외한 다른 번호 누르기
            }


            // 아이템 구매
            void BuyItem(int choice)
            {

                int ItemPrice = 0;

                switch (choice) // 상점가
                {
                    case 1: ItemPrice = 1000; break;
                    case 2: ItemPrice = 1500; break;
                    case 3: ItemPrice = 3500; break;
                    case 4: ItemPrice = 600; break;
                    case 5: ItemPrice = 1500; break;
                    case 6: ItemPrice = 2500; break;
                    default: Console.WriteLine("잘못된 선택입니다."); break; // 1~6번을 선택하지 않을시
                }

                if (gold >= ItemPrice) // 상점 구매가능 여부 확인 골드가 아이템가격보다 많아야 살수 있으니
                {
                    gold -= ItemPrice; // 현재 골드에서 아이템 가격을 뺀다

                    Console.WriteLine("구매에 성공했습니다!");
                    Console.WriteLine("남은 골드: " + gold + "G");
                }
                else
                {
                    Console.WriteLine("골드가 부족합니다. 구매에 실패했습니다.");

                }

            }
            Console.WriteLine();
            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("0. 나가기");

            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 해주세요.");
            Console.WriteLine(">>");


            Console.ReadLine();

            Console.Clear();

        }
    }
    
    else
    {
        Console.WriteLine("1~3에서 다시 선택해주세요");
        Console.WriteLine();
    }
}





