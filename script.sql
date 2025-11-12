create database CadastroProdutos;

use CadastroProdutos;

create table usuario(
id int primary key auto_increment,
Nome varchar(40) not null,
Email varchar(40) not null, 
Senha varchar(40) not null
);

create table produto(
id int primary key auto_increment,
Nome varchar(40) not null,
Descricao varchar(40) not null,
Preco decimal not null,
Quantidade decimal not null
);

insert into usuario (Nome,Email, Senha) values ('usuario','usuario@gmail.com','1234');

select * from usuario;
select * from produto;

-- drop database cadastroprodutos;