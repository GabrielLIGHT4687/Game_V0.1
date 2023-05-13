
using System;
using System.Linq;
using ArmaClass;
using PlayerClass;
using SaveClass;






namespace GameClass;

class Game
{

	public Player playerGame;
	public int IdGame = 1;
	public int IndexSaveGame = 0;
	public string nameGame="PADRAO";
	public int areaMaxOpen = 1;
		
	
	public Game(int IdGame, string nameGame)
	{
		if(IdGame > 0 && IdGame < 4)
		{
		 	this.IdGame = IdGame;
			 this.IndexSaveGame = IdGame-1;
		}
		
		//fazer verificacao e filtro da string
		this.nameGame = nameGame;
		
		this.playerGame = new Player();
		this.areaMaxOpen = 1;
			
		SavesVerify.SaveVerify();
		ArmasDB.DBVerify();
		//EnemyDB.DBVerify();
	}
	public  Game()
   {
		// construtor sem parametros para o continue rodar
		
		//igualar as verificacoes entre o newgame
		SavesVerify.SaveVerify();
		ArmasDB.DBVerify();
		
	}

	
	public void NewGame()
	{
		
		SavesVerify.NewSave(this.IdGame,this.IndexSaveGame, this.nameGame,this.areaMaxOpen,this.playerGame);
		
		Console.WriteLine(" chamou newGame");
		
		GameSave();
		GameContinue(this.IdGame);
		
	}
	
	//vai ter um parameteo enum, para escolher 1,2 ou 3, os saves
	public void GameContinue(int Idgame)
	{
		Console.WriteLine("chamou continue");
		
		if(Idgame > 0 && Idgame <4)
		{
			this.IndexSaveGame = Idgame-1; 
			Save SaveAtual = SaveClass.SavesVerify.savesList[this.IndexSaveGame];
		
			this.nameGame = SaveAtual.nameSave;
			this.playerGame = SaveAtual.playerSave;
			this.IdGame = SaveAtual.IdSave;
			this.areaMaxOpen = SaveAtual.areaMaxOpen;
		
		}
		else{
			//deu ruim, talvez fazer retornar false ou true
		}
		
	}
	
	public void GameSave()
	{
		
		SavesVerify.Saved();
		//Save save = lista...[IdSave];
		// salvar game na lista de save
		//salvar apenas na parte atual da lista, exemplo, entrou no 3, salva no 3.
	}
	
	
	
}
