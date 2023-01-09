<img src="https://media.licdn.com/dms/image/C4D0BAQFb0bZla2jbkw/company-logo_200_200/0/1622565821434?e=2147483647&v=beta&t=GA-igH_8LQIIWW54DvHIzM6gbnA284cQutpnhOTP7AA" >

# DesafioConcert

## 📘 Descrição:
- [x] Criar um projeto de automação de testes utilizando o Selenium WebDriver com o Dotnet na
versão mais recente. 
- [x] Automatizar a página de busca do Google validando os pontos que forem importantes para assegurar que a página está funcionando conforme o esperado. 
- [x] Crie quantos cenários de automação achar necessário.
- [x] Avaliar e criticar a usabilidade da página de buscas do Google.
- [x] Documentar todo o processo para subir a aplicação, preferencialmente no arquivo
“README”

## 📝 Pré-requisitos para rodar o projeto: 
- **Dotnet version:** 7.0.101
- **Selenium WebDriver version:** 4.7.0 
- **Selenium ChromeDriver version:** 108.0.5359.7100
- **MSTest framework version:** 2.2.7
- **Visual Studio IDE 2022:** https://visualstudio.microsoft.com/pt-br/downloads/

## ⚙️ Como rodar a aplicação:

Clonar repositório 
```
git clone https://github.com/MhelenaGomes/DesafioConcert.git
```

Acesse a pasta do projeto:
```
cd DesafioConcert
```

Abrir arquivo DesafioConcert.sln no Visual Studio

No explorador de arquivos, clique com o botão direito no arquivo UnitTest1.cs e selecione a opção 'Executar testes'.
Após o build, os testes irão rodar automaticamente através Chromedriver configurado.

### Casos de teste:
- **Pesquisar texto 'Concert' (PesquisaTextoConcert())**  
_Descrição do teste:_ Verifica se retorna os resultados correspondentes a pesquisa do texto “Concert Tecnologies”.

- **Pesquisa através do botão 'Estou com sorte' (PesquisaEstouComSorte())**   
_Descrição do teste:_ Verifica se está sendo encaminhado corretamente a página https://www.concert.com.br/ após selecionar o botão estou sorte.

- **Pesquisar por palavra escrita incorretamente (PesquisaPalavraEscritaIncorretamente())**  
_Descrição do teste:_ Verifica se ao pesquisar uma palavra escrita de forma errada, a página retorna com uma sugestão exibindo a palavra corretamente.

## Sobre a usabilidade do google.com:
- Possui uma ótima usabilidade ao utilizar o campo de pesquisa, a ferramenta oferece sugestões de palavras que ajudam o usuário efetuar a sua pesquisa de forma mais rápida e correta.
- Apresenta um layout simples onde a página exibe apenas um campo de busca, por conta disso se torna uma ferramenta fácil utilização.

