#!/bin/sh

set -e

echo "Running EF Core migrations..."
dotnet ef database update || echo "Migrations skipped"

echo "Starting application..."
exec dotnet DDACAssignment.dll