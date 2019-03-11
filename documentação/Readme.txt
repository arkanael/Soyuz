Desafio META

Tecnologias:
Asp.Net WebApi (Arquitetura de microserviços baseados em REST)
Ado.Net EntityFramework (Repositorio de dados por ORM)
Simple Injector (Framework para Injeção de Dependencia)

Repositorio de dados
Para que as regras de negocio sejam implementadas é necessario criarmos
um repositorio de acesso a banco de dados que forneça métodos para
implementar operações de BD.

O objetivo é criar no projeto Dominio interfaces que definam o que deve
ser implementado pela infraestrutura de acesso a banco de dados


Criação de uma API

SRP - Principio de Responsabilidade Unica
Cada Classe deve ter uma unica responsabilidade

ISP - Principio de Segregação de Interfaces
É sempre melhor criar interfaces espeficicas
do que uma unica interface padrão.

DIP - Principio de Inversão de Dependência
Classes de alto nivelnão devem ter contato com classes
de baixo nivel e sim com as suas interfaces.

Entity Framework
O Microsoft® ADO.NET Entity Framework é um framework do tipo ORM
(Object/Relational Mapping) que permite aos desenvolvedores trabalhar
com dados relacionais como objetos de domínio específico, eliminando a
necessidade de maior parte dos códigos de acesso de dados que os
desenvolvedores geralmente precisam escrever. Com o Entity Framework,
os desenvolvedores podem lançar consultas usando expressões LAMBDA, e
depois recuperar e manipular dados como objetos fortemente tipificados.
A implementação do ORM do Entity Framework fornece serviços como
rastreamento de alterações, resolução de identidades, lazy loading e
tradução de consultas para que os desenvolvedores possam se concentrar
na lógica de negócios de seus aplicativos em vez dos princípios básicos de
acesso a dados.