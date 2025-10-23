create database CadastroProdutos;

use CadastroProdutos;

create table usuario(
id int primary key auto_increment,
nome varchar(40) not null,
email varchar(40) not null, 
senha varchar(40) not null
);

create table produtos(
id int primary key auto_increment,
nome varchar(40) not null,
descricao varchar(40) not null,
preco int not null,
quantidade int not null
);