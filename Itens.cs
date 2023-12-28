using System;
using System.Linq;
using System.Collections.Generic;

namespace ItensClass;

	public class Itens 
	{
		public double vida;
		public double mana;
		public double defesa;
		public double DefesaMagica;
	   public double dano;
		public double danoMagico;
		public double chanceCritico;
		public double agilidade;
		
		
		public string name;
		public enum Elementos
		{
			NonMage,
			Fogo,
			Agua,
			Terra,
			Ar,
			Luz,
			Sombra
		};
		
		public  Elementos elemento = Elementos.NonMage;
      
      public static double[,] elementsInter = new double[5,5]
		{
			
		//bases sempre entre 0.0 e 10.0. nunca passar da primeira dezena, pra nao complicar
		 //nonM  fogo agua terra  ar
			{0.0, 0.0, 0.0, 0.0, 0.0},//nonMage
			{2.0, 1.0, 0.5, 2.0, 1.0}, // Fogo
     	 {2.0, 2.0, 1.0, 0.5, 1.0}, // Agua
   	   {2.0, 0.5, 2.0, 1.0, 1.0}, // Terra
    	  {2.0, 1.0, 1.0, 1.0, 1.0} // Ar
      };
	
    }    
        

