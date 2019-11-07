%SYSTEMDRIVE%
cd %WINDIR%\System32\inetsrv

appcmd recycle apppool /apppool.name:"CoreNETPool"
appcmd start apppool /apppool.name:CoreNETPool
appcmd start site /site.name:"CoreNETCMS"


rem set /p temp="Hit enter to continue"


