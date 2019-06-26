cd ..
cd DDS\DDS_Windows
call release.bat
ospl start file://DDSDomain.xml
cd ..\..
cd FDMSubscriber\FDMSubscriber\bin\Debug
call FDMSubscriber.exe

cmd

