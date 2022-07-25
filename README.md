# API Microdados ENEM 2021

Essa é uma API criada para realizar resgate de dados que estão presentes no arquivo disponibilizado pelo [INEP](https://www.gov.br/inep/pt-br), de forma a criar automatizações para quem pretende usar o serviço. O projeto será **Open Source**, já que não há viabilidade para manter os custos de manter a aplicação ASP. Net Core e MySql aberta publicamente online. Desse modo, esse repositório será um **modelo** para criação de API's baseada nos [microdados do ENEM](https://www.gov.br/inep/pt-br/acesso-a-informacao/dados-abertos/microdados/enem).

## Dependências Externas

- .NET 6 (LTS)

## Os dados

Os dados estão sendo disponibilizado em um arquivo [.CSV](https://pt.wikipedia.org/wiki/Comma-separated_values) com espaço em armazenamento de 1,2GB, tendo isso em vista, é inviável utilizar para o desenvolvimento do projeto um banco de dados com mais de **um milhão de linhas**. Desse modo, foi criado uma pasta "Others", que será responsável por disponbilizar as 1.000 linhas limitadas que estamos utilizando e um **dicionário de ajuda**.

## Como rodar o projeto?

Faça o clone do repositório:

```
git clone https://github.com/OtavioVB/api_enem_microdados.git
```

Entre na pasta que acabou de ser criada:

```
cd api_enem_microdados
```

Crie um Banco de Dados MySql e Importe por meio do arquivo `.csv` os dados. Rode o projeto:

```
dotnet run
```

## Atualizações da API

### Buscar informações do Usuário

- **Método**: `GET`
- **Rota**: localhost:7225/api/v1/content/Participante/{NúmeroInscrição}
- **NúmeroInscrição**: Variável correspondente a inscrição do estudante no ENEM (string)
- **Tipo de Retorno**: Lista de Objetos em `JSON`

# Referências

- [Microdados ENEM](https://www.gov.br/inep/pt-br/acesso-a-informacao/dados-abertos/microdados/enem);
