using System;
using System.Linq;
using GameClass;
using ArmaClass;
using PlayerClass;
//using ArmaClass.ArmasDB;
using SaveClass;


using GameClass;

namespace Prograaaaaam;

public static class Program
{
   public static void Main()
   {
		
		Console.FontSize = 12;
		Game Game = new Game();
      //MAIN é o menu do jogo, inicializa os principais processos
		
		ArmasDB armaDB = new ArmasDB();
		Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
		Player player = new Player();
		Console.WriteLine("fjdlsjs ");
		Console.WriteLine("xjdjsxkdkdkdkdkdkksj");
		
		while(true)
		{
			Console.WriteLine("\n");
			Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
			Console.WriteLine("                      RPG NOME KKK                          \n\n");
			Console.WriteLine("==================");
			Console.WriteLine(" [> (1)NEW GAME <]\n [> (2)CONTINUE <]");
			Console.WriteLine("==================");
			Console.Write("\n >>");
			string navOption = (Console.ReadLine());
			navOption = navOption.ToLower().Replace(" ","");
			
			
			if(navOption == "1" || navOption == "newgame")
			{
				
				Console.Clear();
				Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
				
				//60 caracteres
				Console.WriteLine("============================================================");
				


				Console.WriteLine("{0,33}","NEW GAME");
				Console.WriteLine("=======================================");
				Console.WriteLine("Save(1) "+"{0,20}",SavesVerify.savesList[0]);
				  //  Save(1) {0}\n Save(2) {1}\n Save(3) {2}", SavesVerify.savesList[0], SavesVerify.savesList[1], SavesVerify.savesList[2]);
				Console.WriteLine("=======================================\n\n\n");
				
				Console.Write("Deseja escrever sobre o Save:");
				int idGameSave = Int32.Parse(Console.ReadLine());
				Console.Write("Nome do Save(4 letras):");
				string nameGame = Console.ReadLine();
				
				Game gameNew = new Game(idGameSave,nameGame);
				gameNew.NewGame();
				Game = gameNew;
				
				//int index = Int32.Parse(Console.ReadLine());
				//Console.WriteLine(SavesVerify.savesList[index-1].texto);
				break;
			}
			
			else if(navOption == "2" || navOption == "continue")
			{
				
				Game gameContinue = new Game();
				Console.Write("Carregar o save: ");
				int id = Convert.ToInt32(Console.ReadLine());
				gameContinue.GameContinue(id);
				Game = gameContinue;
				
				break;
			}
			
			else{
				//mensagem de opcao invalida
				// dar um clear.
			
			}
		}
		Console.WriteLine("Nome do save: "+ Game.nameGame);
		
		//Console.WriteLine(SavesVerify.savesList[0].IdSave);
		Console.WriteLine(ArmasDB.ArmasDBList[0].name);
		
		
   }
}
