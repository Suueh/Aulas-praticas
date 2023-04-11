using System;
class Program{
    static void Main(){
        
        Console.WriteLine("Por favor! \nfaça o cadastro a baixo");
        int metodo = newint [cadastro()];
        Console.Clear();
        Menu();
    }
    static void cadastro(string nome, double altura, int idade, double peso, char sexo){
        
        string nome = new string[];
        double altura = new double[];
        int idade = new int[];
        double peso = new double[];
        char sexo = new char[];

        Console.WriteLine("Digite seu nome:");
        nome[0] = Console.ReadLine();
        Console.WriteLine("Digite sua altura:");
        altura[0] = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite seu idade:");
        idade[0] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite seu peso:");
        peso[0] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite seu sexo:");
        sexo[0] = Convert.ToChar(Console.ReadLine());

        
        
    }

    static void Menu(){

        inicio:
        ini:
        char escolha;

        Console.WriteLine("Escolha uma das opções a seguir");
        escolha = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("1)Cadastro \n2)Alterar cadastro \n3)Imprimir todos os cadastros \n4)Excluir cadastro \n5)Limpar tela \n6)Sair");

        switch(escolha){

            case '1':
            cadastro();
            goto inicio;
            break;

            case '2':
            AlterCadastro();
            goto inicio;
            break;

            case '3':
            ImpriCadastro();
            goto inicio;
            break;

            case '4':
            excadastro();
            goto inicio;
            break;

            case '5':
            Limpar();
            goto inicio;
            break;

            case '6':
            Sair();
            goto inicio;
            break;
        
            default:
            Console.WriteLine("Você não escolheu nenhuma das opções a cima");
            goto ini;
        }
    }
    static void excadastro(nome altura ,idade peso ,sexo ){
        char escolha;

        Console.WriteLine("Tem certeza que deseja excluir? [S] [N]");
        escolha = Convert.ToChar(Console.ReadLine());
        if(escolha == 's' || escolha == 'S'){

            nome = "";
            altura = 0;
            idade = 0;
            peso = 0;
            sexo = "";

        }



    }
    static void AlterCadastro(){



    }
    static void ImpriCadastro(){



    }
    static void Limpar(){



    }
    static void Sair(){

    }
    }
