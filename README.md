[![MIT License][license-shield]][license-url]

<!-- PROJECT LOGO -->
<br />
<p align="center">
  <a href="https://github.com/RTSTALER/NanoSurvey">
    <img src="https://nanosurvey.com/wp-content/themes/nano-survery/dist/images/logo.png" alt="Logo">
  </a>

  <h3 align="center">NanoSurvey</h3>

  <p align="center">
    ⚠️ (Work In Progress)
    <br />
    <a href="https://github.com/RTSTALER/NanoSurvey/issues">Report Bug</a> |
    <a href="https://github.com/RTSTALER/NanoSurvey/issues">Request Feature</a>
    <br />
  </p>

</p>
<!-- ABOUT THE PROJECT -->

## About The Project

My test task, I tried to keep within the minimum of the code, and to make it easy to read, enjoy

Tech. Stack:

ASP .NET Core, PostgreSQL,

### How to Start

* Change the connection string inside appsettings.json (I'm sorry, I could not build a docker-compose file for simplified launch of the database and application, due to problems with Windows, I can fix it if necessary)
* ```Update-Database```  run EF Core migrations
* I was not sure that pre-filling is necessary here, so I just put the TestData.sql file with some data
* ```docker-compose up -d``` 
* Start APS NET Core application

### Route

#### GET /api/Survey/{id}  Get question for id

Response example: 

```json
{
  "id": 2,
  "description": "Like Drink",
  "surveyId": 1,
  "answers": [
    {
      "id": 3,
      "value": "Sprite",
      "questionId": 2
    },
    {
      "id": 4,
      "value": "Water",
      "questionId": 2
    }
  ]
}
```

#### POST /api/Survey/ Send Answer

Receive body:

```json
{
  "answerId": 0,
  "questionId": 0,
  "userId": 0 
}
```

Response:

```json
{
    "id": 2,
    "isEnd": false
}
```

## You can also see my other apps as code examples (not .NET)

###### [Echpochmak](https://github.com/wintexpro/echpochmak) - Echpochmak, is a framework based on TONOS Client Library for TON DApp development
###### [Halva](https://github.com/halva-suite/halva) - Halva is a toolchain for developing Decentralized Applications based on Substrate. 
[license-shield]: https://img.shields.io/github/license/RTSTALER/NanoSurvey.svg?style=flat-square
[license-url]: https://github.com/RTSTALER/NanoSurvey/blob/master/LICENSE
