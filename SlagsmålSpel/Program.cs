using System;

namespace SlagsmålSpel
{
    class Program
    {
        static void Main(string[] args)
        {

            //Loop making it possible to re-start game.
            while (true)
            {

                //clearing the console when restarting or beginning.
                Console.Clear();

                //setting color for text and ascii art. (reoccuring).
                Console.ForegroundColor = ConsoleColor.Magenta;
                //ascii art using cw(@""); to achive best result when putting in bigger pices of art or a lot of text.
                System.Console.WriteLine(@"
████████▄     ▄████████   ▄▄▄▄███▄▄▄▄    ▄██████▄  ███▄▄▄▄     
███   ▀███   ███    ███ ▄██▀▀▀███▀▀▀██▄ ███    ███ ███▀▀▀██▄   
███    ███   ███    █▀  ███   ███   ███ ███    ███ ███   ███   
███    ███  ▄███▄▄▄     ███   ███   ███ ███    ███ ███   ███       
███    ███ ▀▀███▀▀▀     ███   ███   ███ ███    ███ ███   ███ 
███    ███   ███    █▄  ███   ███   ███ ███    ███ ███   ███        
███   ▄███   ███    ███ ███   ███   ███ ███    ███ ███   ███    
████████▀    ██████████  ▀█   ███   █▀   ▀██████▀   ▀█   █▀   
                                                                        
            ");

                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("Welcome! You're going to fight a demon." +
                " Hero, what is your name?"
                );

                //making it possible to choose main characters name by initializing a string-variable and you writing it yourself.
                string character = Console.ReadLine();

                //using string character in text.
                System.Console.WriteLine("Okey " + character + ", here you have:");

                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("~~~~~~~~~~~~~You~~have~~100hp~~~~~~~~~~~~");

                Console.ForegroundColor = ConsoleColor.White;
                //using a different method of cw with + and \n to make the code prettier, but since i change color a lot, its not possible for the most text.
                System.Console.WriteLine(
                    "You have 2 weapons. A sword and a bow. Choose wisely!\n" +
                    "Now I wish you best of luck.");

                Console.ForegroundColor = ConsoleColor.Yellow;
                //writing press ENTER and using cr together to make it more like a game. afterwards clearing the console and continuing with the story.
                System.Console.WriteLine("Press ENTER to continue.");
                Console.ReadLine();

                Console.Clear();


                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine(@"
              \                  /
    _________))                ((__________
   /.-------./\\    \    /    //\.--------.\
  //#######//##\\   ))  ((   //##\\########\\
 //#######//###((  ((    ))  ))###\\########\\
((#######((#####\\  \\  //  //#####))########))
 \##' `###\######\\  \)(/  //######/####' `##/
  )'    ``#)'  `##\`->oo<-'/##'  `(#''     `(
          (       ``\`..'/''       )
                     \""(
                      `- )
                      / /
                     ( /\
                     /\| \
                    (  \
                        )
                       /
                      (
                      ` 
            ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine("A demon ATTACKS!");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@" 

 █████▒██▓  ▄████  ██░ ██ ▄▄▄█████▓ ▐██▌    
▓██   ▒▓██▒ ██▒ ▀█▒▓██░ ██▒▓  ██▒ ▓▒ ▐██▌    
▒████ ░▒██▒▒██░▄▄▄░▒██▀▀██░▒ ▓██░ ▒░ ▐██▌    
░▓█▒  ░░██░░▓█  ██▓░▓█ ░██ ░ ▓██▓ ░  ▓██▒    
░▒█░   ░██░░▒▓███▀▒░▓█▒░██▓  ▒██▒ ░  ▒▄▄     
 ▒ ░   ░▓   ░▒   ▒  ▒ ░░▒░▒  ▒ ░░    ░▀▀▒    
 ░      ▒ ░  ░   ░  ▒ ░▒░ ░    ░     ░  ░    
 ░ ░    ▒ ░░ ░   ░  ░  ░░ ░  ░          ░    
        ░        ░  ░  ░  ░          ░       
        
        ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine("Press ENTER to continue.");
                Console.ReadLine();

                Console.Clear();

                //initializing both the hp of the characters and also a round count.
                int cHp = 100;
                int dHp = 100;
                int round = 0;

                //creating a loop to make the fight go on until someones dead. (below 0 hp)
                while (cHp > 0 && dHp > 0)
                {

                    round += 1;

                    Console.ForegroundColor = ConsoleColor.White;
                    System.Console.WriteLine("\n\nRound" + round + "___________________________________________________________________________________\n\n"
                    );

                    //showing your hp.
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("~~~~~~~~~~~~~You~~have~~" + cHp + "hp~~~~~~~~~~~~");

                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("~~~~~~~~~~The~~DEMON~~has~~" + dHp + "hp~~~~~~~~~");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    System.Console.WriteLine("You ATTACK!");

                    Console.ForegroundColor = ConsoleColor.White;
                    System.Console.WriteLine("Sword( POWER = 15-20 ) or Bow( POWER 10-25 )?");

                    //initializing a weapon choosing thingy to make you able to choose which weapon to use.
                    string weapon = Console.ReadLine().ToLower();
                    //creating a random generator.
                    Random generator = new Random();
                    //using the now exisiting generator to choose a random number between a bottom number and a top number. (for their power or damage).
                    int sword = generator.Next(15, 20);
                    int bow = generator.Next(10, 25);
                    int demon = generator.Next(5, 30);

                    //if you picked sword, this will happen.
                    if (weapon == "sword")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine(@"
         />_________________________________                                \  /
[########[]_________________________________> . , ; .~~~~X.;' .'~~~ `      O    O 
         \>                                                                   X
                    ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("You stab the Demon.");

                        //using the variables to determine hit damage and total hp after hit.
                        dHp -= sword;

                        //showing total after hit.
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        System.Console.WriteLine("The Demon now has " + dHp + "hp.");

                        cHp -= demon;

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        System.Console.WriteLine("\nThe Demon ATTACKS!");

                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("You loose hp. You now have " + cHp + "hp.");


                    }

                    //if you pick bow.
                    else if (weapon == "bow")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine(@"  
   (
    \
     )
##-------->        
     )
    /
   (
                    ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("You snipe the Demon.");

                        dHp -= bow;

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        System.Console.WriteLine("The Demon now has " + dHp + "hp.");

                        cHp -= demon;

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        System.Console.WriteLine("\nThe Demon ATTACKS!\nYou loose hp. You now have " + cHp + "hp.");
                    }




                }

                //if the demon dies, if you die and if theres a tie.
                if (dHp < 0 || dHp == 0)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.White;
                    System.Console.WriteLine("You tamed the DEMON! I knew you could do it " + character + "!");

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    System.Console.WriteLine(@"
▄▀▄▄▄▄   ▄▀▀▀▀▄   ▄▀▀▄ ▀▄  ▄▀▀▀▀▄    ▄▀▀▄▀▀▀▄  ▄▀▀█▄   ▄▀▀▀█▀▀▄  ▄▀▀▄ ▄▀▀▄  ▄▀▀▀▀▄      ▄▀▀█▄   ▄▀▀▀█▀▀▄  ▄▀▀█▀▄   ▄▀▀▀▀▄   ▄▀▀▄ ▀▄  ▄▀▀▀▀▄ 
█ █    ▌ █      █ █  █ █ █ █         █   █   █ ▐ ▄▀ ▀▄ █    █  ▐ █   █    █ █    █      ▐ ▄▀ ▀▄ █    █  ▐ █   █  █ █      █ █  █ █ █ █ █   ▐ 
▐ █      █      █ ▐  █  ▀█ █    ▀▄▄  ▐  █▀▀█▀    █▄▄▄█ ▐   █     ▐  █    █  ▐    █        █▄▄▄█ ▐   █     ▐   █  ▐ █      █ ▐  █  ▀█    ▀▄   
  █      ▀▄    ▄▀   █   █  █     █ █  ▄▀    █   ▄▀   █    █        █    █       █        ▄▀   █    █          █    ▀▄    ▄▀   █   █  ▀▄   █  
 ▄▀▄▄▄▄▀   ▀▀▀▀   ▄▀   █   ▐▀▄▄▄▄▀ ▐ █     █   █   ▄▀   ▄▀          ▀▄▄▄▄▀    ▄▀▄▄▄▄▄▄▀ █   ▄▀   ▄▀        ▄▀▀▀▀▀▄   ▀▀▀▀   ▄▀   █    █▀▀▀   
█     ▐           █    ▐   ▐         ▐     ▐   ▐   ▐   █                      █         ▐   ▐   █         █       █         █    ▐    ▐      
▐                 ▐                                    ▐                      ▐                 ▐         ▐       ▐         ▐                
               ");




                }

                else if (cHp == 0 || cHp < 0)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.White;
                    System.Console.WriteLine("The Demon won. Better luck next time " + character);

                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine(@"
▀▄    ▄ ████▄   ▄       ██▄   ▄█ ▄███▄   ██▄   
  █  █  █   █    █      █  █  ██ █▀   ▀  █  █  
   ▀█   █   █ █   █     █   █ ██ ██▄▄    █   █ 
   █    ▀████ █   █     █  █  ▐█ █▄   ▄▀ █  █  
 ▄▀           █▄ ▄█     ███▀   ▐ ▀███▀   ███▀  ██
               ▀▀▀       
");



                }

                else if (cHp < 0 || cHp == 0 && dHp < 0 || dHp == 0)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.White;
                    System.Console.WriteLine("Both died sadly.");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    System.Console.WriteLine(@"
▄▄▄▄▄    ▪      ▄▄▄ .   
•██      ██     ▀▄.▀·
 ▐█.▪    ▐█·    ▐▀▀▪▄
 ▐█▌·    ▐█▌    ▐█▄▄▌
 ▀▀▀     ▀▀▀    ▀▀▀   ▀ 
                ");



                }


                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("\nPress ENTER to play again!");

                Console.ReadLine();




            }







        }
    }
}
