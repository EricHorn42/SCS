# 📦 Stock Control System

O Stock Control System é um sistema de controle de estoque desenvolvido para auxiliar empresas a gerenciar eficientemente seus produtos e inventários. Este sistema oferece uma solução completa para monitorar o fluxo de produtos, gerenciar estoques, realizar pedidos de reposição e gerar relatórios detalhados sobre o desempenho do estoque.

</br>

## 📝 Funcionalidades Principais

- **Gerenciamento de Produtos:** Cadastre e atualize informações detalhadas sobre os produtos em estoque, incluindo nome, descrição, categoria, preço, quantidade disponível, etc.

- **Controle de Estoque:** Acompanhe o estoque em tempo real e receba alertas quando os níveis de estoque estiverem baixos, ajudando a evitar a falta de produtos.

- **Pedidos de Reposição:** Faça pedidos de reposição automaticamente com base nos níveis de estoque atuais, garantindo que os produtos estejam sempre disponíveis para os clientes.

- **Rastreamento de Movimentações:** Registre todas as entradas e saídas de produtos no sistema para um rastreamento preciso do histórico de movimentação de estoque.

- **Relatórios e Análises:** Gere relatórios personalizados sobre o desempenho do estoque, vendas de produtos, tendências de demanda e muito mais para auxiliar na tomada de decisões estratégicas.

</br>

## 🔨 Instalação

Para instalar e executar o Stock Control System em seu ambiente local, siga estas etapas:

Clone o repositório do projeto para o seu computador:
```bash
  git clone https://github.com/seu-usuario/stock-control-system.git
```

Navegue até o diretório raiz do projeto:
```bash
  cd stock-control-system
```

</br>

## ⚠️ Criando Issues

Ao contribuir para o Stock Control System ou trabalhar em projetos similares, é importante seguir algumas diretrizes ao criar issues. Aqui estão as regras usuais que podem ajudar a garantir que as issues sejam criadas de forma eficaz e produtiva:

### Descrição Clara e Concisa
Certifique-se de descrever o problema, a tarefa ou a funcionalidade de forma clara e concisa, evitando ambiguidades.

### Atribuição de Responsabilidade
Atribua a issue a um membro específico da equipe responsável por resolvê-la ou implementá-la.

### Priorização Adequada
Priorize a issue com base em sua importância e urgência em relação a outras tarefas do projeto.

### Especificação de Contexto
Forneça informações de contexto relevantes, como logs de erro, capturas de tela e passos para reproduzir um problema.

### Referência a Outras Issues
Se a issue estiver relacionada a outras issues existentes, faça referência a elas na descrição para manter a consistência e a visibilidade do trabalho relacionado.

### Definição de Critérios de Aceitação
Para issues de implementação de funcionalidades, defina critérios de aceitação claros que descrevam o que deve ser alcançado para considerar a issue concluída.

</br>

## 💬 Padrão de Commit

> Esta prática passou a ser adotada a partir de Março de 2024.

</br>

O Stock Control System utiliza o padrão de commit [Conventional Commits](https://www.conventionalcommits.org/en/v1.0.0/) para manter um histórico de alterações organizado e compreensível.

Resumidamente o mais comum no projeto será:

```
<type>[optional scope]: <description>

[optional body]
```

### Tipo
Indica a natureza da alteração realizada. Alguns tipos comuns incluem:

- feat: Para adicionar uma nova funcionalidade ou recurso.
- fix: Para corrigir um bug ou problema.
- refactor: Para realizar alterações no código que não alteram seu comportamento externo.
- docs: Para atualizar a documentação.
- style: Para realizar alterações de formatação no código (por exemplo, espaçamento, formatação de código).
- test: Para adicionar ou modificar testes.
- chore: Para realizar tarefas de manutenção ou outras tarefas não relacionadas ao código.

> `Breaking Changes` ou alterações correspondentes a versão `MAJOR` devem ter o tipo sucedido de `!`

### Escopo (opcional)

Indica a parte do código que foi modificada (por exemplo, um módulo específico, um componente, etc.).

### Descrição (opcional)

Breve descrição da alteração realizada.

### Exemplo

```
feat(api)!: send an email to the customer when a product is shipped
```

</br>

## Versionamento

O Stock Control System adere ao Versionamento Semântico 2.0.0 para gerenciar as versões do software de forma consistente e previsível. O Versionamento Semântico é um conjunto de regras e convenções para atribuir números de versão a releases de software com base nas mudanças semânticas introduzidas.

### Estrutura de Versão

O número de versão é composto por três partes: MAJOR.MINOR.PATCH. Cada parte tem um significado específico:

- **MAJOR:** Incrementado quando são feitas alterações incompatíveis na API, indicando uma nova versão que pode exigir atualizações significativas para integração ou utilização.

- **MINOR:** Incrementado quando funcionalidades são adicionadas de forma compatível com versões anteriores, indicando a introdução de novas funcionalidades ou melhorias.

- **PATCH:** Incrementado quando correções de bugs são realizadas de forma compatível com versões anteriores, indicando a resolução de problemas ou falhas no software.

### Pré-lançamentos e Metadados

O Versionamento Semântico permite a inclusão de pré-lançamentos e metadados adicionais após o número de versão. Um pré-lançamento é indicado por um sufixo de identificador de tipo (por exemplo, alpha, beta, rc), enquanto metadados adicionais podem ser fornecidos com um hífen (por exemplo, build metadata, build number).

```
  1.0.0-alpha+001
```

### Exemplo de Versão

Aqui está um exemplo de como uma versão pode ser incrementada de acordo com as regras do Versionamento Semântico:

 - **1.0.0:** Versão inicial do software.
 - **1.1.0:** Adiciona uma nova funcionalidade de busca de produtos.
 - **1.1.1:** Corrige um bug na funcionalidade de busca.
 - **2.0.0:** Introduz alterações incompatíveis na API ao refatorar o sistema de autenticação.

</br>

## 🪪 Licença

Este projeto está licenciado sob a Licença MIT. Consulte o arquivo LICENSE para obter mais detalhes.
