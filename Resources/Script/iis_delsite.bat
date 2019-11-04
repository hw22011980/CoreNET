%SYSTEMDRIVE%
cd %WINDIR%\System32\inetsrv

appcmd delete app /app.name:"CoreNETCMS/Default"
appcmd delete apppool /apppool.name:CoreNETPool

set /p temp="Hit enter to continue"
