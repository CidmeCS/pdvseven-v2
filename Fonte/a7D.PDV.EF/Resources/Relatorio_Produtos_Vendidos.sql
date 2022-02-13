SELECT p.idPedido AS 'C�d. Pedido' ,
       cl.NomeCompleto AS 'Cliente' ,
       p1.Nome AS 'PDV lan�amento' ,
       u1.Nome AS 'Usu�rio lan�amento' ,
       pp.DtInclusao AS 'Data lan�amento' ,
  (SELECT TOP 1 c.Nome
   FROM tbProdutoCategoriaProduto pcp
   INNER JOIN tbCategoriaProduto c ON c.IDCategoriaProduto = pcp.IDCategoriaProduto
   AND pcp.IDProduto = pp.IDProduto) AS 'Categoria' ,
       pr.Nome AS 'Produto' ,
       pp.Quantidade AS 'Qtd.' ,
       pp.ValorUnitario AS 'Valor unit�rio (R$)' ,
       (pp.ValorUnitario*pp.Quantidade) AS 'Valor total (R$)'
FROM tbPedidoProduto pp
LEFT JOIN tbPedido p ON p.idPedido=pp.idPedido
LEFT JOIN tbCliente cl ON cl.idCliente=p.idCliente
LEFT JOIN tbUsuario u1 ON u1.idUsuario=pp.idUsuario
LEFT JOIN tbPDV p1 ON p1.idPDV=pp.idPDV
LEFT JOIN tbUsuario u2 ON u2.idUsuario=pp.idUsuario_cancelamento
LEFT JOIN tbPDV p2 ON p2.idPDV=pp.idPDV_cancelamento
LEFT JOIN tbProduto pr ON pr.idProduto=pp.idProduto
LEFT JOIN tbCaixa c ON c.idCaixa=p.idCaixa
WHERE c.idFechamento=@idFechamento
  AND pp.Cancelado=0
  AND p.idStatusPedido = 40