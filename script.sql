create database CadastroProdutos;

use CadastroProdutos;

create table usuario(
id int primary key auto_increment,
Nome varchar(40) not null,
Email varchar(40) not null, 
Senha varchar(40) not null
);

create table produtos(
id int primary key auto_increment,
Nome varchar(40) not null,
Descricao varchar(40) not null,
Preco decimal not null,
Quantidade decimal not null
);

select * from CadastroProdutos;