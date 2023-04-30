using System;
using System.Linq;
using System.Collections.Generic;
using ItensClass;



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
	
	
	}


	


	public class ArmasDB 
	{
	
	   public static void DBVerify()
		{
			if(1==2)
			{
				// 1==2 é so pra preencher, vai ser ma verificacao se o arquivo existe
				//se o arquivo ja existir
				//apenas continua, verificacao completa
				Console.WriteLine("arquivo de arma deu bom");
			}
			else{
				//criar um novo arquivo:
			
			
		
				List<Arma> armas = new List<Arma>();
	
			   Arma espadaSolar = new Arma("espada solar",2.5,2.3,5.4,4.4,Itens.Elementos.Luz);
			//	Arma outra1 = new Arma(2.3,2.9);
			//	Arma outra2 = new Arma(2.2,2.4);
				// ...
		
	   		armas.Add(espadaSolar);
			//	armas.Add(outra1);
				//armas.Add(outra2);
				
				Console.WriteLine("DEBUG: teste se as armas estao sendo criadas e seus valores atribuidos:\n Nome: {0}\n Ataque: {1}\n Elemento: {2}",espadaSolar.name, espadaSolar.ataque, espadaSolar.elemento);   
	 		}
       
	//espadaSolar.ataque = 0.6;
	//armas.Add(espadaSolar);     
	 
       
 
	}
}