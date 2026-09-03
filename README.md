# Driving and Vehicle License Department (DVLD) System

A comprehensive desktop application designed to manage citizen data, driving license applications, and administrative user workflows. Built using a strict 3-tier architecture to ensure clean separation between the user interface, business logic, and database operations. 

This project is developed as part of a comprehensive software engineering roadmap, focusing on enterprise-level data access patterns and object-oriented design.

## Technical Stack
* **Frontend:** C# Windows Forms (.NET Framework)
* **Backend:** SQL Server 
* **Data Access:** ADO.NET (SqlDataReader, Parameterized Queries)
* **Architecture:** 3-Tier (UI, Business Logic Layer, Data Access Layer)

## Core Architectural Concepts
* **Layered Separation:** The UI strictly communicates with the Business Logic Layer (BLL). All SQL queries, connections, and data parsing are isolated within the Data Access Layer (DAL).
* **Object-Oriented Design:** Utilizes Composition (a User *has a* Person record) for independent entities and Inheritance (a Local Driving License Application *is an* Application) for hierarchical workflows.
* **Hybrid Data Loading:** Optimizes database performance by eager-loading essential JOINs (Applications, People, ApplicationTypes) while lazy-loading secondary data (Users) to minimize connection pool exhaustion.
* **Global State Management:** Caches the authenticated user in memory to reduce redundant database queries during application creation.

## Features (In Progress)
* User & Employee Authentication
* Citizen (Person) Data Management
* Base Application Tracking & Status Management
* Local Driving License Issuance Workflow
* Dynamic Data Filtering via UI Grids

## Setup Instructions
1. Clone the repository.
2. Execute the provided SQL script (to be added) to generate the DVLD database and schema.
3. Update the `DataAccessSettings.connectionString` with your local SQL Server instance name.
4. Build and run the solution in Visual Studio.
