@echo off
if exist "%SystemRoot%\SysWOW64" path %path%;%windir%\SysNative;%SystemRoot%\SysWOW64;%~dp0
bcdedit >nul
if '%errorlevel%' NEQ '0' (goto UACPrompt) else (goto UACAdmin)
:UACPrompt
%1 start "" mshta vbscript:createobject("shell.application").shellexecute("""%~0""","::",,"runas",1)(window.close)&exit
exit /B
:UACAdmin
chcp 65001
cd /d "%~dp0"
set WORK_DIR=%~dp0
echo 当前路径是：%CD%
echo 已获取管理员权限


@echo off
rem 判断64位系统和32位系统
if /i %PROCESSOR_IDENTIFIER:~0,3%==x86 (
    echo 32位操作系统
    cd /d x86
) else (
    echo 64位操作系统
    cd /d x64
)
echo 当前运行路径是：%CD%
set snkFile=%WORK_DIR%AbpPro.snk
echo snk输出目录：
echo %snkFile%
sn -k %snkFile%
pause