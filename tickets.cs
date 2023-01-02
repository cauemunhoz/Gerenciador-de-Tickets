"Create DataBase" BD_SYSBeauty;
go
"use" BD_SYSBeauty;
go
"SET" DATEFORMATE DMY;


"Create Table" InformaçõesdoFuncionário(
    ID "int primary key identity" (0,1),
    NOME "varchar"(100) "not null",
    CPF "varchar"(11) ,
    Situação do Cadastro "varchar" (1)
    

);
"Insert into" InformaçõesdoFuncionário (nome) "values" ('Sistema')


"Create Table" Tickets(

NOME "int primary key identity" (100)
QUANTIDADE "varchar" (200)
Armazem "varchar" (100)

);
"Inset into" Tickets (Data, Hora, ID, NOME)
"values" ('01/01/1900', '00:00', 0, 0)
"Isert into" Tickets (QUANTIDADE) " values" ('Sistema')
