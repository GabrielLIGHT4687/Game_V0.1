using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using PlayerClass;



namespace SaveClass;

public class Save
{         
     public Player playerSave;
	  public int IdSave = 1;
	  public int indexGameSave = 0;
	  public string nameSave = "VOID";
	  //dividir as areas por numeros, se o numero for maior ou igual ela ta liberada
	  public int areaMaxOpen =1;
	  
	  
	  //SAVE RECEBER UM OBJETO DE GAME? QUAL VALE MAIS A PENA? UM OBJETO DO TIPO GAME NAO SERIA MAIS PESADO DO QUE AS PROPRIEDADES SEPARADAS?
	  //AVALIAR SE VALE MAIS A PENA***
	  //em praticidade um objeto pouparia inumeras atribuicoes
	  public Save(Player player, int Id,int indexGameSave,string nameSave,int areMaxOpen)
	  {
	  	this.playerSave = player;
		  this.IdSave = Id;
		  this.indexGameSave = indexGameSave;
		  this.nameSave = nameSave;
		  this.areaMaxOpen = areaMaxOpen;
	  }
	  
	  public Save()
	  {
	  	//para a serial8zacao
	  }
	  
	  
}

public class SavesVerify
{
	 
	 
	 public static List<Save> savesList = new List<Save>{new Save(new Player(),1,0,"VOID1",1),new Save(new Player(),2,1,"VOID2",1),new Save(new Player(),3,2,"VOID3",1)};
 	public static void SaveVerify()
	 {
	 	
	  	 
		 XmlSerializer serializer = new XmlSerializer(typeof(List<Save>));
	 	string caminhoDiretorio = "../GameRPG";
	 	string caminhoArquivo = Path.Combine(caminhoDiretorio, "Save.xml");
		 if(File.Exists(caminhoArquivo))
		 {	
			  using (FileStream stream = new FileStream(caminhoArquivo, FileMode.Open))
			  {
   				SavesVerify.savesList = (List<Save>)serializer.Deserialize(stream);
			  }
				
		 }
		 else{
		 	
			 Directory.CreateDirectory(caminhoDiretorio);
			 
			 using (FileStream stream = new FileStream(caminhoArquivo, FileMode.Create))
			 {
             // Código de serialização aqui
	 			serializer.Serialize(stream, savesList);
		 	}
		 }

	  }
	  
	  public static void NewSave(int id,int indexGameSave, string name,int areaMaxOpen, Player player)
	  {	
			  if(id >0 && id < 4)
			  {
		     	Save saveAtual = new Save(player,id,indexGameSave,name,areaMaxOpen);
			 
			  	savesList.RemoveAt(indexGameSave);
			  	savesList.Insert(indexGameSave, saveAtual);
			  }
		}
		public static void Saved()
		{
			
			XmlSerializer serializer = new XmlSerializer(typeof(List<Save>));
	 	  string caminhoDiretorio = "../GameRPG";
	 	  string caminhoArquivo = Path.Combine(caminhoDiretorio, "Save.xml");

			using (FileStream stream = new FileStream(caminhoArquivo, FileMode.Create))
			 {
             // Código de serialização aqui
	 			serializer.Serialize(stream, savesList);
		 	}
		
		}
		
}
