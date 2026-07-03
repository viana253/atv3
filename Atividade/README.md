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



## Testes sugeridos

- Pessoa física com valor de compra 2500 → imposto R$ 250,00, total R$ 2.750,00.
- Pessoa jurídica com valor de compra 35000 → imposto R$ 7.000,00, total R$ 42.000,00.
- Digitar uma letra diferente de `f`/`j` → o sistema exibe mensagem de opção inválida (tratamento de erro simples, sem quebrar o programa).
