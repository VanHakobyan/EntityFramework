LINQ to Entities Query Creation and Execution Process

Construction of an ObjectQuery instance out of an ObjectContext (Entity Connection)

Composing a query either in C# or Visual Basic (VB) by using the newly constructed instance

Conversion of standard query operators of LINQ as well as LINQ expressions into command trees

Executing the query passing any exceptions encountered to the client directly

Returning to the client all the query results

ObjectContext is here the primary class that enables interaction with Entity Data Model or in other words acts as a bridge that connects LINQ to the database. Command trees are here query representation with compatibility with the Entity framework.

The Entity Framework, on the other hand, is actually Object Relational Mapper abbreviated generally as ORM by the developers that does the generation of business objects as well as entities as per the database tables and facilitates various basic operations like create, update, delete and read. The following illustration shows the entity framework and its components.
