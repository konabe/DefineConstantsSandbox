#!/bin/bash

if [ $1 = 1 ]; then
  msbuild ./DefineConstantsSandbox.sln /p:DevNum=1 /p:DOG=true /p:Configuration=Debug /t:Rebuild
  msbuild ./DefineConstantsSandbox.sln /p:DevNum=1 /p:Configuration=Release /t:Rebuild
  echo "---------------"
  echo "- /p:DevNum=1 -"
  echo "---------------"
else
  msbuild ./DefineConstantsSandbox.sln /p:DevNum=2 /p:CAT=true /p:Configuration=Debug /t:Rebuild
  msbuild ./DefineConstantsSandbox.sln /p:DevNum=2 /p:Configuration=Release /t:Rebuild
  echo "---------------"
  echo "- /p:DevNum=2 -"
  echo "---------------"
fi

echo "---------------"
echo "-    DEBUG    -"
echo "---------------"
dotnet ./HOGEHOGE/bin/netcoreapp3.1/DefineConstantsSandbox.dll

echo ""
echo "---------------"
echo "-   RELEASE   -"
echo "---------------"
dotnet ./FUGAFUGA/bin/netcoreapp3.1/DefineConstantsSandbox.dll

