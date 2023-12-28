using System;
using System.Linq;
using System.Collections.Generic;
using PlayerClass;
using EnemyClass;

namespace MagiasClass
{

	public interface  IMagias 
	{         
 		 void usarMagia(Player player);
		  void usarMagia(Player player, Enemy enemy)
		  {
		  	//
		  }
	 
	 	
	 
	}
    // lembrar do problema da sobrecarga.
	 // como usar potion fora de batalha? sem Enemy
	 // um  q tem apenas Player e ou com Player e Enemy
	 // como fazer isso funcionsr?
	public class FireBall : IMagias
	{
		public void usarMagia(Player player)
		{
			Console.WriteLine("pao");
		}
	}
};