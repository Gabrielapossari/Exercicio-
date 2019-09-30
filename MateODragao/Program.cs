using System;

namespace MateODragao {
    class Program {
        static void Main (string[] args) {
            bool jogadorNaoDesistiu = true;

            do {


            System.Console.WriteLine ("==============================");
            System.Console.WriteLine ("        Mate o Dragão!        ");
            System.Console.WriteLine ("==============================");

            System.Console.WriteLine (" 1 - Iniciar jogo");
            System.Console.WriteLine (" 0 - Sair do jogo");

            string opcaoJogador = Console.ReadLine ();

            switch (opcaoJogador) {

                case "1":
                    Console.Clear (); //limpar a tela do jogo 
                    Guerreiro guerreiro = new Guerreiro (); //classe do Guerreiro
                    guerreiro.Nome = "Eduardo"; //declarando as caracteristicas do guerreiro 
                    guerreiro.Sobrenome = "Valente";
                    guerreiro.CidadeNatal = "São Paulo";
                    guerreiro.DataNascimento = DateTime.Parse ("18/05/2001");
                    guerreiro.FerramenteAtaque = "Espada";
                    guerreiro.FerramentaProtecao = "Escudo de ferro";
                    guerreiro.Forca = 2;
                    guerreiro.Destreza = 4;
                    guerreiro.Inteligencia = 2;
                    guerreiro.Vida = 20;

                    Dragao dragao = new Dragao (); 

                    dragao.Nome = "Dragonildo"; // declando as caracteristicas do dragao 
                    dragao.Forca = 5;
                    dragao.Destreza = 1;
                    dragao.Inteligencia = 3;
                    dragao.Vida = 300;
                    /* INICIO -Primeiro Diálogo */
                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}:{dragao.Nome},seu loco! Vim-lhe derrotar-te-lhe!"); // toUpper =pegar a frase e jogar para maiusculo 
                    System.Console.WriteLine ($"{dragao.Nome.Toupper()}: kkkk! Humano tolinho.Quem pensas que és?");

                    System.Console.WriteLine ();
                    System.Console.WriteLine ("Aperte ENTER para prosseguir");
                    Console.ReadLine ();

                    /*  FIM - Primeiro Diálogo  */

                    /* INICIO - Segundo Diálogo */
                    Console.Clear ();
                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.Nome}! Da casa {guerreiro.Sobrenome},ó criatura morfética!");
                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}:vVim de {guerreiro.CidadeNatal} para derrotar-te e mostrar meu valor!");
                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()} : Quem ? de onde ? Bom,que seja ...fritar-te-ei e devorar-te-ei ");

                    System.Console.WriteLine ();
                    System.Console.WriteLine ("Aperte ENTER para prosseguir");
                    Console.ReadLine ();

                    /* FIM - Segundo Diágolo  */
                    Console.Clear ();
                    bool jogadorAtacaPrimeiro =
                        guerreiro.Destreza > dragao.Destreza? true : false;

                    bool jogadorNaoCorreu = true;
                    int poderAtaqueGuerreiro =
                        guerreiro.Forca > guerreiro.Inteligencia? guerreiro.Forca + guerreiro.Destreza:
                        guerreiro.Inteligencia + guerreiro.Destreza;

                    /*INICIO - da TRETA */

                    if (jogadorAtacaPrimeiro) {
                        Console.Clear ();
                        System.Console.WriteLine ("Turno do Jogador");
                        System.Console.WriteLine ("Escolha sua ação:");
                        System.Console.WriteLine ("  1 - Atacar ");
                        System.Console.WriteLine ("  2 - Fugir ");

                        string opcaoBatalhaJogador = Console.ReadLine ();

                        switch (opcaoBatalhaJogador) {

                            case "1":
                                Random geradorNumeroAleatorio = new Random ();
                                int numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);

                                int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Toma essa Lagardo!!!!!!!");
                                    dragao.Vida -= poderAtaqueGuerreiro + 5;

                                    System.Console.WriteLine ($"HP Dragão : {dragao.Vida}");
                                    System.Console.WriteLine ($"HP Guerreiro : {guerreiro.Vida}");

                                } else {
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Errrrrrrou,tosco!");
                                }

                                break;

                            case "2":
                                jogadorNaoCorreu = false;
                                System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Simbora fioooooo!");
                                System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: xau ");

                                break;
                        }
                        System.Console.WriteLine ("Aperte ENTER para prosseguir");
                        Console.ReadLine ();

                        while (dragao.Vida > 0 && guerreiro.Vida > 0 && jogadorNaoCorreu) {
                            Console.Clear ();
                            System.Console.WriteLine ("**** Turno do Dragão *****");

                            Random geradorNumeroAleatorio = new Random ();

                            int numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                            int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);

                            int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                            int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                            if (dragaoDestrezaTotal > guerreiroDestrezaTotal) {
                                System.Console.WriteLine ($"{dragao.Nome.ToUpper()}:Tá pegando fogo -*-*-*-* ");
                                guerreiro.Vida -= dragao.Forca;

                                System.Console.WriteLine ($"HP Dragão : {dragao.Vida}");
                                System.Console.WriteLine ($"HP Guerreiro : {guerreiro.Vida}");

                            } else {
                                System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Vem tranquilo!!!!!!");
                            }
                            System.Console.WriteLine ();
                            System.Console.WriteLine ("Aperte ENTER para prosseguir");
                            Console.ReadLine ();

                            /*INICIO - Turno Jogador */

                            Console.Clear ();

                            System.Console.WriteLine ("Turno do Jogador");
                            System.Console.WriteLine ("Escolha sua ação:");
                            System.Console.WriteLine ("  1 - Atacar ");
                            System.Console.WriteLine ("  2 - Fugir ");

                            string opcaoBatalhaJogador = Console.ReadLine ();

                            switch (opcaoBatalhaJogador) {

                                case "1":
                                     geradorNumeroAleatorio = new Random ();
                                     numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                     numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);

                                     guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                     dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Toma essa Lagardo!!!!!!!");
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;

                                        System.Console.WriteLine ($"HP Dragão : {dragao.Vida}");
                                        System.Console.WriteLine ($"HP Guerreiro : {guerreiro.Vida}");

                                    } else {
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Errrrrrrou,tosco!");
                                    }

                                    if (guerreiro.Vida <=0 ){
                                        System.Console.WriteLine("Jogador murrrreu!");
                                    } 
                                    if (dragao.Vida <=0) {
                                        System.Console.WriteLine("Dragão murrrreu!");
                                    }
                                    System.Console.WriteLine();
                                    System.Console.WriteLine("Aperte o ENTER para prosseguir");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                   

                                case "2":
                                    jogadorNaoCorreu = false;
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Simbora fioooooo!");
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: xau ");

                                    break;
                            }
                            System.Console.WriteLine ("Aperte ENTER para prosseguir");
                            Console.ReadLine ();

                            /*FIM - Turno Jogador  */
                        }

                    }

                    /* FIM  -  da TRETA  */

                    break;
                case "0":
                    jogadorNaoDesistiu = false;
                    break;
                default:
                    System.Console.WriteLine ("Comando desconhecido");
                    break;

            }
            }while(jogadorNaoDesistiu);

        }
    }
}