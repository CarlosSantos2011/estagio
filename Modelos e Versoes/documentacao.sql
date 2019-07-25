
CREATE TABLE tbCliente 
(cpf VARCHAR (11),
dataNascimento date,
sexo VARCHAR (1),
endereco VARCHAR (120))
;

CREATE TABLE tbFornecedor
(cnpj VARCHAR (14),
razaoSocial VARCHAR (50)
)
;

CREATE TABLE dbContatos
(residencial VARCHAR (15),
celular VARCHAR (15),
comercial VARCHAR (15),
email VARCHAR(60))
;

CREATE TABLE tbCompra
( observacoes VARCHAR (100),
dataCompra DATE,
valor double,
iD smallint)
;

CREATE TABLE tbCompraItem
(descontoPorItem double,
quantidade int,
valorUnitario double,
valorTotal double)
;


CREATE TABLE tbEndereco
(logradouro VARCHAR (20),
nomeLogradouro VARCHAR (100),
numero int,
cep VARCHAR (9),
bairro VARCHAR (50),
complemento VARCHAR (20),
cidade VARCHAR (30))
;

CREATE TABLE tbVenda 
(dataVenda date,
formaDePagamento double,
iD int,
desconto double,
valor double)
;

CREATE TABLE tbVendaItem
(valorTotal double,
quantidade int,
valorUnitario int,
descontoPorItem double)
;

CREATE TABLE tbProduto
( iD int,
modelo VARCHAR(20),
quantidade int,
tipo VARCHAR (30),
tempoGarantia int,
nome VARCHAR (20),
descricao VARCHAR (100),
valor double)
;

CREATE TABLE tbEstoque
(  saida int,
entrada int,
garantia bool,
tipoMovimentacao VARCHAR (50))
;














