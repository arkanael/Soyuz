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

