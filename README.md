# TinderNew 

# Current position
![](src/website.gif)

## Intro
This repository contains client and server sides for Single Page Application (SPA), called "Dating App" (or, as I call it sometimes, Tinder2.0 or TinderNew). 
This is purely educational project.

## Planned logic of the app
You can login and access list of users who are matched for you. After that you can send them a private message using website messaging system, you can look at their profile and upload some media files into yours.

## Technologies :

1. Client side:
 * Angular 9 
 * Twitter Bootstrap
2. Server side:
 * ASP.NET Core WebAPI
 * Entity framework (ORM)
 * Kestrel as server (it is built-in to ASP.NET core, I have in plans to move to IIS)
 * SQLite (for development, once I am going to publish it I will migrate to MySQL)
 3. Third-party modules:
 * alertifyjs
 * Angular JWT Helper
 * ngx-bootstrap
 * bootswatch
 
 ## Logic of the program : 
- Currently it is simple : there is a database, storing `username`,`passwordHash` and `passwordSalt` in *USERS* table and temporary table *VALUES* for API functionality testing purposes. Two server instance are running simultaneously : `kestrel` for RESTful API at `localhost:5000` and `ng serve` for Angular at `localhost:4200` (it is needed, because I use Angular routing). Angular sends requests to `localhost:5000/api/...` and, because CORS (cross origin resource sharing) in backend (ASP.NET WebAPI) currently set in such a way that everything is allowed - client side gets values in `JSON` format and displays them on the main page. 
- **Routing** : I used Angular routing with guard protection, so unauthorized users can not access pages as `/lists`, `/messages`, and `/members`. 
- **Security** is now simply JWT authorization, token in stored in local web storage and deleted upon logout. In the commit on March 18th 2020 I added JWT helper to Angular for token date validation and displaying name of the user. HTTP requests, connected with authentication are `POST`.
 
 **LAST UPD** : 19.03.2020, Angular routing added.
  
 **NEXT MOVE** : Extend API.

