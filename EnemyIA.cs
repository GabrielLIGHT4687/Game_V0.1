using System;
using System.Linq;
using System.Collections.Generic;
using PlayerClass;
using EnemyClass;

namespace EnemyIA;

// se baseia no enemy padrao
// como vou fazer pra analisar cada poder ??? nun sei
public class EnemyTiersAI 
{         
        //algum metodo vqi ser chamado. onde vai analisar o player.
		  //dividir em tiers. como partes do cerebro a mais. 
		  // quanto maior o tier, maior sera a precauçao e parametros analisados 
		  // e menor a aleatoriedade em decicoes arriscadas ou multiplas.
		/*  public  void WakeUp()
		  {
		  	switch enemy.tier
			  {
			  	case: 1
				  	//TierOneAI
				  case: 2
				    //tierTwoAI
				  case: 3
				    //tierThreeAI
				  //...
				  
					 
					 
			  }
		  }
		  */
		 // private Enemy enemy;
		  //private Player player;
		  
		  
		  
		  public void TierOneAI(Enemy enemy, Player player)
		  {
		     //a escollha determina os itens q o atributo defesa vao ser considersdos
			  // se atacar espada, a defesa da armadura ou amuleto(itens de defesa) nao influecia
			  //apenas a da runa/anel (itens de atack)
		  
		  	//double PlayerVidaAbsoluta = player.vida + player.defesa + player.defesaMagica;
			  
			  double playerDefesaFront = player.inventario.itensEquipados[0].defesa + player.inventario.itensEquipados[1].defesa + player.defesaMagica;
			  double playerDefesaBack = player.inventario.itensEquipados[2].defesa + player.inventario.itensEquipados[3].defesa + player.defesaMagica;
			  double playerDanoAbsoluto = player.dano+player.danoMagico;
			  
			  double enemyDefesaFront = enemy.inventario.itensEquipados[0].defesa + enemy.inventario.itensEquipados[1].defesa + enemy.defesaMagica;
			  double enemyDefesaBack = enemy.inventario.itensEquipados[2].defesa + enemy.inventario.itensEquipados[3].defesa + enemy.defesaMagica;
			  
			  bool playermata=false;
			  
			  
			  //player mata nesse turno?
			    //S
				 //playermata = true
				   //eu mato player?
					  //tenho mana pra focar?
					    //mato o player com foco?
						 
			  //player tem mana pra focar && playermata==false?
			    //S 
				   //o player me mata com ataque focado?
			  
			  // eu mato o player?
			  //eu tenho mana para atacar focado?
			  // eu mato o player com ataque focado?
			  // kwka)
			 /*
			  if(defesaFront < defesaBack)
			  {
			  	//ataca
			  }
			  e
			  
			  if(player.mana > 5)
			  {
			  	
				  
			  }
			 
			  */
			  //analisar coisas basicas
			  //dano, vida.. seus e do player
			  // aleatoriedade para escolhas de habilidades
			  
		  }
		 /* 
		  public void TierTwoAI()
		  {
		  	//... vai obtendo mais parametros..
			  // menos aleatorio q o anterior
		  }*/
}
