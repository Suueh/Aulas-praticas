using System;
class Program{
    static void Main(){
    
        PCadastro();
        Console.Clear();
        Menu();
    }
    public static void PCadastro(){

        Console.WriteLine("Por favor! \nFaça o cadastro abaixo");
        
        //a criaçao do vetr estrava errado estava sem os colchetes apos o ttipo da variavel e estaava sem o tamanho ddo vetor
        string[] nome = new string[1];
        double[] altura = new double[1];
        int[] idade = new int[1];
        double[] peso = new double[1];
        char[] sexo = new char[1];
        int n = 0;

        for(int i = 0; i<1; i++){
         n++;
            
        //a criacao do vetor estava dentro do for entao toda vvez que o for rodava e o i recbia umm incrementtto o coddigo criava novos vetores
        Console.Write("Digite seu nome:");
        nome[i] = Console.ReadLine();
        // o indice da posiçao estava sempre 0 entao nao  acumulava os cadastros
        Console.Write("Digite sua altura:");
        altura[i] = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite seu idade:");
        idade[i] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite seu peso:");
        peso[i] = Convert.ToInt32(Console.ReadLine());
        fm:
        Console.Write("Digite seu sexo:");
        sexo[i] = Convert.ToChar(Console.ReadLine());
        
       switch(sexo[i]){

        case 'm':
<<<<<<< HEAD
        break;
        case 'M':
        break;
        case 'f':
        break;
        case 'F':
=======
        Console.WriteLine("N do Cadastro: {0}", n);
        break;
        case 'M':
        Console.WriteLine("N do Cadastro: {0}", n);
        break;
        case 'f':
        Console.WriteLine("N do Cadastro: {0}", n);
        break;
        case 'F':
        Console.WriteLine("N do Cadastro: {0}", n);
>>>>>>> 8524f84bec4df38313d19c9e909368c5fdee8c17
        break;
        default:
        Console.WriteLine("Você não escolheu nem 'f' nem 'm'  \nPorfavor escolha uma das opções acima");
        goto fm;

        
       }
       
    }
       
    }
    public static void Cadastros(){

        Console.Clear();

        int tc;

        Console.Write("Quantos cadastros você deseja fazer:");
        tc = Convert.ToInt32(Console.ReadLine());

        string[] nome = new string[tc];
        double[] altura = new double[tc];
        int[] idade = new int[tc];
        double[] peso = new double[tc];
        char[] sexo = new char[tc];

        for(int i = 0; i<tc; i++){
        Console.Write("Digite seu nome:");
        nome[i] = Console.ReadLine();
        Console.Write("Digite sua altura:");
        altura[i] = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite sua idade:");
        idade[i] = Convert.ToInt32(Console.ReadLine());
       Console.Write("Digite seu peso:");
        peso[i] = Convert.ToInt32(Console.ReadLine());
        fm:
        Console.Write("Digite seu sexo:");
        sexo[i] = Convert.ToChar(Console.ReadLine());
        
       switch(sexo[i]){

        case 'm':
        Console.WriteLine("N do Cadastro: {0}", i);
        break;
        case 'M':
        Console.WriteLine("N do Cadastro: {0}", i);
        break;
        case 'f':
        Console.WriteLine("N do Cadastro: {0}", i);
        break;
        case 'F':
        Console.WriteLine("N do Cadastro: {0}", i);
        break;
        default:
        Console.WriteLine("Você não escolheu nem 'f' nem 'm'  \nPorfavor escolha uma das opções acima");
        goto fm;

       }
       
        Console.WriteLine("Cadastro feito com sucesso!");
    }

    }

    public static void Menu(){

        
        int escolha;

        Console.WriteLine("Bem Vindo!");
        inicio:
        ini:
        Console.WriteLine("Você pode escolher uma das opções a seguir: \n1)Cadastro \n2)Alterar um cadastro \n3)Imprimir todos os cadastros \n4)Excluir cadastro \n5)Limpar tela \n6)Sair");
        escolha = Convert.ToInt32(Console.ReadLine());
    

        switch(escolha){

            case 1:
<<<<<<< HEAD
            Cadastros();
=======
            Cadastro();
>>>>>>> 8524f84bec4df38313d19c9e909368c5fdee8c17
            goto inicio;
            

            case 2:
            AlterCadastro();
            goto inicio;
            

            case 3:
            ImpriCadastro();
            goto inicio;
            

            case 4:
            excadastro();
            goto inicio;
            

            case 5:
            Limpar();
            goto inicio;
            

            case 6:
            Sair();
            goto inicio;
        
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
