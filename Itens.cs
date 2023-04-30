using System;
using System.Linq;
using System.Collections.Generic;

namespace ItensClass;

	public class Itens 
	{
		public string name{get;set;}
		public enum Elementos
		{
			NonMage,
			Agua,
			Terra,
			Foto,
			Ar,
			Luz,
			Sombra,
		
		};
		public Elementos elemento = Elementos.NonMage;
	
		
	 
    }     
        

