# DESAFIO TARGET API

# Cadastrar um Cliente
[POST] https://localhost:44347/Cadastro

```json
body = 
      {
        "Nome":"Paulo Almeida",
        "DataNascimento":"2020-07-01",
        "Enderecos":[
            {
              "Logradouro": "Rua 1",
              "Numero":100,
              "Complemento": "Complemento 1",
              "Bairro":"Bairro 1",
              "Cidade":"Cidade 1",
              "Estado":"RS"
            },
            {
              "Logradouro": "Rua 2",
              "Numero":200,
              "Complemento": "Complemento 2",
              "Bairro":"Bairro 2",
              "Cidade":"Cidade 2",
              "Estado":"SP"
              }
          ]
      }
 ```     

# Editar um Cliente
[PUT] https://localhost:44347/Cadastro
```json
body = 
      {
        "Id":1,
        "Nome":"Paulo Machado de Almeida",
        "DataNascimento":"2020-07-01",
        "Enderecos":[
            {
              "Id":1,
              "Logradouro": "Rua 10",
              "Numero":100,
              "Complemento": "Complemento 10",
              "Bairro":"Bairro 10",
              "Cidade":"Cidade 10",
              "Estado":"RJ"
            },
            {
              "Id":2,
              "Logradouro": "Rua 2",
              "Numero":200,
              "Complemento": "Complemento 2",
              "Bairro":"Bairro 2",
              "Cidade":"Cidade 2",
              "Estado":"SP"
              }
          ]
      }
```  

# Deletar um Cliente
[DELETE] https://localhost:44347/Cadastro/{idCliente}

# Deletar 1 Endereço do Cliente
[DELETE] https://localhost:44347/Cadastro/{idCliente}/{idEndereco}

# Obter 1 Cliente
[GET] https://localhost:44347/Cadastro/{idCliente}

```json
{
  "Id":1,
  "Nome":"Paulo Machado de Almeida",
  "DataNascimento":"2020-07-01",
  "Enderecos":
  [
     {
        "Id":1,
        "Logradouro": "Rua 10",
        "Numero":100,
        "Complemento": "Complemento 10",
        "Bairro":"Bairro 10",
        "Cidade":"Cidade 10",
        "Estado":"RJ"
      },
      {
         "Id":2,
         "Logradouro": "Rua 2",
         "Numero":200,
         "Complemento": "Complemento 2",
         "Bairro":"Bairro 2",
         "Cidade":"Cidade 2",
          "Estado":"SP"
       }
    ]
}
```

# Obter TODOS os Cliente
[GET] https://localhost:44347/Cadastro

```json
[
  {
    "Id":1,
    "Nome":"Paulo Machado de Almeida",
    "DataNascimento":"2020-07-01",
    "Enderecos":
    [
       {
          "Id":1,
          "Logradouro": "Rua 10",
          "Numero":100,
          "Complemento": "Complemento 10",
          "Bairro":"Bairro 10",
          "Cidade":"Cidade 10",
          "Estado":"RJ"
        },
        {
           "Id":2,
           "Logradouro": "Rua 2",
           "Numero":200,
           "Complemento": "Complemento 2",
           "Bairro":"Bairro 2",
           "Cidade":"Cidade 2",
            "Estado":"SP"
         }
      ]
  },
    {
    "Id":2,
    "Nome":"Cliente 2",
    "DataNascimento":"2020-07-01",
    "Enderecos":
    [
       {
          "Id":3,
          "Logradouro": "Rua das Flores",
          "Numero":600,
          "Complemento": "",
          "Bairro":"Flores",
          "Cidade":"Flores",
          "Estado":"RJ"
        },
        {
           "Id":4,
           "Logradouro": "Rua Tulipas",
           "Numero":150,
           "Complemento": "Complemento 2",
           "Bairro":"Tulipas",
           "Cidade":"Tulipas",
            "Estado":"SP"
         }
      ]
  }
]
```
