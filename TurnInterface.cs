using System;
using System.Linq;
using System.Collections.Generic;
using PlayerClass;
using EnemyClass;
using EnemyIA;
using PersonagensClass;
namespace TurnInterfaceclass;

public class TurnInterface 
{         
        
		  private Enemy enemyEstadoIncial;
		  private Player playerEstadoInicial;
		  public void ToStart(){
		  	//pegar player
			  // pegar enemy
			  //char battle e passar os dois como parametro
			  
			  
			  
			  
		  }
		  
		  public void Battle(Player player, Enemy enemy)
		  {
		  	//quem é mais agil começa
		/*	  if(player.agilidade >= enemy.agilidade)
			  {
			  	
			  }
			  
		*/	  
		     enemyEstadoIncial = enemy;
			  playerEstadoInicial = player;
			  while(true)
			  {
			  	Console.WriteLine("Player                   ENEMY NAME");
				  
				  Console.WriteLine("escolha sua ação");
				  /*[1] Atacar
				     [1] ataque direto
					  [2] ataque focado(-5 mana)
					  
				  [2] Defender
				     [1] front
					     [1] espada
						  [2] runa
					  [2] back
					     [1] armadura
						  [2] amuleto
				  [3] Magias
				     [1] magia1
					  [2] magia2
				  [4] Inventario
				  
				  ")
				  
				  */
				  //criar um array com as mensagens habilidades
				  // fazer um jeito de identificar quais o player tem..
				  // talvez um array do ID de cada habilidade..
				  // assim comparando e exibindo as q estao nos IDs
				  //Personagens enemyNow;
				  int choice = int.Parse(Console.ReadLine());
				  
				  (string atackStatus, Personagens enemyPosTurn) = player.Atack(choice,(Personagens)enemy );
				  //enemyNow = enemyPosTurn; 
				  if(enemyPosTurn.vida <=0)
				  {
				  	//acabar o turno, vitoria player
					  break;
				  }
				  
				  	//retornar pra enemy seu estado atual
				  enemy = (Enemy)enemyPosTurn;
				  Console.WriteLine("Player                   ENEMY NAME");
					
				  //EnemyIA.
				  
				  
				  
				  
				  
				  //chamar metodo IA enemy
				  //nao sei akalalak 
				  // inimigo ataca de algum jeito
				  // retorna playerNow
			/*	  player = playerNow; */
				  //...
				  
				  
				  
				  
			  }
		  
		  
		  
		  }
		  //comunicar player com o enemy.
		  //pega uma copia do inimigo, manda para o player no metodo de ataque.
		  //player devolve o resultado do inimigo
		  //interface analisa se ocorreu uma derrota do inimigo
		  //interface comunica ao inimigo o estado dos seus estatus.
		  //interface  espera resposta da IA do enemy
		  // processegue a acao, se for atack, faz basicamente o mesmo q com o player
		  // se for outra acao q gaste o turno, interface devolve o turno ao player... 
		  
		  
		  
		  //os ifs de locais de ataque chamam metodos diferentes, podendo incluir habilidsdes
		  // como, atacar a arma e danificala.. por exemplo
		  //habilidaded q o jogador ganharia. e tambem nao so "pontos" fixos a se bater, mas como atacar
		  /*while{
		  
		  
		  
		  }
		  */
}
