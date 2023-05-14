using System;
class Program{

        public static int tc;
        public static string [] nome = new string[tc];
       public static double[] altura = new double[tc];
       public static int[] idade = new int[tc];
       public static double[] peso = new double[tc];
       public static char[] sexo = new char[tc];

    static void Main(){

        Menu();

    }
    public static void Cadastros(){

        Console.Clear();
        Console.Write("Quantos cadastros você deseja fazer:");
        tc = Convert.ToInt32(Console.ReadLine());

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
        Console.WriteLine("Você pode escolher uma das opções a seguir: \n1)Cadastro \n2)Alterar um cadastro \n3)Imprimir um dos cadastros \n4)Excluir cadastro \n5)Limpar tela \n6)Sair");
        escolha = Convert.ToInt32(Console.ReadLine());
    

        switch(escolha){

            case 1:
            Cadastros();
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

        int nc;

        Console.WriteLine("Qual cadastro você deseja alterar?");
        nc = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite seu nome:");
        nome[nc] = Console.ReadLine();
        Console.Write("Digite sua altura:");
        altura[nc] = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite sua idade:");
        idade[nc] = Convert.ToInt32(Console.ReadLine());
       Console.Write("Digite seu peso:");
        peso[nc] = Convert.ToInt32(Console.ReadLine());
        fm:
        Console.Write("Digite seu sexo:");
        sexo[nc] = Convert.ToChar(Console.ReadLine());
        
       switch(sexo[nc]){

        case 'm':
        Console.WriteLine("N do Cadastro alterado: {0}", nc);
        break;
        case 'M':
        Console.WriteLine("N do Cadastro alterado: {0}", nc);
        break;
        case 'f':
        Console.WriteLine("N do Cadastro alterado: {0}", nc);
        break;
        case 'F':
        Console.WriteLine("N do Cadastro alterado: {0}", nc);
        break;
        default:
        Console.WriteLine("Você não escolheu nem 'f' nem 'm'  \nPorfavor escolha uma das opções acima");
        goto fm;

       }
       
        Console.WriteLine("Cadastro alterado com sucesso!");

    }
    public static void ImpriCadastro(){
        int nc;

        Console.WriteLine("Qual cadastro você deseja Imprimir?");
        nc = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Nome: {0}", nome[nc]);
        Console.WriteLine("Altura: {0}", altura[nc]);
        Console.WriteLine("Idade: {0}", idade[nc]);
        Console.WriteLine("Peso: {0}", peso[nc]);
        Console.WriteLine("Sexualidade: {0}", sexo[nc]);

    }
    public static void Limpar(){

        Console.Clear();

    }
    public static void Sair(){

    }
    }
