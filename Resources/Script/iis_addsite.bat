%SYSTEMDRIVE%
cd %WINDIR%\System32\inetsrv
iisreset /START
appcmd add site /name:CoreNETCMS  /physicalPath:c:\inetpub\wwwroot /bindings:http/*:8080:
appcmd add apppool /name:CoreNETPool 
appcmd list apppool /xml "CoreNETPool" | appcmd set apppool /in /enable32BitAppOnWin64:true
appcmd list apppool /xml "CoreNETPool" | appcmd set apppool /in /managedRuntimeVersion:v2.0
appcmd list apppool /xml "CoreNETPool" | appcmd set apppool /in /managedPipelineMode:Classic
appcmd list apppool /xml "CoreNETPool" | appcmd set apppool /in /processModel.idleTimeout:0.00:00:00
appcmd add app /site.name:"CoreNETCMS" /path:/CoreNET /physicalPath:D:\CoreNET\WebCMS
appcmd set app /app.name:"CoreNETCMS/Default" /applicationPool:CoreNETPool
appcmd add vdir /app.name:"CoreNETCMS/" /path:/CoreNETDocs /physicalPath:D:\docs
appcmd start apppool /apppool.name:CoreNETPool
appcmd start site /site.name:"CoreNETCMS"

 
set /p temp="Hit enter to continue"


