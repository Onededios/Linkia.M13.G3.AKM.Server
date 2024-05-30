# Linkia.M13.G3.AKM.Server

## Overview

This .NET application is organized into multiple layers, each serving a specific purpose to ensure a clean, maintainable, and scalable architecture. Below is a detailed description of each layer and its responsibilities:

### Layers

#### Application

The Application layer contains the API with its controllers. This is the entry point for client requests and is responsible for handling HTTP requests, processing them, and returning appropriate responses.

Controllers: Define the endpoints and the logic to handle HTTP requests.

#### Library

The Library layer includes Data Transfer Objects (DTOs) and services. This layer facilitates the transfer of data between the application and the infrastructure layers, ensuring a clear separation of concerns.

DTOs: Define the data structures used to transfer data.
Services: Contain business logic and interact with the repositories.

#### Infrastructure

The Infrastructure layer is where entities, repositories, and the database context for Entity Framework are created. This layer is responsible for data persistence and retrieval.

Entities: Represent the data models.
Repositories: Encapsulate the logic required to access data sources.
DatabaseContext: Manages the connection to the database and handles data operations using Entity Framework.

#### Cross-Cutting Concerns

The Cross-Cutting Concerns (Xcutting) layer includes functionality that is used across multiple layers, such as logging, exception handling, and configuration settings.

#### Database

The Database layer contains scripts for creating the database using Docker Compose. This ensures a consistent and reproducible database environment for development, testing, and production.

Scripts: SQL and Docker Compose scripts to set up and initialize the database.

#### Test

The Test layer includes unit tests for all layers of the application. This ensures the reliability and correctness of the code through automated testing.

Unit Tests: Tests for validating the functionality of individual components.


## Getting Started

To get started with the application, follow these steps:

Clone the repository.
Navigate to the Database folder and run the Docker Compose script to set up the database.
Build the solution.
Run the application.

## License

This project is licensed under the MIT License.