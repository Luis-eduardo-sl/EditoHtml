# EditoHtml

Este é um editor de HTML escrito em C# para exercitar meus conhecimentos. Ele permite criar, editar e visualizar arquivos HTML.

## Funcionalidades

- Abrir arquivo existente
- Criar novo arquivo
- Visualizar arquivo HTML

## Como Usar

1. Clone o repositório para o seu ambiente local:
  
     ```sh
    git clone https://github.com/seu-usuario/seu-repositorio.git
    ```

3. Abra o projeto no Visual Studio Code.

4. Compile o projeto utilizando o comando:
    ```sh
    dotnet build
    ```

5. Execute o programa utilizando o comando:
    ```sh
    dotnet run
    ```
    
6. Siga as instruções no console para abrir, editar ou visualizar arquivos HTML.

## Exemplo de Uso

Ao iniciar o programa, você verá o menu com as opções:

- Para abrir um arquivo existente, digite `2` e forneça o caminho do arquivo.
- Para criar um novo arquivo, digite `1` e comece a digitar seu texto. Pressione `Esc` para finalizar a edição e salvar o arquivo.
- Para sair do programa, digite `0`.

  ## Arquivos Principais

- `Program.cs`: Ponto de entrada do programa
- `Menu.cs`: Exibe o menu principal e lida com as opções do usuário.
- `Editor.cs`: Permite criar e editar arquivos HTML.
- `Viewer.cs`: Permite visualizar arquivos HTML formatados.




