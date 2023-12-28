using System;
using System.Linq;
using System.Collections.Generic;
using ItensClass;
using System.IO;
using System.Xml.Serialization;




namespace ArmaClass;

	public class Arma : Itens
	{
		//public string name = "NonName";
		
		//public Elementos elemento = Elementos.NonMage;
	
	
	   public Arma(string name,double vida, double mana, double ataque,double ataqueMagico,double defesa,double defesaMagica,double chanceCritico, double agilidade,Elementos elemento)
		{
			this.name = name;
			this.dano = ataque;
			this.danoMagico = ataqueMagico;
			this.chanceCritico = chanceCritico;
			this.defesa = defesa;
			this.elemento = elemento;
			
			//adicionar uma lista de numeros, referente a habilidsdes q essa arma libera
			// como diferentes tipos de ataques e magias. q serao desbloqueadas no player
			// ou fazer de outro jeito mais eficiente com bools msm
		
		}
		
		public Arma()
		{
			//nessesario para a serializacao
			// metodo que atribui, assim como no abandoned, mas relacionado a listaDB
			
		}
	
	
	}
	
/*	public class ArmasDB 
	{
		public static List<Arma> ArmasDBList = new List<Arma>();
	   public void iniciarArmaDB()
		{
		
	     Arma espadaSolar = new Arma("espada solar",3.5,2.3,5.4,4.4,Itens.Elementos.Luz);
	    
		  ArmasDBList.Add(espadaSolar);
		}
	
	}*/


   public static class ArmasDB 
	{
		public static List<Arma> ArmasDBList = new List<Arma>();
	   public static void iniciarArmaDB()
		{
		             										//	v     m    d   dm   d     dm   cri	ag	
	     Arma espadaSolar = new Arma("espada Solar", 0.0, 0.0, 3.5, 2.3, 4.4, 1.0, 5.4, 0.0, Itens.Elementos.Luz);
	     Arma Sureler = new Arma("espada Sureler", 0.0, 0.0, 3.5, 2.3, 3.3, 7.9, 5.4, 0.0, Itens.Elementos.Luz);
		  Arma Blastus = new Arma("espada Blastus", 0.0, 0.0, 3.5, 2.3, 5.4, 4.4, 1.0, 0.0, Itens.Elementos.Fogo);
		  Arma Nieth = new Arma("espada Nieth", 0.0, 0.0, 3.5, 2.3, 5.4, 4.4, 1.0, 0.0, Itens.Elementos.Sombra);
		  Arma Ethera = new Arma("espada Ethera", 0.0, 0.0, 3.5, 2.3, 5.4, 4.4, 1.0, 0.0, Itens.Elementos.Terra);
		  Arma Furtsh = new Arma("espada Furtsh", 0.0, 0.0, 3.5, 2.3, 5.4, 4.4, 1.0, 0.0, Itens.Elementos.Ar);
		  
		  ArmasDBList.Add(espadaSolar);
		  ArmasDBList.Add(Sureler);
		  ArmasDBList.Add(Blastus);
		  ArmasDBList.Add(Nieth);
		  ArmasDBList.Add(Ethera);
		  ArmasDBList.Add(Furtsh);
		}
	
	}

	


	/*public class ArmasDB 
	
	{
		
		public static List<Arma> ArmasDBList = new List<Arma>();
	
	   public static void DBVerify()
		{
			
			XmlSerializer serializer = new XmlSerializer(typeof(List<Arma>));
			
				
			string caminhoDiretorio = "../GameRPG";
			string caminhoArquivo = Path.Combine(caminhoDiretorio, "ArmasDBList.xml");
			//List<Arma> ArmasDB;
	
			bool VerifySucefullt = false;
			for(int i=0; i<5; i++)
			{
				
				if(VerifySucefullt == true)
				{
				
					
					using (FileStream stream = new FileStream(caminhoArquivo, FileMode.Open))
					{
   					 ArmasDB.ArmasDBList = (List<Arma>)serializer.Deserialize(stream);
					}
				
					
					break;

					//Console.WriteLine("arquivo de arma deu bom");
				}
			
				//criar um novo arquivo:
			
				List<Arma> armasList = new List<Arma>();
			   Arma espadaSolar = new Arma("espada solar",3.5,2.3,5.4,4.4,Itens.Elementos.Luz);
			// Arma outra1 = new Arma(2.3,2.9);
			// Arma outra2 = new Arma(2.2,2.4);
				// ...
				armasList.Add(espadaSolar);
				
				
				Directory.CreateDirectory(caminhoDiretorio);
				using (FileStream stream = new FileStream(caminhoArquivo, FileMode.Create))
				{
                // Código de serialização aqui
	 				serializer.Serialize(stream, armasList);
				}
				
				if(File.Exists(caminhoArquivo))
				{
					//criado ou atualizado sucefull
					VerifySucefullt = true;
						
				}
			//	armas.Add(outra1);
				//armas.Add(outra2);
				
       
 
		   }
	  }
   }*/
