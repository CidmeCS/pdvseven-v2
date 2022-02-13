; Script generated by the HM NIS Edit Script Wizard.

; HM NIS Edit Wizard helper defines
!define PRODUCT_NAME "Teste"
!define PRODUCT_VERSION "1.0.0"
!define PRODUCT_PUBLISHER "Testes - PDVSeven"
!define PRODUCT_WEB_SITE "http://www.pdvseven.com.br"
!define PRODUCT_DIR_REGKEY "Software\PDV7\${PRODUCT_NAME}"
!define PRODUCT_UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
!define PRODUCT_UNINST_ROOT_KEY "HKLM"

Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"
OutFile "instalador_${PRODUCT_NAME}-${PRODUCT_VERSION}.exe"
LoadLanguageFile "${NSISDIR}\Contrib\Language files\PortugueseBR.nlf"
InstallDir "C:\PDV7"
Icon "PDV7.ico"
UninstallIcon "${NSISDIR}\Contrib\Graphics\Icons\modern-uninstall.ico"
InstallDirRegKey HKLM "${PRODUCT_DIR_REGKEY}" ""
ComponentText "Marque os componentes que queira instalar:"
SetCompressor /SOLID lzma

ShowInstDetails show
ShowUnInstDetails show

SectionGroup /e "Servidor"

	Section /o "Instalar SQL 2008 Express" SEC1C
		SetOutPath "$INSTDIR\Temp"
		SetOverwrite on
		File "instalar_SQL.bat"
		ExecWait "$INSTDIR\Temp\instalar_SQL.bat"
	SectionEnd

SectionGroupEnd
