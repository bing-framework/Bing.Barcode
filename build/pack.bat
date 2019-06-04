@echo off
echo %1
cd ..

rem clear old packages
del output\* /q/f/s

rem build
dotnet build Bing.Barcode.sln -c Release

rem pack
dotnet pack ./src/Bing.Barcode/Bing.Barcode.csproj
dotnet pack ./src/Bing.Barcode.QRCoder/Bing.Barcode.QRCoder.csproj
dotnet pack ./src/Bing.Barcode.ZXing/Bing.Barcode.ZXing.csproj

rem push
for %%i in (output\release\*.nupkg) do dotnet nuget push %%i -k %1 -s https://www.nuget.org/api/v2/package