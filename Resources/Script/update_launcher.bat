taskkill /IM CoreNETLauncher.exe

cd "D:\CoreNET\Resources\Script"
xcopy /s/e/y/k/d "D:\CoreNET\Resources\Script\UpdateLauncher" "D:\CoreNET\Launcher" /exclude:update_launcher.txt

rem set /p temp="Hit enter to continue"

D:\CoreNET\Launcher\CoreNETLauncher.exe

