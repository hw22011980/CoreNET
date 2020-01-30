cd "D:/CoreNETGit/"
set /p temp="Copy un-obfuscated libraries"
xcopy /s/e/y/k/d "D:/[Project]/[_BIN]"  "D:/CoreNETGit/Resources/Bin" /exclude:UpdateFromProject.txt
xcopy /s/e/y/k/d "D:/CoreNETGit/Resources/Bin"  "D:/CoreNET/Resources/Bin" /exclude:UpdateFromProject.txt
xcopy /s/e/y/k/d "D:/CoreNETGit/Resources/Bin"  "C:\inetpub\Apps\WebCMSSIPD\bin" /exclude:UpdateFromProject.txt

set /p temp="Hit enter to continue"