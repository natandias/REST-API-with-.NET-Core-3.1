# REST API with .NET Core 3.1

A simple REST API that implements CRUD operations on a SQLite database. Its main objective is to save, update and make available for consultation software development related commands.

Based on this [tutorial](https://www.youtube.com/watch?v=fmvcAzHpsk8).

## Getting Started

Install dependencies

```console
dotnet build
```

Generate SQLite database

```console
dotnet ef database update
```

Run code

```console
dotnet run watch
```

You can use [Postman](https://www.postman.com/) to test the API. Import the file _Commander.postman_collection.json_ to save you some time.

## Built with

- [.NET Core 3.1](https://dotnet.microsoft.com/download)
- [SQLite](https://www.sqlite.org/index.html)
