



using System;
using System.Linq;
using System.Collections.Generic;
using ItensClass;
using System.IO;
using System.Xml.Serialization;


namespace ArmaduraClass;

public class Armadura : Itens
{
	   public double defesa{get;set;}
		public double defesaMagica{get;set;} 
		public double chanceEsquiva{get;set;}   
      
		
		public Armadura(string name, double vida, double mana, double dano, double danoMagico, double defesa, double defesaMagica,double chanceCritico, double agilidade, Elementos elemento)
		{
			this.name = name;
			this.defesa = defesa;
			this.defesaMagica = defesaMagica;
			this. chanceEsquiva = chanceEsquiva;
			this.elemento = elemento;
			
		}
		
		public Armadura()
		{
			
		}
		 public class ArmadurasDB
		 {
		 	//mais ou menos o mesmo funcionamento do DB das armas
		 
		 }
		 
		
		  
}
