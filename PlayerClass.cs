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

public class Player 
{
	public double vida{get;set;}
	public double mana{get;set;}
	public double defesa{get;set;}
	public double defesaMagica{get;set;} 
	public double dano{get;set;}
	public double danoMagico{get;set;}
	public double chanceCritico{get;set;}
	public double chanceEsquiva{get;set;}
	
	Inventory inventario = new Inventory();
	
	public void Atack(Enemy enemy)
	{
		List<Itens> tipos = new List<Itens>(){new Arma(),new Runa()};
		List<Itens> tiposEnemy = new List<Itens>(){new Armadura(), new Amuleto()};
		double porcentBuff = 0.0;
		
		//RETORNAR DANO COM BUFF?
		//RETORNAR PORCENTBUFF?
		//APLICAR?
		
		
		
		
		//Type tipoo = tipos[0].GetType();
	//	int indexItemEquipado = inventario.itensEquipados.FindIndex(item => item.GetType() == tipos[0].GetType());
		//int indexArmaduraEquipado = inventario.itensEquipados.FindIndex(item => item is Armadura);
	//	int indexRunaEquipado = itensEquipados.FindIndex(item => item is Runa);
	//	int indexAmuletoEquipado = itensEquipados.FindIndex(item => item is Amuleto);
	
		for(int indexGeral =0; indexGeral<2 ; indexGeral++)
		{
			
		
		int indexItemEquipado = inventario.itensEquipados.FindIndex(item => item.GetType() == tipos[indexGeral].GetType());
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
		*/
		
		
	}
	
	
	//so botei isso pra definir todos os status do player
	// adicionar uma propriedade do tipo inventory
	
	
	
}
