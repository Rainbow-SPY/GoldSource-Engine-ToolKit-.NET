::[Bat To Exe Converter]
::
::YAwzoRdxOk+EWAjk
::fBw5plQjdAuDJH2L40w8JxpQXziDPWGrCvgYuuHh9qfX8hxTXeEwGA==
::YAwzuBVtJxjWCl3EqQJgSA==
::ZR4luwNxJguZRRnk
::Yhs/ulQjdF+5
::cxAkpRVqdFKZSDk=
::cBs/ulQjdF+5
::ZR41oxFsdFKZSDk=
::eBoioBt6dFKZSDk=
::cRo6pxp7LAbNWATEpCI=
::egkzugNsPRvcWATEpSI=
::dAsiuh18IRvcCxnZtBNQ
::cRYluBh/LU+EWAjk
::YxY4rhs+aU+IeA==
::cxY6rQJ7JhzQF1fEqQJhZksaHGQ=
::ZQ05rAF9IBncCkqN+0xwdVsFAlXMbCXqZg==
::ZQ05rAF9IAHYFVzEqQIXJxdQfwuXLmi/RpAS7+H16qqzrUIRf+srGA==
::eg0/rx1wNQPfEVWB+kM9LVsJDGQ=
::fBEirQZwNQPfEVWB+kM9LVsJDGQ=
::cRolqwZ3JBvQF1fEqQIcKQ5aTwyHLgs=
::dhA7uBVwLU+EWGuF/UwyJwwZfzS7XA==
::YQ03rBFzNR3SWATElA==
::dhAmsQZ3MwfNWATE100gMQldSwyWfCOZT/Uu6eH17eWQ4n4tbaJtKN6Cl+becrRdqmToedY/331SjNhMHh5LewC9awt6yQ==
::ZQ0/vhVqMQ3MEVWAtB9wSA==
::Zg8zqx1/OA3MEVWAtB9wSA==
::dhA7pRFwIByZRRnk
::Zh4grVQjdCuDJH6L+EZwGxRBXgeHfE60AbwS7ajP4OWLiUQJFPppLM/B0vmtDtwn5UroXp85mFlVis5CIBpNcBGjax16rHZH1g==
::YB416Ek+ZG8=
::
::
::978f952a14a936cc963da21a135fa983
@echo off
if exist "C:\Program Files (x86)\dotnet\dotnet.exe" (
	cd /d "C:\Program Files (x86)\dotnet"
	for /f "tokens=1,2 delims= " %%j in (
		'dotnet.exe --info^|find "WindowsDesktop.App 8.0"'
	) do (
		cd /d "%~dp0"
		echo %%j %%k
		if "%%k" equ "8.0.4" (
			cd /d .
			start "" .\ToolKit.Core.App.exe
		) else (

			.\dotnet\setup.exe /q
		)
	)
) else (
	cd /d .
	.\dotnet\setup.exe /q
)