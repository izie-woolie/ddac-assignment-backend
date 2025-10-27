# E-Sports Tournament Management System
System backend develop for Cloud Applications.

## Pre-Requisite
1. Download PostgreSQL in your system.
2. Create a Database with the name: ddac-assignment

## Managing System Secret 
1. To connect to your local PostgreSQL database. Please be safe and safe the connection string as a secret.
2. Open Solution Explorer > Right click on the first item on the tree > Click on Manage User Secrets
3. Paste this with the your database connection string
```
"PostgresConnection":  "Host=localhost;Database={YourDatabaseName};Username={YourUsername};Password={YourPassword};SSL Mode=Disable"
```