Resumo da Estrutura do Projeto

a7D.PDV.sln
	Pastas
		Aplica��es -> Projetos finais que ser�o instalador no cliente
		Fiscal -> SAT e NFCe
		Infra -> Instalador, SharedAssemblyInfo, Readme, Componentes, EF, e outros projetos comuns a quase todas aplica��es
		Integra��es -> Projeto das integra�oes usadas no Caixa e Integrador

	* no arquivo 'SharedAssemblyInfo.cs' comum a todos projetos h� um hist�rico das principais altera��es

	2 tipos de "Shared Projects"
		* Quando usado em 'plataformas' diferentes ou sem a necessidade de gerar nova DLL (.Net 4.6.1, .Net Core, Windows Form, WPF)
			- Iaago-BigData, a7D.PDV.Atualizacao.Shared
		* Usados como DLL comum
			- a7D.PDV.BigData.Shared, a7D.PDV.Ativacao.Shared
		
	=> Usa Shared Project de Ativa��es
	=> Usa Shared Project de Iaago-BigData

Ativacoes.sln
	Sistema de Controle de Licen�as
	Publica��o no Azure
		a7D.PDV.Ativacao.API => apipdvseven (https://apipdvseven.azurewebsites.net) 
			WebAPI do sistema de ativa��es, mensagens, envio de erros
		a7D.PDV.Ativacao.UIWeb2 => ativacoespdvseven (http://ativacoes.pdvseven.com.br) 
			Sistema atual de Ativa��es
		Descontinuado\a7D.PDV.Ativacao.WS => wsativacaopdvseven (http://ativacao.pdvseven.com.br) 
			Validador de licen�as para cliente anterior a vers�o 2.13

Iaago-BigData.sln
	ChatBot e BigData API

Metricas
	Entender Applications Insights
    GA / Firebird : usar os indicadores para algo

O instaldor � compilado pelo arquivo "instalador_PDVSeven.nsi" e o instalador do compilador � o "nsis-2.51-setup.exe"
Ap�s instalado o compilador NSIS, clicar no script com bot�o direito e compilar
Sempre na troca de vers�o editar o numero da vers�o do instalador no arquivo ".nsi"
Para criar o atualizador!
Use o menu de contexto do 7Zip e descompacte o instalador, compacte o conteudo como um ZIP e coloque com o nome correto via FTP
em a7D.PDV.Ativacao.UIWeb2\Scripts\ng\Controllers\mensagens-controller.js est� o links das possiveis mensagens

MANTER NO MAXIMO 2 Vers�es ativas em 'Branchs' diferente no git... Em produ��o, e proxima vers�o, para evitar perda de c�digo e conclitos de merge!
A lista detalhada, planejamento, hist�rico de vers�es e d�vidas de software est�o no RoadMap

Roadamp
	https://docs.google.com/document/d/1T0UqhKqQIKcYuXewtrOMA7A7-DB7zj9tJiJovSPlmY8

Roteiro de Testes
	https://docs.google.com/spreadsheets/d/1s_SS8NohYRY1fw3YN-cfaNs0LsCEr4xFY_21FtQVr84

Lista de Funcionalidades:
	https://docs.google.com/document/d/1btwX4zvexmPNwrdQqIQ2QE3I8NxmImUHdaz5Os7Zr3A

Vers�es dos Clientes
http://apipdvseven.azurewebsites.net/clientes.ashx ?cmd=[clear|erro|all]
