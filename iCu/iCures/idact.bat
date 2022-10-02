@echo off
title iCu main activator
cd C:\iCures\Dependencies\libimdevice
ideviceactivation activate -s 127.0.0.1/sliver.php -d
:: ideviceactivation activate -s localhost/sliver.php -d
:: ideviceactivation -s 127.0.0.1/idact.php
pause>nul
