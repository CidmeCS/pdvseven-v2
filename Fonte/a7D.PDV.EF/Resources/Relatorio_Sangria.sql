SELECT
	 Descricao as 'Descri��o da Sangria' 
	,Valor as 'Valor da Sangria'
	,DtAjuste as 'Data.'
FROM 
	tbCaixaAjuste
WHERE
	IDCaixaTipoAjuste=30
	AND
	DtAjuste BETWEEN  @dtInicio AND  @dtFim
