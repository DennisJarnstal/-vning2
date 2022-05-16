using Övning2;

bool exitChoice = false;
Content main = new Content();

while (exitChoice == false) {

    main.mainMenu();
    string mainMenuChoices = Console.ReadLine()!;

    switch (mainMenuChoices)
        {
            case "0":
                exitChoice = true;
                Environment.Exit(0);
                break;
            case "1":
            Console.Clear();
            main.subMenuInput("ålder");
            main.subMenuChoices();
            main.case1();
            break;
        case "2":
            Console.Clear();
            main.subMenuInput("antal besökare");
            main.subMenuChoices();
            main.case2();
            break;
        case "3":
            Console.Clear();
            main.subMenuInput("den text du vill ska repeteras 10 gånger");
            main.subMenuChoices();
            main.case3();
            break;
        case "4":
            Console.Clear();
            main.subMenuInput("den text du vill ska hämtas ut tredje ifrån");
            main.subMenuChoices();
            main.case4();
            break;

        default:
                Console.WriteLine("Felaktig input:\n\nVänligen gör ett val enligt huvudmenyn\n");
                break;
        }
    }
