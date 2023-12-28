
using System;
using System.Linq;
using System.Collections.Generic;
using InventoryClass;
using EnemyClass;
using ArmaClass;
using ArmaduraClass;
using ItensClass;
using RunaClass;
using AmuletoClass;

namespace PlayerClass;

public class Player: PersonagensClass.Personagens
{
	
	public void metodoDeControle()
	{
		
	}
	
	
	/*public double vida{get;set;}
	public double mana{get;set;}
	public double defesa{get;set;}
	public double defesaMagica{get;set;} 
	public double dano{get;set;}
	public double danoMagico{get;set;}
	public double chanceCritico{get;set;}
	public double chanceEsquiva{get;set;}
	
   public Inventory inventario = new Inventory();
	
	
	//atack com foco. criar o padrao sem foco e choice
	public (String,Enemy) Atack(int choice, Enemy Enemy)
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
		
		
		
		this.dano 
	}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	public Enemy Atack(Enemy enemy)
	{
	
	   //moldes do tipo q to procurando(de ataque), arma e runa
		List<Itens> tipos = new List<Itens>(){new Arma(),new Runa()};
		
		// molde do tipo q procuro no enemy(q sao os tipos de equipamento de defesa)
		List<Itens> tiposEnemy = new List<Itens>(){new Armadura(), new Amuleto()};
		//algum buff externo, como uma pocao.
		double porcentBuff = 0.0;
		// decidido! usar ainda nos calculos.
		
		
		//RETORNAR DANO COM BUFF? no
		//RETORNAR PORCENTBUFF? no
		//APLICAR? yeee
		
		
		
		
		
		
		//Type tipoo = tipos[0].GetType();
	//	int indexItemEquipado = inventario.itensEquipados.FindIndex(item => item.GetType() == tipos[0].GetType());
		//int indexArmaduraEquipado = inventario.itensEquipados.FindIndex(item => item is Armadura);
	//	int indexRunaEquipado = itensEquipados.FindIndex(item => item is Runa);
	//	int indexAmuletoEquipado = itensEquipados.FindIndex(item => item is Amuleto);
	
		for(int indexGeral =0; indexGeral<2 ; indexGeral++)
		{
			
		//index da arma/runa
		int indexItemEquipado = inventario.itensEquipados.FindIndex(item => item.GetType() == tipos[indexGeral].GetType());
		//index da armadura/amuleto
		int indexEnemyItem = enemy.inventario.itensEquipados.FindIndex(item => item.GetType() == tiposEnemy[indexGeral].GetType());
	   
		if(inventario.itensEquipados[indexItemEquipado].elemento == Itens.Elementos.Ar)
		{
			switch(enemy.inventario.itensEquipados[indexEnemyItem].elemento)
			{
				case Itens.Elementos.Ar:
					//
					break;
				case Itens.Elementos.Luz:
					//
					break;
				case Itens.Elementos.Agua:
					//
					break;
				case Itens.Elementos.Fogo:
					//
					break;
				case Itens.Elementos.Terra:
					//
					break;
				case Itens.Elementos.Sombra:
					//
					break;
				
				//non mage
				
			}
		}
		else if(inventario.itensEquipados[indexItemEquipado].elemento == Itens.Elementos.Luz)
		{
			switch(enemy.inventario.itensEquipados[indexEnemyItem].elemento)
			{
				case Itens.Elementos.Ar:
					//
					break;
				case Itens.Elementos.Luz:
					//
					break;
				case Itens.Elementos.Agua:
					//
					break;
				case Itens.Elementos.Fogo:
					//
					break;
				case Itens.Elementos.Terra:
					//
					break;
				case Itens.Elementos.Sombra:
					//
					break;
				
				//non mage
				
			}
		}
		else if(inventario.itensEquipados[indexItemEquipado].elemento == Itens.Elementos.Agua)
		{
			switch(enemy.inventario.itensEquipados[indexEnemyItem].elemento)
			{
				case Itens.Elementos.Ar:
					//
					break;
				case Itens.Elementos.Luz:
					//
					break;
				case Itens.Elementos.Agua:
					//
					break;
				case Itens.Elementos.Fogo:
					//
					break;
				case Itens.Elementos.Terra:
					//
					break;
				case Itens.Elementos.Sombra:
					//
					break;
				
				//non mage
				
			}
		}
		else if(inventario.itensEquipados[indexItemEquipado].elemento == Itens.Elementos.Fogo)
		{
			switch(enemy.inventario.itensEquipados[indexEnemyItem].elemento)
			{
				case Itens.Elementos.Ar:
					//
					break;
				case Itens.Elementos.Luz:
					//
					break;
				case Itens.Elementos.Agua:
					//
					break;
				case Itens.Elementos.Fogo:
					//
					break;
				case Itens.Elementos.Terra:
					//
					break;
				case Itens.Elementos.Sombra:
					//
					break;
				
				//non mage
				
			}
		}
		else if(inventario.itensEquipados[indexItemEquipado].elemento == Itens.Elementos.Terra)
		{
			switch(enemy.inventario.itensEquipados[indexEnemyItem].elemento)
			{
				case Itens.Elementos.Ar:
					//
					break;
				case Itens.Elementos.Luz:
					//
					break;
				case Itens.Elementos.Agua:
					//
					break;
				case Itens.Elementos.Fogo:
					//
					break;
				case Itens.Elementos.Terra:
					//
					break;
				case Itens.Elementos.Sombra:
					//
					break;
				
				//non mage
				
			}
		}
		else if(inventario.itensEquipados[indexItemEquipado].elemento == Itens.Elementos.Sombra)
		{
			switch(enemy.inventario.itensEquipados[indexEnemyItem].elemento)
			{
				case Itens.Elementos.Ar:
					//
					break;
				case Itens.Elementos.Luz:
					//
					break;
				case Itens.Elementos.Agua:
					//
					break;
				case Itens.Elementos.Fogo:
					//
					break;
				case Itens.Elementos.Terra:
					//
					break;
				case Itens.Elementos.Sombra:
					//
					break;
				
				//non mage
				
				
			}
		}
		
		
		
		
		}
		
		//Fazer a conversao certinha
		//this.dano*porcentBuff;
		//return?
		
		
		
		
		
		
		/*if(inventario.itensEquipados[indexArmaEquipado].elemento == Itens.Elementos.Ar)
		{
			switch(enemy.inventario.itensEquipados[indexEnemyArma].elemento)
			{
				case Itens.Elementos.Ar:
					//
					break;
				case Itens.Elementos.Luz:
					//
					break;
				case Itens.Elementos.Agua:
					//
					break;
				case Itens.Elementos.Fogo:
					//
					break;
				case Itens.Elementos.Terra:
					//
					break;
				case Itens.Elementos.Sombra:
					//
					break;
				
				//non mage
				
			}
		}
		
		
		return enemy;
	}
	//mais metodos de ataques, e habilidade
	//public Enemy
	
	//so botei isso pra definir todos os status do player
	// adicionar uma propriedade do tipo inventory
	
	*/
	
}
