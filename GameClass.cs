using System;
using System.Linq;
using ArmaClass;






namespace GameClass;

class Game
{
	
	public Game()
	{
		ArmasDB.DBVerify();
	}
	public void NewGame()
	{
		Console.WriteLine(" chamou newNew");
		// fazer alguma forma de save kkk sei la como
		GameContinue();
	}
	
	public void GameContinue()
	{
		Console.WriteLine("chamou continue");
	}
	
}
