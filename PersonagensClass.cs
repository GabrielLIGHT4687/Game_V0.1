using System;
using System.Linq;
using System.Collections.Generic;
using InventoryClass;
using EnemyClass;
using ItensClass;


namespace PersonagensClass;

public class Personagens
{
	public double vida{get;set;}
	public double mana{get;set;}
	public double defesa{get;set;}
	public double defesaMagica{get;set;} 
	public double dano{get;set;}
	public double danoMagico{get;set;}
	public double chanceCritico{get;set;}
	public double chanceEsquiva{get;set;}
	
   public Inventory inventario = new Inventory();
	
	
	//atack com foco. criar o padrao sem foco e choice
	public (String,Personagens) Atack(int choice, Personagens Enemy)
	{
		
		 Random rand = new Random();
		 int desvio=0;
		 String AtackEstatus;
		 if(Enemy.chanceEsquiva >=0 && Enemy.chanceEsquiva < 100)
		 	desvio = rand.Next((int)Enemy.chanceEsquiva,101);
		 
		 
		 
		 if(desvio == 100)
		 {
		 	//sei la. nada
			 AtackEstatus = "desviado";
		 }
		 else
		 {
			 AtackEstatus="acertivo";
			
		 //int indexEnemyItem = enemy.inventario.itensEquipados.FindIndex(item => item.GetType() == Armadura);
		 	Itens.Elementos enemyElement = Enemy.inventario.itensEquipados[choice-1].elemento;
		 //int idPlayer = inventario.itensEquipados.FindIndex(item => item.GetType() == Arma);
		 	int pElementId = (int)inventario.itensEquipados[0].elemento;
			 int eElementId = (int)Enemy.inventario.itensEquipados[2].elemento;
			 
		 	double baseDeElemento= Itens.elementsInter[pElementId,eElementId];
			 double porcentElement= (dano/100)*(baseDeElemento*10);
		 	
			 //lembrar de alterar o uso do choice. é pra escolher 1.. mas a defesa Back ou Front ser considerada. nao apenas a do item. (tambem mais a defesa absoluta/magica)
			 double finalDamage = (dano + porcentElement + danoMagico)-Enemy.inventario.itensEquipados[choice-1].defesa + Enemy.defesaMagica;
		 
		 	
		 
			 if(finalDamage >0)
		 		Enemy.vida -= finalDamage;
			 else{
			 	AtackEstatus="ineficaz";
			 }
		
			
		
		
	 	}
		 
		 return (AtackEstatus,Enemy);
	/*	if(choice == 1)
		{
			//arma
		}
		else if(choice == 2)
		{
			//armadura
		}
		
		
		
		this.dano */
	}
	         
        
}
