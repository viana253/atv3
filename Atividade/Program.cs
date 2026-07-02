using System;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;

            Console.WriteLine("=== Sistema de Controle de Clientes ===");
            Console.WriteLine();

            Console.WriteLine("Informar Nome:");
            string var_nome = Console.ReadLine();

            Console.WriteLine("Informar Endereço:");
            string var_endereco = Console.ReadLine();

            Console.WriteLine("Pessoa Física (f) ou Jurídica (j) ?");
            string var_tipo = Console.ReadLine();

            if (var_tipo == "f" || var_tipo == "F")
            {
                // --- Pessoa Física ----
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;

                Console.WriteLine("Informar CPF:");
                pf.cpf = Console.ReadLine();

                Console.WriteLine("Informar RG:");
                pf.rg = Console.ReadLine();

                Console.WriteLine("Informar Valor de Compra:");
                val_pag = float.Parse(Console.ReadLine());

                pf.Pagar_Imposto(val_pag);

                Console.WriteLine();
                Console.WriteLine("-------- Pessoa Física ---------");
                Console.WriteLine("Nome ..........: " + pf.nome);
                Console.WriteLine("Endereço ......: " + pf.endereco);
                Console.WriteLine("CPF ...........: " + pf.cpf);
                Console.WriteLine("RG ............: " + pf.rg);
                Console.WriteLine("Valor de Compra: " + pf.valor.ToString("C"));
                Console.WriteLine("Imposto (10%)..: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar .: " + pf.total.ToString("C"));
            }
            else if (var_tipo == "j" || var_tipo == "J")
            {
                // --- Pessoa Jurídica ----
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;

                Console.WriteLine("Informar CNPJ:");
                pj.cnpj = Console.ReadLine();

                Console.WriteLine("Informar IE:");
                pj.ie = Console.ReadLine();

                Console.WriteLine("Informar Valor de Compra:");
                val_pag = float.Parse(Console.ReadLine());

                pj.Pagar_Imposto(val_pag);

                Console.WriteLine();
                Console.WriteLine("-------- Pessoa Jurídica ---------");
                Console.WriteLine("Nome ..........: " + pj.nome);
                Console.WriteLine("Endereço ......: " + pj.endereco);
                Console.WriteLine("CNPJ ..........: " + pj.cnpj);
                Console.WriteLine("IE ............: " + pj.ie);
                Console.WriteLine("Valor de Compra: " + pj.valor.ToString("C"));
                Console.WriteLine("Imposto (20%)..: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar .: " + pj.total.ToString("C"));
            }
            else
            {
                Console.WriteLine("Opção inválida! Digite apenas 'f' para Pessoa Física ou 'j' para Pessoa Jurídica.");
            }
        }
    }
}
