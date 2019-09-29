<p align="center">
  <a href="" rel="noopener">
 <img src="https://imgur.com/Qw4jRwt" alt="Project logo"></a>
</p>
<div align="center">

  [![Status](https://img.shields.io/badge/status-active-success.svg)]() 
  [![GitHub Issues](https://img.shields.io/github/issues/kylelobo/The-Documentation-Compendium.svg)](https://github.com/kylelobo/The-Documentation-Compendium/issues)
  [![GitHub Pull Requests](https://img.shields.io/github/issues-pr/kylelobo/The-Documentation-Compendium.svg)](https://github.com/kylelobo/The-Documentation-Compendium/pulls)
  [![License](https://img.shields.io/badge/license-MIT-blue.svg)](/LICENSE)

</div>

---

## 📝 Table of Contents
- [About](#about)
- [Getting Started](#getting_started)
- [Usage](#usage)
- [Built Using](#built_using)
- [TODO](#TODO)
- [Authors](#authors)

## 🧐 About <a name = "about"></a>
Easy Point of Sales(EPOS) is a point of sales app built for fast casual dinning or retail enviroments. The system is developed on the .NET framework using C# for its backend, MSSQL for database and Winforms for GUI. This project is set up for a Pizza shop right now for user testing. EPOS has a built in user management system, payroll system, inventory managment system, order system and email system. 

## 🏁 Getting Started <a name = "getting_started"></a>

### Prerequisites
A database connection has to be set up to allow EPOS to Run, the code is noted where the DB source connection string is needed.The forms that need to be updated with the DB source connection string are, InventoryMeny.cs, NewUser.cs, OrderScreen.cs,and Payroll.cs. The email system will also need to be updated with a valid email address and passsword. 

```
1.Install .NET 4.7.2 Framework
2.Install Visual Studio IDE
2.Clone EPOS repo
3.Update code where noted 
4.Run exe in C:\Users\user\source\repos\EPOS\EPOS\bin\Debug\EPOS.exe 
```

## 🎈 Usage <a name="usage"></a>
The system can run on any windows system.

## ⛏️ Built Using <a name = "built_using"></a>
- [Visual Studio](https://visualstudio.microsoft.com/) - IDE
- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework/net472) - Framework
- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) - C# backend language
- [MSSql](https://www.microsoft.com/en-us/sql-server/sql-server-2019) - MSSql Server


## ✍️ Authors <a name = "authors"></a>
- [@KAr0ra](https://github.com/KAr0ra)

##  🚧 TODO <a name = "TODO"></a>
- My goal for this project is to rebuild it as a webapp on the ASP.Core Framework. Once it rebuilt anyone on any device will be able to use. 
