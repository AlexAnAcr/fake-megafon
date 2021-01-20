@echo off
title Megafon Modem Error
echo MegaFon Modem started.
:start
echo MegaFon Modem: Loading...
nircmd.exe cdrom open f:
echo MegaFon Modem: megafon CD is not found!
echo MegaFon Modem: CD room opened.
nircmd.exe cdrom close f:
echo MegaFon Modem: CD room closed.
goto start