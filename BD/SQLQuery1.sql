insert into CLIENTE values(1, 'Kirk', 'Enterprise', 10);
insert into CLIENTE values(2, 'Spock', 'Enterprise', 9);
insert into CLIENTE values(3, 'Scotty', 'Enterprise', 8);
insert into CLIENTE values(4, 'Bones', 'Enterprise', 8);
insert into CLIENTE values(5, 'Gorn', 'PlanetoidArena', 1);
insert into CLIENTE values(6, 'Khan', 'CetiAlphaFive', 2);
insert into CLIENTE values(7, 'Uhura', 'Enterprise', 7);
insert into CLIENTE values(8, 'Chekov', 'Enterprise', 6);
insert into CLIENTE values(9, 'Sulu', 'Enterprise', 6);

insert into ITEM values(125, 'phaser', 350, 2);
insert into ITEM values(137, 'beam', 1500, 250);
insert into ITEM values(143, 'shield', 4500, 3000);
insert into ITEM values(175, 'fusionMissile', 2750, 500);
insert into ITEM values(211, 'captainsLog', 50, 2);
insert into ITEM values(234, 'starShip', 25000, 15000);
insert into ITEM values(356, 'sensor', 245, 15);
insert into ITEM values(368, 'intercom1', 200, 75);
insert into ITEM values(399, 'medicalKit', 75, 3);

insert into PEDIDO values(10058, 1, 211, 1, 50);
insert into PEDIDO values(12001, 1, 234, 1, 25000);
insert into PEDIDO values(10266, 2, 356, 1, 12250);
insert into PEDIDO values(10042, 3, 137, 50, 4500);
insert into PEDIDO values(10371, 4, 399, 3,750);
insert into PEDIDO values(10012, 5, 125, 2, 700);
insert into PEDIDO values(11775, 6, 125, 3, 1050);
insert into PEDIDO values(10023, 6, 175, 20, 55000);
insert into PEDIDO values(10232, 7, 368, 1, 1200);
insert into PEDIDO values(11593, 8, 125, 2, 700);
insert into PEDIDO values(11070, 9, 143, 1, 4500);


SELECT DISTINCT * FROM PEDIDO
SELECT * FROM CLIENTE
SELECT * FROM ITEM

SELECT DISTINCT COUNT(DISTINCT c.NOME) AS qtd_clientes FROM CLIENTE c, PEDIDO p WHERE QUANTIDADE >= 1; 

SELECT i.DESCRICAO FROM ITEM i, PEDIDO p  WHERE i.ID_ITEM = p.ID_ITEM AND p.CUSTO = (SELECT MAX(CUSTO) FROM PEDIDO);
SELECT DISTINCT CUSTO FROM PEDIDO
SELECT * FROM ITEM
SELECT MAX(CUSTO) FROM PEDIDO


