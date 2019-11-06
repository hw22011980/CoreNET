%SYSTEMDRIVE%
cd %WINDIR%\System32\inetsrv

appcmd recycle apppool /apppool.name:"CoreNETPool"

set /p temp="Hit enter to continue"


