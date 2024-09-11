# Animal Shelter API

#### By **Samantha Callie**

#### See below for documentation

## Technologies Used

* C#
* SQL
* ASP.NET Core
* EF Core
* Swagger

## Description

This api allows users to create and manage animals in a database. They can get, post, put and delete animal entires, and get specific number of results starting from a specific place. The default database comes with 25 seeded entires.

## Setup/Installation Requirements

1. Press the green <> Code button and select Download ZIP
2. Unzip file
3. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called "ShelterApi".
4. Within that directory, create a file called `appsettings.json`
5. In `appsettings.json`, paste the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL.
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=cretaceous_api; uid=[YOUR-USERNAME];pwd=[YOUR-PASSWORD];"
  }
}
```
6. To create the database, execute `dotnet ef database update` in the command line (still in the production directory)
    - To optionally create a migration, run the command `dotnet ef migrations add MigrationName`, MigrationName being your name for the migration
7. Now run the command `dotnet run` to compile and execute the application. Then on navigate to https://localhost:612/swagger/index.html.
8. Alternatively, after running it you can use something like Postman to interface with the API

## Known Bugs

* The pagination assumes all animals have sequential Ids, and may give unexpected results if they do not.

# Documentation

### Endpoints:
```
GET  https://localhost:612/api/Animals/

GET  https://localhost:612/api/Animals/{id}

POST  https://localhost:612/api/Animals/

PUT  https://localhost:612/api/Animals/{id}

DELETE  https://localhost:612/api/Animals/{id}
```


## Parameters for Animal GET:
| Parameter| Type | Required | Description 
| -------- | ---- | -------- | ----------
| reference | Number  | Not required | returns only the animal entries with a higher Id than the reference input
| pageSize    | Number | Not required | Returns only that number of animal entries

The following query will return the animals with Ids higher than 7
```
GET  https://localhost:612/api/Animals?reference=7
```

The following query will return the animals with Ids 6 to 10
```
GET  https://localhost:612/api/Animals?reference=5&pageSize=5
```

## Additional Requirements for POST Request

When making a POST request to  https://localhost:612/api/Animals/, you need to include a body. Here's an example body in JSON:

```json
{
  "name": "Jaspers",
  "age": 6,
  "species": "Cat",
  "attitude": "Playful",
  "adoptable": true
}
```
## Additional Requirements for PUT Request
When making a PUT request to  https://localhost:612/api/Animals/{id}, you need to include a body that includes the Animal's `AnimalId` property. Here's an example body in JSON:

```json
{
  "animalId": 2,
  "name": "Jaspers",
  "age": 7,
  "species": "Cat",
  "attitude": "Mysterious",
  "adoptable": false
}
```

And here's the PUT request we would send the previous body to:
```
https://localhost:612/api/Animals/2
```

Notice that the value of animalId needs to match the id number in the URL. In this example, they are both 2.

# License

MIT License

Copyright (c) 2024 Samantha Callie

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.