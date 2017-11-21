using System;
using Dominio;
using Util;
using ProgramaCAO.Sistema.Solucao;
using ProgramaCAO.Sistema.Solucao.Dominio;


namespace consoleProgramaCAO.Sistema.Solucao
{
    class Program
    {
        static void Main(string[] args)
        {
         string opcao = "";

         //Menu do Programa
         do
            {
                Console.WriteLine("Digite a opção desejada:");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Cadastrar Animal");
                Console.WriteLine("3 - Cadastrar Serviços e Produtos");
                Console.WriteLine("4 - Cadastrar Pedido");
                Console.WriteLine("5 - Consultar Pedido pelo ID");
                Console.WriteLine("9 - Sair");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                    Console.WriteLine("Digite o ID do cliente: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o Nome do cliente: ");
                    string nome = Console.ReadLine();
                    
                        Console.WriteLine("Digite o CPF do cliente: ");
                    string cpf = Console.ReadLine();
                    while (Validacao.ValidaCPF(cpf) == false){
                            cpf = Console.ReadLine();
                            Console.Write("Digite um CPF valido (apenas números): ");
                    }
                    
                    Console.WriteLine("Digite o Telefone do cliente: ");
                    string telefone = Console.ReadLine();
                    Endereco end = new Endereco();
                    Console.WriteLine("Digite o logradouro do cliente: ");
                    end.Logradouro = Console.ReadLine();
                    Console.WriteLine("Digite o número do cliente: ");
                    end.Numero = Console.ReadLine();
                    Console.WriteLine("Digite o complemento do cliente: ");
                    end.Complemento = Console.ReadLine();
                    Console.WriteLine("Digite o CEP do cliente: ");
                    end.CEP = Console.ReadLine();

                    Cliente cliente = new Cliente(id,nome,cpf,telefone,end);
                    bool cl = cliente.Cadastrar();

                    if(cl == true){
                         Console.WriteLine("Arquivo Criado com sucesso!");
                    }
                    else{
                         Console.WriteLine("Erro ao gravar!");
                    }
                    
                        break;

                    case "2":
                    Console.WriteLine("Digite o ID do animal: ");
                    int idanimal = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o nome do animal: ");
                    string nomeanimal = Console.ReadLine();
                    Console.WriteLine("Digite a espécie do animal: ");
                    string especie = Console.ReadLine();
                    Console.WriteLine("Digite o ID do dono do animal: ");
                    int idcliente = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o gênero do animal: ");
                    string genero = Console.ReadLine();
                    Console.WriteLine("Digite a idade do animal: ");
                    int idade = int.Parse(Console.ReadLine());
                    
                    Animal anim = new Animal(idanimal,nomeanimal,especie,genero,idade,idcliente);
                     bool ani = anim.Cadastrar();

                      if(ani == true){
                         Console.WriteLine("Arquivo Criado com sucesso!");
                     }
                     else{
                         Console.WriteLine("Erro ao gravar!");
                    }
                        break;

                    case "3":
                    Console.WriteLine("Digite o ID do serviço ou produto: ");
                    int idservprod = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a descrição do serviço ou produto: ");
                    string descricao = Console.ReadLine();
                    Console.WriteLine("Digite a preço do serviço ou produto: ");
                    double preco = double.Parse(Console.ReadLine());
                                       
                    ServicosProdutos servprod = new ServicosProdutos(idservprod,descricao,preco);
                     bool sp = servprod.Cadastrar();

                      if(sp == true){
                         Console.WriteLine("Arquivo Criado com sucesso!");
                     }
                     else{
                         Console.WriteLine("Erro ao gravar!");
                     }
                        break;
                    
                    case "4":
                    Console.WriteLine("Digite o ID do pedido: ");
                    int idpedido = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o nome do cliente: ");
                    string nomeCliente = Console.ReadLine();
                    Console.WriteLine("Digite o nome do animal: ");
                    string nomePet = Console.ReadLine();
                    Console.WriteLine("Digite a descrição: ");
                    string descricaoProdutoServico = Console.ReadLine();
                                    
                    Pedido pedidos = new Pedido(idpedido,nomeCliente,nomePet,descricaoProdutoServico);
                     bool ped = pedidos.Cadastrar();

                      if(ped == true){
                         Console.WriteLine("Arquivo Criado com sucesso!");
                     }
                     else{
                         Console.WriteLine("Erro ao gravar!");
                     }
                        break;
                    
                    case "5":
                    Console.WriteLine("Digite o ID do pedido a ser pesquisado:");
                        int pesquisaidpedido = int.Parse(Console.ReadLine());
                        Pedido pedpesq = new Pedido();
                        string resultadopesquisaidpedido = pedpesq.Consultar(pesquisaidpedido);
                        Console.WriteLine(resultadopesquisaidpedido);
                                    
                        break;
                    
                    case "9":
                        break;

                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;

                }

            } while (opcao != "9");
         
        }
    }
}
