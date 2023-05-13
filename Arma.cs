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
		public double ataque = 4.6;
		public double ataqueMagico = 0.0;
		public double chanceCritico = 0.3;
		public double defesa = 0.7;
		//public Elementos elemento = Elementos.NonMage;
	
	
	   public Arma(string name,double ataque,double ataqueMagico,double chanceCritico,double defesa,Elementos elemento)
		{
			this.name = name;
			this.ataque = ataque;
			this.ataqueMagico = ataqueMagico;
			this.chanceCritico = chanceCritico;
			this.defesa = defesa;
			this.elemento = elemento;
			
		
		}
		
		public Arma()
		{
			//nessesario para a serializacao
			// metodo que atribui, assim como no abandoned, mas relacionado a listaDB
			
		}
	
	
	}


	


	public class ArmasDB 
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
}