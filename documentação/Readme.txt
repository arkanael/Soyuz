Desafio META

Tecnologias:
Asp.Net WebApi (Arquitetura de microservi�os baseados em REST)
Ado.Net EntityFramework (Repositorio de dados por ORM)
Simple Injector (Framework para Inje��o de Dependencia)

Repositorio de dados
Para que as regras de negocio sejam implementadas � necessario criarmos
um repositorio de acesso a banco de dados que forne�a m�todos para
implementar opera��es de BD.

O objetivo � criar no projeto Dominio interfaces que definam o que deve
ser implementado pela infraestrutura de acesso a banco de dados


Cria��o de uma API

SRP - Principio de Responsabilidade Unica
Cada Classe deve ter uma unica responsabilidade

ISP - Principio de Segrega��o de Interfaces
� sempre melhor criar interfaces espeficicas
do que uma unica interface padr�o.

DIP - Principio de Invers�o de Depend�ncia
Classes de alto niveln�o devem ter contato com classes
de baixo nivel e sim com as suas interfaces.

