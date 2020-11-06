create database if not exists dbinsectia default character set = 'utf8' default collate = 'utf8_czech_ci';
use dbinsectia;
create table category(id int not null auto_increment, category varchar(64) not null, primary key(id));
create table item(id int not null auto_increment, name varchar(64) not null, content text not null, idCategory int not null, primary key(id));
alter table item add constraint fk_category_item foreign key(idCategory) references category(id);