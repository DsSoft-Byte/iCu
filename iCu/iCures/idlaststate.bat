@echo off
title iCu Devicestate
cd C:\iCures\Dependencies\libimdevice\
irecovery.exe -m > C:\iCures\lastdevicestate.txt
pause>nul

