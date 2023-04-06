# BigStar
To run Project

System required:
- Visual studio 2022
- Microsoft SQL Server Management


Run project step by step:
1. Create Database in MSSM named BigStar or restore database from .bak file from SQL folder.
2. In Visual Studio, Open appsetting.json, at "ApplicationContextConnection" row, replace Server value by your server name in MSSM. 
3. In Visual Studio, Tool > Nuget Package Manager > Package Manager Console, the console will open at the bottom. Run command "Update-Database".
4. Run the project.
