using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha{
    internal class Exercicio04{

        static char[,] Imagem = new char[3, 3];
        static char Jogador = 'X';

        static void CriarImagem(){

            for (int i = 0; i < 3; i++){
                for (int j = 0; j < 3; j++){
                    Imagem[i, j] = ' '; // preenche a matriz com espaços em branco
                }
            }
        }

        static bool JogoAcabou(){
            if (VerificarVitoria('X')){
                Console.WriteLine("Jogador X ganhou!");
                return true;
            }
            else if (VerificarVitoria('O')){
                Console.WriteLine("Jogador O ganhou!");
                return true;
            }
            else if (TabuleiroCompleto()){
                Console.WriteLine("Empate!");
                return true;
            }
            else{
                return false;
            }
        }
        static void FazerJogada(){
            int linha, coluna;
            int valor;

            do{
                do{
                    Console.WriteLine("Jogador {0}, digite a linha (0-2): ", Jogador);
                    string input = Console.ReadLine();

                    if (Int32.TryParse(input, out valor)){
                        if (valor >= 0 && valor <= 2){
                            break;
                        }
                    }

                    Console.WriteLine("Valor inválido. Tente novamente.");
                } while (true);

                linha = valor;
                do{
                    Console.WriteLine("Jogador {0}, digite a coluna (0-2): ", Jogador);
                    string input = Console.ReadLine();

                    if (Int32.TryParse(input, out valor)){
                        if (valor >= 0 && valor <= 2){
                            break;
                        }
                    }

                    Console.WriteLine("Valor inválido. Tente novamente.");
                } while (true);

                coluna = valor;

                if (Imagem[linha, coluna] != ' '){
                    Console.WriteLine("Posição ocupada. Tente novamente.");
                }

            } while (Imagem[linha, coluna] != ' ');

            Imagem[linha, coluna] = Jogador;
        }

        static void TrocarJogador(){
            if (Jogador == 'X'){
                Jogador = 'O';
            }
            else{
                Jogador = 'X';
            }
        }
        static bool VerificarVitoria(char jogador){
            // verificar linhas
            for (int i = 0; i < 3; i++){
                if (Imagem[i, 0] == jogador && Imagem[i, 1] == jogador && Imagem[i, 2] == jogador){
                    return true;
                }
            }

            // verificar colunas
            for (int j = 0; j < 3; j++){
                if (Imagem[0, j] == jogador && Imagem[1, j] == jogador && Imagem[2, j] == jogador){
                    return true;
                }
            }

            // verificar diagonais
            if (Imagem[0, 0] == jogador && Imagem[1, 1] == jogador && Imagem[2, 2] == jogador){
                return true;
            }
            if (Imagem[0, 2] == jogador && Imagem[1, 1] == jogador && Imagem[2, 0] == jogador){
                return true;
            }

            return false;
        }
        static void MostrarImagem(){
            Console.WriteLine("  --------|-------|-------");
            Console.WriteLine("      {0}   |   {1}   |   {2}   ", Imagem[0, 0], Imagem[0, 1], Imagem[0, 2]);
            Console.WriteLine("  --------|-------|-------");
            Console.WriteLine("      {0}   |   {1}   |   {2}   ", Imagem[1, 0], Imagem[1, 1], Imagem[1, 2]);
            Console.WriteLine("  --------|-------|-------");
            Console.WriteLine("      {0}   |   {1}   |   {2}   ", Imagem[2, 0], Imagem[2, 1], Imagem[2, 2]);
            Console.WriteLine("  --------|-------|-------");
            Console.WriteLine();
        }
        static bool TabuleiroCompleto(){
            for (int i = 0; i < 3; i++){
                for (int j = 0; j < 3; j++){
                    if (Imagem[i, j] == ' '){
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args){
            CriarImagem(); // preenche a matriz com espaços em branco
            MostrarImagem(); // mostra o imagem vazia

            while (!JogoAcabou()){ // repete até achar um ganhador
          
                FazerJogada(); // pede ao jogador para fazer uma jogada
                MostrarImagem(); // mostra a imagem atualizada
                TrocarJogador(); // troca o jogador atual
            }

            Console.WriteLine("Fim do jogo!"); // mostra a mensagem de fim de jogo
            Console.ReadLine(); // espera que o usuário pressione enter
        }
    }
}