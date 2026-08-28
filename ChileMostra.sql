create database DBChile;

use DBChile;

create table tbLogin(
Nome varchar(30) not null,
Id int primary key auto_increment,
DataNasc date not null,
Telefone Varchar(14) not null,
Email Varchar(50) not null,
Senha Varchar(8) not null,
ConfirmacaoSenha Varchar(8) not null,
Situacao char(1) not null
);


select * from tbLogin;

