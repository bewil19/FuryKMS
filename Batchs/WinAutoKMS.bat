@echo off
mode con: cols=87 lines=20
title Activate Microsoft Windows 10 - 11 (All Versions)&cls&echo =====================================================================================&echo #Project: Activating Microsoft software products for FREE&echo =====================================================================================&echo.&echo #Supported products:&echo - Windows 10 - 11 Home&echo - Windows 10 - 11 Professional&echo - Windows 10 - 11 Education&echo - Windows 10 - 11 Enterprise&echo.&echo.&echo =====================================================================================&echo Activating your Windows...
:skms
if %i% GTR 10 goto busy
if %i% EQU 1 set KMS=s8.uk.to
if %i% EQU 2 set KMS=s9.us.to
if %i% GTR 3 goto ato
:ato
echo =====================================================================================&echo.&echo.&cscript //nologo slmgr.vbs /ato | find /i "successfully" || (echo The connection to my KMS server failed! Trying to connect to another one... & echo Please wait... & echo. & echo. & set /a i+=1 & goto skms)
goto halt
:busy
echo =====================================================================================&echo.&echo Sorry, the server is busy and can't respond to your request. Please try again.&echo.
:halt
pause >nul