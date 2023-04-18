using System;
class Program{
    static void Main(){
        
        Console.WriteLine("Por favor! \nfaça o cadastro a baixo");
        Menu();
    }
    public static void cadastro(){
        
        //a criaçao do vetr estrava errado estava sem os colchetes apos o ttipo da variavel e estaava sem o tamanho ddo vetor
        string[] nome = new string[2];
        double[] altura = new double[2];
        int[] idade = new int[2];
        double[] peso = new double[2];
        char[] sexo = new char[2];

        for(int i = 0; i<2; i++){
        //a criacao do vetor estava dentro do for entao toda vvez que o for rodava e o i recbia umm incrementtto o coddigo criava novos vetores
        Console.WriteLine("Digite seu nome:");
        nome[i] = Console.ReadLine();
        // o inddice da posicciçao esttavaa sempre 0 entao naao  acumulava os cadastros
        Console.WriteLine("Digite sua altura:");
        altura[i] = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite seu idade:");
        idade[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite seu peso:");
        peso[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite seu sexo:");
        sexo[i] = Convert.ToChar(Console.ReadLine());
        
        Console.WriteLine("N do cadastro: {0}", i);
    }
        
    }

    public static void Menu(){

        inicio:
        ini:
        char escolha;

        Console.WriteLine("Escolha uma das opções a seguir");
        Console.WriteLine("1)Cadastro \n2)Alterar cadastro \n3)Imprimir todos os cadastros \n4)Excluir cadastro \n5)Limpar tela \n6)Sair");
        escolha = Convert.ToChar(Console.ReadLine());
    

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
    public static void excadastro(){
        /*char escolha;

        Console.WriteLine("Tem certeza que deseja excluir? [S] [N]");
        escolha = Convert.ToChar(Console.ReadLine());
        if(escolha == 's' || escolha == 'S'){

            nome = "";
            altura = 0;
            idade = 0;
            peso = 0;
            sexo = ' ';

        }*/



    }
    public static void AlterCadastro(){



    }
    public static void ImpriCadastro(){



    }
    public static void Limpar(){



    }
    public static void Sair(){

    }
    }
