@echo OFF

rem download MS .net runtime and install (require wiget)
rem under developing


rem shortcut creating on parent folder and startup folder

reg Query "HKLM\Hardware\Description\System\CentralProcessor\0" | find /i "x86" > NUL && set OS=32BIT || set OS=64BIT

if %OS%==32BIT 	set AlarmApp="%cd%\x86\Release\net8.0-windows\RoutineAlarm.exe"
if %OS%==64BIT (
	set AlarmApp="%cd%\x64\Release\net8.0-windows\RoutineAlarm.exe"
)


@echo off
echo Set oWS = WScript.CreateObject("WScript.Shell") > CreateShortcut.vbs
echo sLinkFileAutoStartUp = "%userprofile%\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\RoutineAlarm.lnk" >> CreateShortcut.vbs
echo Set oLink = oWS.CreateShortcut(sLinkFileAutoStartUp) >> CreateShortcut.vbs
echo oLink.TargetPath = %AlarmApp% >> CreateShortcut.vbs
echo oLink.Save >> CreateShortcut.vbs

echo sLinkFileShortcut = "%cd%\..\RoutineAlarm.lnk" >> CreateShortcut.vbs
echo Set oLink1 = oWS.CreateShortcut(sLinkFileShortcut) >> CreateShortcut.vbs
echo oLink1.TargetPath = %AlarmApp% >> CreateShortcut.vbs
echo oLink1.Save >> CreateShortcut.vbs
cscript CreateShortcut.vbs
del CreateShortcut.vbs

echo The RoutineAlarm installed successfully
pause