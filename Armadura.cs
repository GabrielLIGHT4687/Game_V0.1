using System;
using System.Linq;
using System.Collections.Generic;
using ItensClass;

namespace ArmaduraClass;

public class Armadura : Itens
{
	   public double defesa{get;set;}
		public double defesaMagica{get;set;} 
		public double chanceEsquiva{get;set;}   
      
		
		public Armadura(string name, double defesa, double defesaMagica, double chanceEsquiva, Elementos elemento)
		{
			this.name = name;
			this.defesa = defesa;
			this.defesaMagica = defesaMagica;
			this. chanceEsquiva = chanceEsquiva;
			this.elemento = elemento;
			
		}
		 public class ArmadurasDB
		 {
		 	//mais ou menos o mesmo funcionamento do DB das armas
		 
		 }
		 
		
		  
}
