# Kids with Candies 🍭

Este projeto implementa uma solução para o problema "Kids with Candies", onde determinamos quais crianças terão o maior número de doces após receberem doces extras.

## 📋 Descrição do Problema

Dado um array de inteiros `candies`, onde `candies[i]` representa o número de doces que a i-ésima criança possui, e um inteiro `extraCandies`, que representa o número de doces extras que você tem.

Retorne um array booleano `result` de tamanho `candies.length`, onde `result[i]` é `true` se, após dar à i-ésima criança todos os `extraCandies`, ela tiver o **maior número de doces** entre todas as crianças, ou `false` caso contrário.

Note que **múltiplas crianças** podem ter o maior número de doces.

## 🚀 Como Executar

### Pré-requisitos
- .NET 9.0 SDK

### Executando o projeto
```bash
# Clone o repositório
git clone <url-do-repositorio>
cd candyWithKids

# Restaurar dependências
dotnet restore

# Compilar o projeto
dotnet build

# Executar o projeto
dotnet run
```

## 💡 Algoritmo

A solução funciona em duas etapas:

1. **Encontrar o máximo**: Percorre o array para encontrar o maior número de doces que qualquer criança possui atualmente
2. **Verificar cada criança**: Para cada criança, verifica se o número de doces dela mais os doces extras é maior ou igual ao máximo atual

### Complexidade
- **Tempo**: O(n), onde n é o número de crianças
- **Espaço**: O(n) para armazenar o resultado

## 📝 Exemplos

### Exemplo 1
```
Entrada: candies = [2,3,5,1,3], extraCandies = 3
Saída: [true,true,true,false,true]

Explicação: 
- Criança 1: 2 + 3 = 5 >= 5 (máximo atual) → true
- Criança 2: 3 + 3 = 6 >= 5 → true  
- Criança 3: 5 + 3 = 8 >= 5 → true
- Criança 4: 1 + 3 = 4 < 5 → false
- Criança 5: 3 + 3 = 6 >= 5 → true
```

### Exemplo 2
```
Entrada: candies = [4,2,1,1,2], extraCandies = 1
Saída: [true,false,false,false,false]

Explicação:
Apenas a primeira criança pode ter o maior número de doces.
```

## 🏗️ Estrutura do Projeto

```
candyWithKids/
├── Program.cs              # Código principal com a solução
├── candyWithKids.csproj    # Arquivo de configuração do projeto
├── candyWithKids.sln       # Arquivo de solução
├── README.md               # Este arquivo
├── bin/                    # Arquivos compilados
└── obj/                    # Arquivos temporários de build
```

## 🔧 Tecnologias Utilizadas

- **C#** - Linguagem de programação
- **.NET 9.0** - Framework
- **Visual Studio Code** - Editor recomendado

## 📊 Casos de Teste

O algoritmo funciona corretamente para:
- Arrays com uma única criança
- Casos onde todas as crianças podem ter o máximo
- Casos onde nenhuma criança pode alcançar o máximo
- Arrays com valores duplicados

## 🤝 Contribuindo

1. Faça um fork do projeto
2. Crie uma branch para sua feature (`git checkout -b feature/AmazingFeature`)
3. Commit suas mudanças (`git commit -m 'Add some AmazingFeature'`)
4. Push para a branch (`git push origin feature/AmazingFeature`)
5. Abra um Pull Request

## 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo `LICENSE` para mais detalhes.

## 👨‍💻 Autor

Desenvolvido como parte de estudos de algoritmos e estruturas de dados.

---

⭐ Se este projeto te ajudou, considere dar uma estrela!
