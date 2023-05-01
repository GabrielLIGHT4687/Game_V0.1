using System;
using System.Linq;
using ArmaClass;






namespace GameClass;

class Game
{
	
	// game tem as propriedades de Player, de coisas da run esolida e etc
   // propriedade Id para se referir ao save
		
	
	
	public Game()
	{
		
		//verificacoes contra erros, e ATUALIZACOES.
		
		ArmasDB.DBVerify();
	   //ArmasDB.DBVerify();
		//EnemyDB.DBVerify();
	}
	public void NewGame()
	{
		//LEMBRAR de verificar se a lista de saves ja esta completa
		
		Console.WriteLine(" chamou newNew");
		// fazer alguma forma de save kkk sei la como
		GameContinue();
	}
	
	//vai ter um parameteo enum, para escolher 1,2 ou 3, os saves
	public void GameContinue()
	{
		Console.WriteLine("chamou continue");
		
		//carregar o save fazendo as propriedades do save passar para a instancia atual de game
		//carregar um objeto Player
		//
	}
	
	//passar o objeto atual de game
	//verificar a propriedade Id, para saber o slot certo do save
	public void GameSave()
	{
		// salvar game na lista de save
	}
	
	
	
}
