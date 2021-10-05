# Instructions to run API

### Software to install
* Dotnet 5
* MS SQL (Developer Edition)
* SSMS (SQL Server Management Studio)

### Steps to run 
1. Open project using *.sln or *.csproj file
2. Restore all dependencies using Nuget Restore
3. Create Database called dbSentenceConstruction using SSMS
4. Run Migrations on Database using `update-database` command in terminal
5. Open Database and confirm tables have been created and populated with seed data   
6. Set Start to project name
7. Start application

### PS: Swagger UI should show on successful startup