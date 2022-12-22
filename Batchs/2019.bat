@echo off
mode con: cols=87 lines=20
title Activate Microsoft Office 2019&cls&echo =====================================================================================&echo #Project: Activating Microsoft software products&echo =====================================================================================&echo.&echo #Supported products:&echo - Microsoft Office Standard 2019&echo - Microsoft Office Professional Plus 2019&echo.&echo.&(if exist "%ProgramFiles%\Microsoft Office\Office16\ospp.vbs" cd /d "%ProgramFiles%\Microsoft Office\Office16")&(if exist "%ProgramFiles(x86)%\Microsoft Office\Office16\ospp.vbs" cd /d "%ProgramFiles(x86)%\Microsoft Office\Office16")&(for /f %%x in ('dir /b ..\root\Licenses16\ProPlus2019VL*.xrm-ms') do cscript ospp.vbs /inslic:"..\root\Licenses16\%%x" >nul)&(for /f %%x in ('dir /b ..\root\Licenses16\ProPlus2019VL*.xrm-ms') do cscript ospp.vbs /inslic:"..\root\Licenses16\%%x" >nul)&echo.&echo =====================================================================================&echo Activating your Office...&cscript //nologo ospp.vbs /unpkey:6MWKP >nul&set i=1&cscript //nologo ospp.vbs /inpkey:NMMKJ-6RK4F-KMJVX-8D9MJ-6MWKP >nul ||goto notsupported
:skms
if %i% GTR 10 goto busy
if %i% EQU 1 set KMS=kms.digiboy.ir
if %i% EQU 2 set KMS=kms.chinancce.com
if %i% EQU 3 set KMS=kms.ddns.net
if %i% EQU 4 set KMS=xykz.f3322.org
if %i% EQU 5 set KMS=dimanyakms.sytes.net
if %i% EQU 6 set KMS=kms.03k.org
::----------MSGUIDES SERVERS----------
if %i% EQU 7 set KMS=ms8.us.to
if %i% EQU 8 set KMS=s8.uk.to
if %i% EQU 9 set KMS=s9.us.to
::----------Legacy----------
if %i% EQU 10 set KMS=kms9.msguides.com
if %i% EQU 11 set KMS=kms8.msguides.com
if %i% GTR 11 goto ato
cscript //nologo ospp.vbs /sethst:%KMS% >nul
:ato
echo =====================================================================================&echo.&echo.&cscript //nologo ospp.vbs /act | find /i "successful" || (echo The connection to my KMS server failed! Trying to connect to another one... & echo Please wait... & echo. & echo. & set /a i+=1 & goto skms)
goto halt
:notsupported
echo =====================================================================================&echo.&echo Sorry, your version is not supported.&echo.&goto halt
:busy
echo =====================================================================================&echo.&echo Sorry, the server is busy and can't respond to your request. Please try again.&echo.
:halt
pause >nul