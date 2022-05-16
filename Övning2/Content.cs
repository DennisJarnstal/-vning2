using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2
{
    internal class Content
    {
        //GENERAL DATA TYPES
        string subMenuInputText;
        string choiceSubMenu;
        int result;
        int youthPrice = 80;
        int seniorPrice = 90;
        int generalPrice = 120;

        //MAINMENU
        public string subMenuInput(string input)
        {
           subMenuInputText = input;
            return subMenuInputText;
        }
        public void mainMenu()
        {
            Console.WriteLine("Välkommen till huvudmenyn " +
                              "\n--------------------------------" +
                              "\n Gör ditt val genom att skriva in en siffra och klicka Enter" +
                              "\n\n 1. Ange ålder på besökaren." + 
                              "\n 2. Boka besök för sällskap." + 
                              "\n 3. Repetera text du skriver 10 gånger."+
                              "\n 4. Hämta ut tredje ordet i en mening du skriver.");
                            

        }
        //SUBMENU CHOICE INPUT AND NULL CHECK
        public void subMenuChoices()
        {
            

            bool inputSubChoice = false;
            while (inputSubChoice == false)
            {
            Console.WriteLine($"Vänligen ange {subMenuInputText}:");
            choiceSubMenu = Console.ReadLine()!;

            bool emptySub = string.IsNullOrEmpty(choiceSubMenu);

                if (emptySub == true)
                {
                    Console.WriteLine($"{subMenuInputText} angavs ej, vänligen försök igen");
                }
                else
                {
                    inputSubChoice = true;
                }
            }
        }
        //CASE INTERACTIONS SUBMENU

        //CASE 1
        public void case1()
        {
            bool isNumber = int.TryParse(choiceSubMenu, out _);

            if (isNumber == false) { Console.WriteLine("Felaktig input, försök igen!"); subMenuChoices(); case1(); }
            else { result = Convert.ToInt32(choiceSubMenu); }

            if (result < 5 || result > 100) { Console.WriteLine($"Gratis inträde"); }
            else if (result < 20) { Console.WriteLine($"Ungdomspris: {youthPrice}kr"); }
            else if (result > 64) { Console.WriteLine($"Pensionärspris: {seniorPrice}kr");}
            else { Console.WriteLine($"Standardpris: {generalPrice}"); }

            Console.WriteLine("\nVänligen gå till kassan för att betala, klicka Enter för att komma åter till Huvudmenyn!");
            Console.ReadLine();
            Console.Clear();
        }
        //CASE 2
        public void case2()
        {
            bool isNumber = int.TryParse(choiceSubMenu, out _);
            int writeAge = 0;
            int totalPrice = 0;
            int currentPerson = 1;

            if (isNumber == false) { Console.WriteLine("Felaktig input, försök igen!"); subMenuChoices(); case2(); }
            else { 
            int numberOfPeople = Convert.ToInt32(choiceSubMenu);



                while (currentPerson < numberOfPeople)
                {
                    
                    Console.WriteLine($"Nuvarande pris: {totalPrice}kr");
                    Console.WriteLine($"Vänligen skriv in ålder på {currentPerson} av {numberOfPeople}");

                    string intTextTrue = Console.ReadLine();
                    bool isNumberSecondInput = int.TryParse(intTextTrue, out _);

                    while (isNumberSecondInput == false) { Console.WriteLine("Felaktig input, försök igen!"); intTextTrue = Console.ReadLine(); isNumberSecondInput = int.TryParse(intTextTrue, out _); }

                    writeAge = Convert.ToInt32(intTextTrue);

                    if (writeAge < 5 || writeAge > 100) { totalPrice = totalPrice + 0; currentPerson++; }
                    else if (writeAge < 20) { totalPrice = totalPrice + youthPrice; currentPerson++; }
                    else if (writeAge > 64) { totalPrice = totalPrice + seniorPrice; currentPerson++; }
                    else { totalPrice = totalPrice + generalPrice; currentPerson++; }
                }
            }
            Console.WriteLine($"Tack för din bokning, totalt pris blir {totalPrice}kr, vänligen betala i kassan.\n\nTryck Enter för att återgå till huvudmenyn!");
            Console.ReadLine();
            Console.Clear();
        }
        //CASE 3
        public void case3()
        {
            for(int textInput = 1; textInput < 11; textInput++)
            { Console.Write($"{textInput}. {choiceSubMenu}, "); }
            Console.WriteLine("\n\nHär är det du skrev 10 gånger, klicka Enter för att återgå till huvudmeny");
            Console.ReadLine();
            Console.Clear();
        }
        //CASE 4
        public void case4()
        {
            string[] wordsInText = choiceSubMenu.Split(' ');
            int amountOfWOrds = choiceSubMenu.Split(' ').Length;

            if (amountOfWOrds < 3)
            {
                Console.WriteLine("Du måste ange en mening med minst tre ord i, vänligen försök igen.");
                subMenuChoices();
                case4();
            }
            else
            {
                Console.WriteLine("Här är det 3:e ordet i meningen du skrev. Klicka Enter för att återgå till huvudmenyn!");
                Console.WriteLine(wordsInText[2]);
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}

