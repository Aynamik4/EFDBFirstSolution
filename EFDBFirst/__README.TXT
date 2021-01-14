EF NuGet installation
=====================
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools

EF-Scaffolding - D.v.s. generera Context och Entity klasser.
============================================================
Scaffold-DbContext "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EFDBFirst;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False" Microsoft.EntityFrameworkCore.SqlServer -OutputDir "Models/Entities" -Context "EFDBFirstContext" -Force