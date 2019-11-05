%SYSTEMDRIVE%
cd %WINDIR%\System32\inetsrv
iisreset /START

appcmd delete app /app.name:"CoreNETCMS/Default"
appcmd delete site "CoreNETCMS"
appcmd delete apppool /apppool.name:CoreNETPool

appcmd add site /name:CoreNETCMS  /physicalPath:D:\CoreNET /bindings:http/*:8081:
appcmd add vdir /app.name:"CoreNETCMS/" /path:/SmartDocs /physicalPath:D:\CoreNET\Resources
appcmd add apppool /name:CoreNETPool 
appcmd list apppool /xml "CoreNETPool" | appcmd set apppool /in /enable32BitAppOnWin64:true
appcmd list apppool /xml "CoreNETPool" | appcmd set apppool /in /managedRuntimeVersion:v2.0
appcmd list apppool /xml "CoreNETPool" | appcmd set apppool /in /managedPipelineMode:Classic
appcmd list apppool /xml "CoreNETPool" | appcmd set apppool /in /processModel.idleTimeout:0.00:00:00

appcmd add app /site.name:"CoreNETCMS" /path:/Default /physicalPath:D:\CoreNET\WebCMS
appcmd set app /app.name:"CoreNETCMS/Default" /applicationPool:CoreNETPool

appcmd add app /site.name:"CoreNETCMS" /path:/Debug /physicalPath:D:\CoreNET\WebCMSDebug
appcmd set app /app.name:"CoreNETCMS/Debug" /applicationPool:CoreNETPool

appcmd start apppool /apppool.name:CoreNETPool
appcmd start site /site.name:"CoreNETCMS"

set /p temp="Hit enter to continue"



