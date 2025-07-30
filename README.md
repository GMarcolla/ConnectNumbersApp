# ConnectNumbersApp

**ConnectNumbersApp** é uma aplicação console simples em C# que simula uma rede de conexões entre números inteiros. Utilizando o conceito de conjuntos disjuntos (Disjoint Set / Union-Find), o programa permite conectar elementos entre si e verificar se dois números estão conectados diretamente ou indiretamente.

## 🚀 Funcionalidades

- Conectar dois números inteiros (`Connect`)
- Verificar se dois números estão conectados (`Query`)
- Utiliza otimização com **path compression** para melhor desempenho nas consultas

## 🧠 Conceito

O projeto implementa a estrutura de dados **Union-Find (Disjoint Set)**, com a técnica de compressão de caminhos, ideal para resolver problemas de conectividade, como:

- Componentes conectados em grafos
- Redes sociais (verificar se duas pessoas estão conectadas)
- Agrupamento de conjuntos dinâmicos

## 📁 Estrutura do Projeto

```
ConnectNumbersApp/
│
├── Program.cs         # Classe principal com exemplo de uso
├── Network.cs         # Implementação da estrutura Union-Find
```

## 🔧 Como usar

1. **Clone o repositório:**

```bash
git clone https://github.com/GMarcolla/ConnectNumbersApp.git
cd ConnectNumbersApp
```

2. **Compile e execute o projeto:**

Se estiver usando .NET CLI:

```bash
dotnet build
dotnet run
```

3. **Saída esperada:**

```plaintext
True
True
True
False
False
```

## 🛠️ Tecnologias

- [.NET 6+](https://dotnet.microsoft.com/)
- C# (linguagem principal)
- Console Application (sem interface gráfica)

## 📌 Exemplo de uso

No `Program.cs`, a seguinte sequência de comandos é executada:

```csharp
network.Connect(1, 2);
network.Connect(6, 2);
network.Connect(2, 4);
network.Connect(5, 8);
```

Em seguida, são feitas consultas para verificar conectividade entre pares como `(1,6)` ou `(5,6)`.

## ✅ Validação

O código valida se os índices estão dentro dos limites da rede antes de executar qualquer operação.

## 📈 Possíveis melhorias

- Adicionar interface interativa para entrada de dados
- Suporte a remoção de conexões
- Interface gráfica com WinForms, WPF ou Web (ASP.NET)
- Exportar graficamente as conexões

---

Feito por [@GMarcolla](https://github.com/GMarcolla) 🚀