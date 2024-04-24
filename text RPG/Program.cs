// See https://aka.ms/new-console-template for more information

// 챕터 0. 마을




using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;

    while (true)
    {
        // 시작

        Console.WriteLine("마을에 온것을 환영하네.");
        Console.WriteLine("※ 이곳에선 던전에 들어가기 전 활동을 할 수 있습니다.");
        Console.WriteLine();

        Console.WriteLine("1. 상태 보기");
        Console.WriteLine("2. 인벤토리");
        Console.WriteLine("3. 상점");
        Console.WriteLine();

        Console.WriteLine("원하는 행동을 선택해주세요.");
        Console.WriteLine(">> ");

        int action = int.Parse(Console.ReadLine());
        Console.Clear();

        // 초기 기본 스텟

        int power = 10;
        int defense = 5;
        int hp = 100;
        int gold = 1500;

        //캐릭터 정보 출력하기 
        //장비 장착 시 기본 스텟 상승시키기

        if (action == 1)
        {
            Console.WriteLine("상태보기");
            Console.WriteLine("캐릭터의 정보를 표시합니다");
            Console.WriteLine();

            Console.WriteLine("LV. 01");
            Console.WriteLine("공격력 : " + power);
            Console.WriteLine("방어력 : " + defense);
            Console.WriteLine("체력   : " + hp);
            Console.WriteLine("소지금 : " + gold + " G");

            Console.WriteLine();
            Console.WriteLine("0. 나가기");

            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 해주세요.");
            Console.WriteLine(">>");

            Console.ReadLine();

            Console.Clear();
        }

        // 인벤토리 내용보기

        else if (action == 2)
        {
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");

            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
        if (//아이템 0 이하로 설정시 실패창뜨기)
        {
            //아이템이 있을시 번호로 표시
            //장착중이 아니라면 장착가능하게 한 후 [E]표시하기, 장착 해제 시 [E]표시 없애기
        }
        else
        {
            //입력을 다시 해주세요
        }

            Console.WriteLine();
            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");

            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 해주세요.");
            Console.WriteLine(">>");


            Console.ReadLine();

            Console.Clear();
        }

        //상점 내용 보기

        else if (action == 3)
        {
            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");

            Console.WriteLine();
            Console.WriteLine("[보유골드]");
            Console.WriteLine("1500G");

            Console.WriteLine();
            Console.WriteLine("[아이템목록]");
            Console.WriteLine("- 수련자 갑옷    | 방어력 +5  | 수련에 도움을 주는 갑옷입니다.                   |  1000 G");
            Console.WriteLine("- 무쇠갑옷       | 방어력 +9  | 무쇠로 만들어져 튼튼한 갑옷입니다.               |  1500 G");
            Console.WriteLine("- 스파르타의 갑옷| 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.|  3500 G");
            Console.WriteLine("- 낡은 검        | 공격력 +2  | 쉽게 볼 수 있는 낡은 검 입니다.                  |  600 G");
            Console.WriteLine("- 청동 도끼      | 공격력 +5  |  어디선가 사용됐던거 같은 도끼입니다.            |  1500 G");
            Console.WriteLine("- 스파르타의 창  | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다.  |  2500 G");

        // 구매하기
            int itemprice = ItemPrice();

            if(//아이템 0 이하로 설정시 실패창뜨기)
            {
              // 현재 소지금 - 아이템 가격 = +현재 소지금 (구매완료)
              // 현재 소지금 - 아이템 가격 = -현재 소지금 (구매실패)
            }
              else
              {
                 //입력을 다시 해주세요
              }

        // 상점아이템 가격보기

            static int ItemPrice(string ItemName)
            {
                switch (ItemName)
                {
                    case "수련자 갑옷": return 1000;
                    case "무쇠갑옷": return 1500;
                    case "스파르타의 갑옷": return 3500;
                    case "낡은 검": return 600;
                    case "청동 도끼": return 1500;
                    case "스파르타의 창": return 2500;
                    default: return 0;
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
       
        else
        {
            Console.WriteLine("1~3에서 다시 선택해주세요");
            Console.WriteLine();
        }
    }



