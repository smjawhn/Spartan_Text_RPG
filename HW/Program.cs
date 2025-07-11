using System;
using System.Reflection.Emit;
using System.Text;


internal class Program
{
    public static string name;
    public static string job;

    public static void Main()
    {
        FirstPage introName = new FirstPage();
        name = introName.IntroName();

        Console.Clear();
        FirstPage introJob = new FirstPage();
        job = introJob.IntroJob();

        Console.Clear();
        FirstPage firstPage = new FirstPage();
        firstPage.mainPage();

    }
}

internal class FirstPage
{   // 이름 선택
    public String IntroName()
    {
        while (true)
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("원하시는 이름을 설정해주세요.");
            Console.WriteLine("");


            string UserName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"입력하신 이름은 {UserName}입니다.");
            Console.WriteLine("");
            Console.WriteLine("1. 저장");
            Console.WriteLine("2. 취소");
            Console.WriteLine("");
            int IntroNswitch = 0;
            while (IntroNswitch == 0)
            {
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                string inputIntroName = Console.ReadLine();
                if (int.TryParse(inputIntroName, out int intinputIntroName))
                {
                    switch (intinputIntroName)
                    {
                        case 1:

                            return UserName;
                        case 2:
                            IntroNswitch = 1;
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("올바른 번호를 입력해주세요.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("올바른 숫자를 입력해주세요.");
                }
            }
        }
    }
    //직업선택
    public string IntroJob()
    {
        while (true)
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("원하시는 직업을 선택해주세요.");
            Console.WriteLine("");
            Console.WriteLine("1. 전사");
            Console.WriteLine("2. 도적");
            Console.WriteLine("");
            while (true)
            {
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                string inputIntroJob = Console.ReadLine();
                if (int.TryParse(inputIntroJob, out int intinputIntroJob))
                {
                    switch (intinputIntroJob)
                    {
                        case 1:
                            string playerJob = "worrior";
                            return playerJob;
                        case 2:
                            playerJob = "Assassin";
                            return playerJob;
                        default:
                            Console.WriteLine("올바른 번호를 입력해주세요.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("올바른 숫자를 입력해주세요.");
                }
            }
        }

    }
    public void mainPage()
    {
        Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
        Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
        Console.WriteLine("");
        Console.WriteLine("1. 상태 보기");
        Console.WriteLine("2. 인벤토리");
        Console.WriteLine("3. 상점");
        Console.WriteLine("");
        Console.WriteLine("원하시는 행동을 입력해주세요.");
        Console.Write(">>    ");
        int BasicStateInput = int.Parse(Console.ReadLine());
        switch (BasicStateInput)
        {
            case 1:
                BasicStatus mystatus = new BasicStatus();
                mystatus.status();
                break;
            case 2:
                BasicStatus myInven = new BasicStatus();
                myInven.Inventory();
                break;
        }
    }
}
internal class BasicStatus
{
    public int level = 01;
    public int AttPower = 10;
    public int DefPower = 5;
    public int health = 100;
    public int haveGold = 1500;


    public void status()
    {

        Console.Clear();

        Console.WriteLine("[상태보기]");
        Console.WriteLine("캐릭터의 정보가 표시됩니다.");
        Console.WriteLine("");
        Console.WriteLine("LV. " + level);
        Console.WriteLine($"{Program.name} ({Program.job})");
        Console.WriteLine("공격력 : " + AttPower);
        Console.WriteLine("방어력 : " + DefPower);
        Console.WriteLine("체 력 : " + health);
        Console.WriteLine("Gold : " + haveGold + " G");
        Console.WriteLine("");
        Console.WriteLine("0. 나가기");
        Console.WriteLine("");
        while (true)
        {
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>    ");
            string statusInput = Console.ReadLine();
            if (int.TryParse(statusInput, out int intstatusInput))
            {
                if (intstatusInput == 0)
                {
                    Console.Clear();
                    FirstPage statusToMainpage = new FirstPage();
                    statusToMainpage.mainPage();// mainPage를 불러옴
                }
                else
                {
                    Console.WriteLine("올바른 숫자를 입력해주세요.");
                }
            }
            else
            {
                Console.WriteLine("올바른 숫자를 입력해주세요.");
            }
        }
    }

    public void Inventory()
    {
        Console.Clear();

        Console.WriteLine("인벤토리");
        Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
        Console.WriteLine("");
        Console.WriteLine("[아이템 목록");
        Console.WriteLine("");
        Console.WriteLine("1. 장착 관리");
        Console.WriteLine("0. 나가기");
        Console.WriteLine("");
        while (true)
        {
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>    ");
            string inventoryInput = Console.ReadLine();
            if (int.TryParse(inventoryInput, out int intinventoryInput))
            {
                switch (intinventoryInput)
                {
                    case 1:
                        equipOption();
                        break;
                    case 0:
                        FirstPage InventoryToMainpage = new FirstPage();
                        InventoryToMainpage.mainPage();
                        break;

                }
            }
        }
    }

    public void equipOption()
    {
        Console.Clear();

        Console.WriteLine("인벤토리");
        Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
        Console.WriteLine("");
        Console.WriteLine("[아이템 목록");
        
    }
    public string[] Hasitem;
    // 클래스같은걸롤 묶은 다음에 배열로아이템 정보를 저장해보면 될까

    public void GoldShop()
    {
        Console.WriteLine("상점");
        Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
        Console.WriteLine("");
        Console.WriteLine("[보유골드]");
        Console.WriteLine($"{haveGold} G");
        Console.WriteLine("");
        Console.WriteLine("[아이템 목록]");
    }

    public void ItemsinShop()
    {
        List<int> items = new List<int>();
    }
    public class Item
    {
        public string iName { get; set; }
        public string iDescription { get; set; }
        public string iEffect { get; set; }
        public int iPrice { get; set; }
        public bool iIsPurchased { get; set; } = false;
    }
    public List<Item> shopItems = new List<Item>()
    {
        new Item {iName = "수련자 갑옷", iEffect = "방어력 +5", iDescription = "수련에 도움을 주는 갑옷입니다.", iPrice = 1000, iIsPurchased = false },
        new Item {iName = "무쇠 갑옷", iEffect = "방어력 +5", iDescription = "무쇠로 만들어져 튼튼한 갑옷입니다.", iPrice = 2300, iIsPurchased = false },
        new Item {iName = "스파르타의 갑옷", iEffect = "방어력 +15", iDescription = "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", iPrice = 3500, iIsPurchased = false },
        new Item {iName = "낡은 검", iEffect = "공격력 +2", iDescription = "쉽게 볼 수 있는 낡은 검 입니다.", iPrice = 600, iIsPurchased = false },
        new Item {iName = "청동 도끼", iEffect = "공격력 +5", iDescription = "어디선가 사용됐던거 같은 도끼입니다.", iPrice = 1500, iIsPurchased = false },
        new Item {iName = "스파르타의 창", iEffect = "공격력 +7", iDescription = "스파르타의 전사들이 사용했다는 전설의 창입니다.", iPrice = 3200, iIsPurchased = false }
    };
}