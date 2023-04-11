#!/bin/bash
dotnet nuget add source --username dabaus --password $GITHUB_TOKEN  --store-password-in-clear-text  --name github "https://nuget.pkg.github.com/dabaus/index.json"
