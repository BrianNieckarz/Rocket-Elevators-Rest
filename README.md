# Rocket Elevators: RESTful API .NET 6 <!-- omit in toc -->

## Table of Contents <!-- omit in toc -->

- [Project Description](#project-description)
- [Application Requirements](#application-requirements)
- [Using the RESTful API Features](#using-the-restful-api-features)
  - [1. GET Requests Endpoints](#1-get-requests-endpoints)
  - [2. PUT Requests Endpoints](#2-put-requests-endpoints)
- [Credits](#credits)

## Project Description

Rocket Elevators Information System is comprised of two types of application programming interfaces (API), including: (1) Microsoft .NET 6 representational state transfer (RESTful) API and GraphQL query-oriented API. This application repository is concerning the .NET 6 RESTful API, which permits clients to submit a GET and PUT HTTP request using the JavaScript Object Notation format. The remaining types of HTTP requests (i.e. DELETE and POST) are prohibited within the context of this application. Requests can be made to the following URL address: [http://superrocketelevators.azurewebsites.net/api](http://superrocketelevators.azurewebsites.net/api). Examples of requests as Postman collection can be accessed via this [link](https://www.getpostman.com/collections/1b0bdc09588fa3e30fbd).

## Application Requirements

-   [Microsoft .NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
-   [Postman](https://www.postman.com/downloads/) (recommended for submitting HTTP requests)

## Using the RESTful API Features

### 1. GET Requests Endpoints

-   **/battery/id**

    -   Description: Retrieve current status of specific Battery by ID
    -   Example: (Battery ID: 3)

        ```
        curl --location --request GET 'http://thisisrocketelevators.azurewebsites.net/api/battery/3'
        ```

-   **/column/id**
    -   Description: Retrieve current status of specific Column by ID
    -   Example: (Column ID: 10)
        ```
        curl --location --request GET 'http://thisisrocketelevators.azurewebsites.net/api/column/10'
        ```
-   **/elevator/id**
    -   Description: Retrieve current status of specific Elevator by ID
    -   Example: (Elevator ID: 117)
        ```
        curl --location --request GET 'http://thisisrocketelevators.azurewebsites.net/api/elevator/117'
        ```
-   **/elevator/invalid**
    -   Description: Retrieve a list of non-operational Elevators
    -   Example:
        ```
        curl --location --request GET 'http://thisisrocketelevators.azurewebsites.net/api/elevator/invalid'
        ```
-   **/lead/pending**
    -   Description: Retrieve a list of Leads created within the last 30 days that have not been responded to and have not yet become a customer.
    -   Example:
        ```
        curl --location --request GET 'http://thisisrocketelevators.azurewebsites.net/api/lead/pending'
        ```
-   **/building/intervention**
    -   Description : Retrieve a list of Buildings wit at least 1 Building, Column, or Elevator with current status of "intervention"
    -   Example:
        ```
        curl --location --request GET 'http://thisisrocketelevators.azurewebsites.net/api/building/intervention'
        ```

### 2. PUT Requests Endpoints

-   **/battery/id**
    -   Description: Change current status of specific Battery by ID
    -   Example: Changing Building (ID: 10) status to "valid"
        ```
        curl --location --request PUT 'http://thisisrocketelevators.azurewebsites.net/api/battery/10' \
            --header 'Content-Type: application/json' \
            --data-raw '{
                            "id": 10,
                            "status": "valid"
                        }'
        ```
-   **/column/id**
    -   Description: Change current status of specific Column by ID
    -   Example: Changing Building (ID: 5) status to "invalid"
        ```
        curl --location --request PUT 'http://thisisrocketelevators.azurewebsites.net/api/column/5' \
            --header 'Content-Type: application/json' \
            --data-raw '{
                            "id": 5,
                            "status": "invalid"
                        }'
        ```
-   **/elevator/id**

    -   Description: Change current status of specific Elevator by ID
    -   Example: Changing Elevator (ID: 3) status to "valid"

        ```
        curl --location --request PUT 'http://thisisrocketelevators.azurewebsites.net/api/elevator/3' \
            --header 'Content-Type: application/json' \
            --data-raw '{
                            "id": 3,
                            "status": "valid"
                        }'
        ```

## Credits

This project was made possible through the support of:

-   Perry Sawatzky
-   Mathieu Houde
-   Patrick Thibault
-   Francis Patry-Jessop
-   CodeBoxx School of Technology Community
