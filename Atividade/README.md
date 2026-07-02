# Sistema de Controle de Clientes — Clínica/Loja Balti (Console C#)

Sistema de console em C# que aplica os conceitos de Programação Orientada a Objetos
(abstração, herança, polimorfismo e encapsulamento), conforme o diagrama de classes:

- **Clientes** (classe-pai/abstrata na prática): nome, endereco, valor, valor_imposto, total e o método `Pagar_Imposto(v)`.
- **Pessoa_Fisica** (herda de Clientes): cpf, rg — usa o cálculo de imposto padrão (10%) herdado da classe-pai.
- **Pessoa_Juridica** (herda de Clientes): cnpj, ie — **sobrescreve** (`override`) o método `Pagar_Imposto` para calcular 20% de imposto.

## Estrutura de arquivos

```
Atividade/
├── Atividade.csproj
├── Clientes.cs          # classe-pai (abstração + encapsulamento)
├── Pessoa_Fisica.cs      # herança
├── Pessoa_Juridica.cs    # herança + polimorfismo (override)
└── Program.cs            # ponto de entrada / entrada e saída de dados
```

## Como executar

Pré-requisitos: [.NET SDK](https://dotnet.microsoft.com/download) instalado (mesmo usado no material — `net6.0`).

1. Extraia o zip.
2. Abra a pasta `Atividade` no terminal (ou no VS Code, como no material).
3. Rode:
   ```bash
   dotnet build
   dotnet run
   ```
4. Responda às perguntas no console:
   - Nome
   - Endereço
   - Tipo: `f` (Pessoa Física) ou `j` (Pessoa Jurídica)
   - CPF/RG (se física) ou CNPJ/IE (se jurídica)
   - Valor da compra

O sistema calcula automaticamente o imposto (10% para pessoa física, 20% para pessoa
jurídica) e exibe nome, endereço, documento, valor da compra, imposto e total a pagar.

## Onde cada conceito de POO aparece

| Conceito | Onde está |
|---|---|
| **Abstração** | A classe `Clientes` representa o conceito genérico de cliente, com os dados e o comportamento (`Pagar_Imposto`) comuns a qualquer cliente. |
| **Herança** | `Pessoa_Fisica : Clientes` e `Pessoa_Juridica : Clientes` herdam nome, endereco, valor, valor_imposto, total e o método `Pagar_Imposto`. |
| **Polimorfismo** | `Pagar_Imposto` é `virtual` em `Clientes` e `override` em `Pessoa_Juridica`, alterando o percentual de imposto (10% → 20%) mantendo a mesma assinatura de método. |
| **Encapsulamento** | `valor`, `valor_imposto` e `total` usam `protected set`, impedindo que sejam alterados diretamente de fora das classes — só o método `Pagar_Imposto` pode defini-los. |

## Testes sugeridos

- Pessoa física com valor de compra 2500 → imposto R$ 250,00, total R$ 2.750,00.
- Pessoa jurídica com valor de compra 35000 → imposto R$ 7.000,00, total R$ 42.000,00.
- Digitar uma letra diferente de `f`/`j` → o sistema exibe mensagem de opção inválida (tratamento de erro simples, sem quebrar o programa).
