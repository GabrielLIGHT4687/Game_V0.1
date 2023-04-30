using System;
using System.Linq;
using GameClass;
using ArmaClass;


using GameClass;

namespace Prograaaaaam;

public static class Program
{
   public static void Main()
   {
		
		Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
		
		Console.WriteLine("fjdlsjs ");
		Console.WriteLine("xjdjsxkdkdkdkdkdkksj");
		Game game = new Game();
		
		Console.WriteLine("    ~"+ArmasDB.ArmasDBList[0].name);
		
		
		
		while(true)
		{
			Console.WriteLine("\n\n\n\n\n\n\n");
			Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
			Console.WriteLine("                      RPG NOME KKK                          \n\n");
			Console.WriteLine("==================");
			Console.WriteLine(" [> (1)NEW GAME <]\n [> (2)CONTINUE <]");
			Console.WriteLine("==================");
			Console.Write("\n >>");
			string navOption = (Console.ReadLine());
			navOption = navOption.ToLower().Replace(" ","");
			//navOption = navOption.ToLower();
			
			if(navOption == "1" || navOption == "newgame")
			{
				//Game game = new Game();
				game.NewGame();
				break;
			}
			
			else if(navOption == "2" || navOption == "continue")
			{
				game.GameContinue();
				break;
			}
			
			else{
				//mensagem de opcao invalida
				// dar um clear
			}
			  
			
			//Console.ReadKey();
			//Console.Write("                    CONTINUE < ");
			//Console.ReadLine();
			
			
			
			
		}
		
		Console.WriteLine("\n\n\n\n\n\n Kapkapkapkpa");
	   //ArmaClass.ArmasDB.DBVerify();
		
		//Game game = new Game();
		//game.NewGame();
		
		/*
			Main pode ser o menu e configuracoes, sei la
		*/
		
		// chamar Game()
		// nao sei bem como
		Console.ReadLine();

		
   }
}
