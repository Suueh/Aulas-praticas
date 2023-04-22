using System;
class Program{
    static void Main(){
        
        Console.WriteLine("Por favor! \nFaça o cadastro abaixo");
        Cadastro();
        Menu();
    }
    public static void Cadastro(){
        
        //a criaçao do vetr estrava errado estava sem os colchetes apos o ttipo da variavel e estaava sem o tamanho ddo vetor
        string[] nome = new string[1];
        double[] altura = new double[1];
        int[] idade = new int[1];
        double[] peso = new double[1];
        char[] sexo = new char[1];

        for(int i = 0; i<1; i++){
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
        fm:
        Console.WriteLine("Digite seu sexo:");
        sexo[i] = Convert.ToChar(Console.ReadLine());
        
       switch(sexo[i]){

        case 'm':
        Console.WriteLine("N do Cadastr: {0}", i);
        break;
        case 'M':
        Console.WriteLine("N do Cadastr: {0}", i);
        break;
        case 'f':
        Console.WriteLine("N do Cadastr: {0}", i);
        break;
        case 'F':
        Console.WriteLine("N do Cadastr: {0}", i);
        break;
        default:
        Console.WriteLine("Você não escolheu nem 'f' nem 'm'  \nPorfavor escolha uma das opções acima");
        goto fm;
        break;

       }
        
    }
        
    }

    public static void Menu(){

        inicio:
        ini:
        int escolha;

        Console.WriteLine("Bem Vindo! \nVocê pode escolher uma das opções a seguir");
        Console.WriteLine("1)Cadastro \n2)Alterar um cadastro \n3)Imprimir todos os cadastros \n4)Excluir cadastro \n5)Limpar tela \n6)Sair");
        escolha = Convert.ToInt32(Console.ReadLine());
    

        switch(escolha){

            case '1':
            Cadastro();
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
