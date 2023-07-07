using System;
using System.Linq;
using System.Collections.Generic;
using ItensClass;
using ArmaduraClass;
using ArmaClass;

namespace InventoryClass;

public class Inventory 
{
	public List<Itens> inventario = new List<Itens>();
   public List<Itens> itensEquipados = new List<Itens>
	{
		new Arma(),
		new Armadura()
	};
	
	
	
	//Talvez retonar um bool pra saber se deu certo ou nao
	// e entao quebrar o laço la nas opcoes
	public void removerItem(int idItem)
	{
		if(idItem >0 && idItem < inventario.Capacity)
		{
			int indexItem = idItem-1;
			inventario.RemoveAt(indexItem);
		}
	}
	
	public void equiparItem(int idItem)
	{
		int indexItem = idItem-1;
		int indexItemEquipado;
		Itens ItemEquipado;
		Itens ItemEquipar;
		
		/*if(inventario[indexItem] is Arma)
		{
			Console.WriteLine("Arma");
			
			indexItemEquipado = itensEquipados.FindIndex(item => item is Arma);

			
				ItemEquipado = itensEquipados[indexItemEquipado];
				
			// usar aquela expresao lambda para percorrer a lista procurando o tipo de item expecifico
			  // prevencao contra erros caso a ordem dos intens se alterem
			
				itensEquipados[indexItemEquipado] = (Arma)inventario[indexItem];
				inventario.RemoveAt(indexItem);
				inventario.Add(ItemEquipado);
				
			
		}*/
	   if(inventario[indexItem] is Arma)
		{
			Console.WriteLine("Armadura");
			
			indexItemEquipado = itensEquipados.FindIndex(item => item is Arma);
			
			//ItemEquipado = itensEquipados[indexItemEquipado];
			ItemEquipar = (Arma)inventario[indexItem];
			inventario.RemoveAt(indexItem);
			desequiparItem(indexItemEquipado,true);
			// usar aquela expresao lambda para percorrer a lista procurando o tipo de item expecifico
			// prevencao contra erros caso a ordem dos intens se alterem
			itensEquipados[indexItemEquipado] = ItemEquipar;
			
		//	inventario.Add(ItemEquipado);
			
	

		}
		else if(inventario[indexItem] is Armadura)
		{
			Console.WriteLine("Armadura");
			
			indexItemEquipado = itensEquipados.FindIndex(item => item is Armadura);
			
			//ItemEquipado = itensEquipados[indexItemEquipado];
			ItemEquipar = (Armadura)inventario[indexItem];
			inventario.RemoveAt(indexItem);
			desequiparItem(indexItemEquipado,true);
			// usar aquela expresao lambda para percorrer a lista procurando o tipo de item expecifico
			// prevencao contra erros caso a ordem dos intens se alterem
			itensEquipados[indexItemEquipado] = ItemEquipar;
			
		//	inventario.Add(ItemEquipado);
			
	

		}
		else if(inventario[indexItem] is Armadura)
		{
			Console.WriteLine("Armadura");
			
			indexItemEquipado = itensEquipados.FindIndex(item => item is Armadura);
			
			//ItemEquipado = itensEquipados[indexItemEquipado];
			ItemEquipar = (Armadura)inventario[indexItem];
			inventario.RemoveAt(indexItem);
			desequiparItem(indexItemEquipado,true);
			// usar aquela expresao lambda para percorrer a lista procurando o tipo de item expecifico
			// prevencao contra erros caso a ordem dos intens se alterem
			itensEquipados[indexItemEquipado] = ItemEquipar;
			
		//	inventario.Add(ItemEquipado);
			
	

		}
		else if(inventario[indexItem] is Armadura)
		{
			Console.WriteLine("Armadura");
			
			indexItemEquipado = itensEquipados.FindIndex(item => item is Armadura);
			
			//ItemEquipado = itensEquipados[indexItemEquipado];
			ItemEquipar = (Armadura)inventario[indexItem];
			inventario.RemoveAt(indexItem);
			desequiparItem(indexItemEquipado,true);
			// usar aquela expresao lambda para percorrer a lista procurando o tipo de item expecifico
			// prevencao contra erros caso a ordem dos intens se alterem
			itensEquipados[indexItemEquipado] = ItemEquipar;
			
		//	inventario.Add(ItemEquipado);
			
	

		}
		/*
		Type tipoItem = inventario[indexItem].GetType();
		
		Itens objeto = (Itens)Activator.CreateInstance(tipoItem);
    
		
		indexItemEquipado = itensEquipados.FindIndex(item => item.Equals(tipoItem.GetType()));
		
		ItemEquipado = itensEquipados[indexItemEquipado];
		itensEquipados[indexItemEquipado] = (objeto.)inventario[indexItem];
		inventario.RemoveAt(indexItem);
		inventario.Add(ItemEquipado);
		*/
			
		
		
	}
	
	public void desequiparItem(int indexItem,bool chamadoPorEquipar=false)
	{
		
		
			
			//int indexItemEquipado = itensEquipados.FindIndex(item => item is Arma);
			Itens ItemEquipado;
			int indexItemEquipado;
			
			if(chamadoPorEquipar == true)
			{
				indexItemEquipado = indexItem;
			}
			else{
				indexItemEquipado = indexItem-1;
			}
			
			
			ItemEquipado = itensEquipados[indexItemEquipado];
			itensEquipados.RemoveAt(indexItemEquipado);
			
			if(indexItemEquipado == 0)
			{
				itensEquipados.Insert(indexItemEquipado, new Arma());
			}
			else if(indexItemEquipado == 1)
			{
				itensEquipados.Insert(indexItemEquipado, new Armadura());
			}
			else if(indexItemEquipado == 2)
			{
				//runa
				itensEquipados.Insert(indexItemEquipado, new Arma());
			}
			else if( indexItemEquipado == 3)
			{
				//amuleto
			}
			else{
			
				// pra erro, sei la
				
				}
			
		
		
		
			inventario.Add(ItemEquipado);
		
	}
        
}
