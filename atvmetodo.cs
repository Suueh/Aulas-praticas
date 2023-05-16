using System;
class Program{

        public static int tc = 100;
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

        //n++;
        Console.WriteLine("Cadastro feito com sucesso!");
    }

    }

    public static void Menu(){

        
        int escolha;

        Console.WriteLine("Bem Vindo!");
        inicio:
        Console.WriteLine("Você pode escolher uma das opções a seguir: \n1)Fazer um cadastro \n2)Alterar um cadastro \n3)Imprimir um dos cadastros \n4)Imprimir todos os cadastros \n5)Excluir cadastro \n6)Limpar tela \n7)Sair");
        escolha = Convert.ToInt32(Console.ReadLine());
    

        switch(escolha){

            case 1:
            Cadastros();
            //FAZER!! Quando fazemos nossos primeiros cadastros, voltamos no menu e irmos em cadastro novamente, está alterado os cadastros alteriores
            goto inicio;
            

            case 2:
            AlterCadastro();
            goto inicio;
            

            case 3:
            ImpriCadastro();
            goto inicio;

            case 4:
            Impritdcadastros();
            goto inicio;
            

            case 5:
            excadastro();
            goto inicio;
            

            case 6:
            Limpar();
            goto inicio;
            

            case 7:
            Sair();
            break;
        
            default:
            Console.WriteLine("Você não escolheu nenhuma das opções a cima");
            goto inicio;
        }
    }
    public static void excadastro(){

        if(idade[0] == 0){
            Console.WriteLine("Você não fez seu primeiro cadastro!!!");
            Console.WriteLine("Digite qualquer tecla para voltar pro menu:");
            Console.ReadKey();
            Console.Clear();
        }
        else{

        int esc;

        Console.WriteLine("Digite o cadastro que deseja excluir?");
        esc = Convert.ToInt32(Console.ReadLine());

        if(idade[esc] == 0){

            Console.WriteLine("Cadastro inexistente ou ja excluido");
            

        }
        else{

        nome[esc] = " ";
        altura[esc] = 0;
        idade[esc] = 0;
        peso[esc] = 0;
        sexo[esc] = ' ';

        Console.WriteLine("Cadastro excluido com sucesso!");
        }
        }
    }
    public static void AlterCadastro(){
        
        if(idade[0] == 0){
            Console.WriteLine("Você não fez seu primeiro cadastro!!!");
            Console.WriteLine("Digite qualquer tecla para voltar pro menu:");
            Console.ReadKey();
            Console.Clear();
        }
        else{

        int nc;

        Console.WriteLine("Qual cadastro você deseja alterar?");
        nc = Convert.ToInt32(Console.ReadLine());

        if(idade[nc] == 0){
            Console.WriteLine("Cadastro inexistente...");
            Console.WriteLine("Digite qualquer tecla para voltar pro menu:");
            Console.ReadKey();
            Console.Clear();
            
        }
        else{

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

        Console.Clear();
        
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
        }
    }
    public static void ImpriCadastro(){

        if(idade[0] == 0){
            Console.WriteLine("Você não fez seu primeiro cadastro!!!");
            Console.WriteLine("Digite qualquer tecla para voltar pro menu:");
            Console.ReadKey();
            Console.Clear();
        }
        else{
        int nc;

        Console.Clear();
        Console.WriteLine("Qual cadastro você deseja Imprimir?");
        nc = Convert.ToInt32(Console.ReadLine());

        if(idade[nc] == 0){
            Console.WriteLine("Cadastro inexistente...");
            Console.WriteLine("Digite qualquer tecla para voltar pro menu:");
            Console.ReadKey();
            Console.Clear();
            
        }
        else{

        Console.WriteLine("Nome: {0}", nome[nc]);
        Console.WriteLine("Altura: {0}", altura[nc]);
        Console.WriteLine("Idade: {0}", idade[nc]);
        Console.WriteLine("Peso: {0}", peso[nc]);
        Console.WriteLine("Sexualidade: {0}", sexo[nc]);

        Console.WriteLine("Digite qualquer tecla para voltar pro menu");
        Console.ReadKey();
        Console.Clear();

        }
        }
    }

    public static void Impritdcadastros(){

        if(idade[0] == 0){
            Console.WriteLine("Você não fez seu primeiro cadastro!!!");
            Console.WriteLine("Digite qualquer tecla para voltar pro menu:");
            Console.ReadKey();
            Console.Clear();
        }
        else{
        char nc;

        Console.WriteLine("Tem certeza que você deseja imprimir todos os cadastros? [S] [N]");
        nc = Convert.ToChar(Console.ReadLine());

        if(nc == 'S' || nc == 's'){

            for(int i = 0; i<tc; i++){
                

                Console.WriteLine("N do Cadastro: {0}", i);
                Console.WriteLine("Nome: {0}", nome[i]);
                Console.WriteLine("Altura: {0}", altura[i]);
                Console.WriteLine("Idade: {0}", idade[i]);
                Console.WriteLine("Peso: {0}", peso[i]);
                Console.WriteLine("Sexualidade: {0}", sexo[i]);

                Console.WriteLine("____________\\____________");

                }
                Console.WriteLine("Digite qualquer tecla para voltar pro menu:");
                Console.ReadKey();
                Console.Clear();
            }
        }
        }
        

    
    public static void Limpar(){

        Console.Clear();

    }
    public static void Sair(){

    }
    }
    
