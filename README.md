<p align="center"><img src="https://i.ytimg.com/vi/E_YJ8vLt-t8/maxresdefault.jpg"></p><br>
### Introduction

Entity framework is one of the most powerful ORM (Object Relation Mapper) frameworks. It is generally used as a Data Access layer in the application. Initially Entity framework came with fewer features and limited functionality. There were continuous changes made in the Entity framework as a result, entity framework has become more powerful  and comes with lots of new features in every release. In this article, we will discuss what are the new features available in Entity Framework 7.

Firstly, we will discuss what items are removed from Entity Framework 7 and we will discuss new features of Entity Framework.

The following Items no longer supported in Entity Framework 7,

### EDMX Support

EDMX (Entity Model Data XML) is no longer supported in Entity framework 7. This means that Entity framework 7 only support code first approach. EDMX file stores everything in one file and it may view in Entity framework designer and contains tightly coupled mappings configurations and contexts.

### ESQL support

Entity SQL is preferable way to execute LINQ to Entity. Now, ESQL is no longer supported by Entity framework 7.

### Automatic Migration

Generating database schema from entity model is called migration. There are many techniques available for performing migration likes explicitly adding migrations through code by using PM (package manager) console. There are alternative methods are available called Automatic Migration. In automatic migration, migrations were done in run time. This Automatic migration is supported by Entity framework 7.

### ObjectContext API support

DbContext class was introduced in Entity framework 4.1. Up to entity framework 4, ObjectContext Class is used to manage all the database operations and manages various entities of the Entity Model. DbContext is conceptually similar to ObjectContext. DbContext is nothing but a ObjectContext wrapper, we can say it is a lightweight alternative to the ObjectContext. Up to entity framework 6.x, ObjectContext API is continuing for the backwards compatibility purpose. This API has been removing in new version.

Apart from these, other two features Metadata Workspace API and MEST (Multiple Entities for Single Type) Mapping are also discontinued in the new version.

### EF 7 is now Open source

Like EF 6, EF 7 is also open source. EF 6 codes available on CodePlex but EF 7 is on GitHub along with the upcoming version of ASP.NET.Now we can explore the source code, participate in discussions, raise issues and submit pull requests to the examine team.

### Lightweight and extensible

Entity Framework 7 is now very lightweight. It contains only very common features. The components of EF are easy to replace and extend.EF 6.1.3 is about 10 MB and it includes 5MB of entity framework DLL for .NET 4.5. EF 7 comes in much smaller sizes DLLs as compare to EF 6. We will combine the DLLs necessary to support our workflow.

### Support new Platforms

Entity Framework 7 now supports the following types of application:

* All .NET application (Console, ASP.NET 4, WinForms, WPF)
* Mac and Linux applications (Mono)
* UWP (Universal Windows Platform)
* ASP.NET 5 applications
* Can use EF 7 in Windows phone and Windows store app
* New Data Stores

Up to the Entity Framework 6, it is clearly tied to relational data stores. Now Entity framework also supports many non-relational data stores. The support is includes change tracking, LINQ, and unit of work. Also, EF 7 will be enabling providers that can be used to support non-relational data stores. 

### Supported providers in Entity Framework 7

* SQL Server
* Azure Table Storage
* SQLite
* In Memory (for unit testing)
* SQL Server Compact
* PostgreSQL
* IBM Data Servers
* NoSQL database is very popular because of the performance of CRUD operations  is much faster than other relational database. NoSQL  database is good choice when we have large amount of data process. Entity Framework 7 now provides support to non-relational databases so we can use NoSQL database with EF.

### Support for unit testing

Unit test is helping us to test blocks of code. Now, Unit test is much simpler  with Entity Framework 7. Entity framework 7 now supports in-memory tables.

### Logging

Entity Framework 7 has built-in logging feature. To use this logger feature, we need to implement ILoggerProvider interface. Hopefully it is supported with all platforms. This logging feature is also present in EF 6.x.

### Support Cascade Delete

Cascade delete allows us to automatic delete child records when parent data is deleted. In other words, all related data will be deleted when parent data is deleted. Entity framework 7 support cascade delete.

### Shadow Properties

Shadow Properties are properties which are not present in our entity model class. They can participate in queries, we can also perform create/ update operation. The values can be changed and maintained by the ChangeTracker API.

### Summary 

Entity framework 7 comes with very powerful features. There are many performance related changes incorporated in EF 7. Microsoft will continue to support EF 6.x and also provide new release of EF 6.x for bug fixes and small improvements.
