
# Creating Multiple Tables in a Single Database with Entity Framework Core using Code First Approach


![Next Article Preview](preview.jpg)

<br>
<br>
Article :  https://medium.com/@cydexcode/13f0aece15ab

## Overview

This guide outlines the steps to create multiple tables within a single database using Entity Framework Core's code-first approach. It covers project setup, defining database entities, installing required packages, configuring the DbContext class, setting up the connection string, running EF Core migrations, and verifying the database creation.

## Step-by-Step Guide

1. **Project Setup:**
   - Begin by creating a new project in ASP.NET Core Web API.
   - Name your project appropriately (e.g., CreateTwoTablesEF_Core) and select the .NET 8 framework.

2. **Define Database Entities:**
   - Create a "Models" folder within your project if it doesn't exist already.
   - Inside the "Models" folder, create two files named "Entity01.cs" and "Entity02.cs".
   - Define your entity classes within these files, specifying properties such as keys and required fields.

3. **Install Required Packages:**
   - Right-click on your project in the Solution Explorer and select "Manage NuGet Packages...".
   - Search for and install the necessary Entity Framework Core package and any other required packages.

4. **Create DbContext Class:**
   - Generate a class named "EntityDbContext.cs" within the "Models" folder.
   - Inherit from DbContext and include DbSet properties for each of your entity classes.

5. **Configure Connection String:**
   - Add a connection string to your database in the "appsettings.json" file, specifying the server name and database name.

6. **Register DbContext:**
   - In the "ConfigureServices" method of "Startup.cs", register your DbContext using the "AddDbContext" method.

7. **Run EF Core Migrations:**
   - Open the Package Manager Console and execute the "Add-Migration" command followed by "Update-Database" to create the database tables.
   - If any errors occur during the database update, follow the provided instructions to resolve them.

8. **Verification:**
   - Confirm the creation of your database tables by viewing them in SQL Server Management Studio or your preferred database management tool.

9. **Access Full Source Code:**
   - Access the complete source code for this project on the provided GitHub repository link.


---

For a detailed explanation and code snippets, refer to the full article.
