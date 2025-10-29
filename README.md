# E-Sports Tournament Management System

System backend develop for Cloud Applications.

## Pre-Requisite

1. Download PostgreSQL in your system.
2. Create a Database with the name: ddac-assignment
3. Install Docker and Docker Desktop

## Managing System Secret

1. To connect to your local PostgreSQL database. Please be safe and safe the connection string as a secret.
2. Open Solution Explorer > Right click on the first item on the tree > Click on Manage User Secrets
3. Paste this with the your database connection string

```json
"PostgresConnection":  "Host=localhost;Database={YourDatabaseName};Username={YourUsername};Password={YourPassword};SSL Mode=Disable"
```

## Docker

### Create Images

```bash
$ docker build -t <name:versioning> .
```

### Docker Compose

1. Up with .env variables

```bash
$ docker compose up -d
```

2. Down

```bash
$ docker compose down
```
