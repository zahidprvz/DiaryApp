# 📖 DiaryApp

A clean, structured, production-style CRUD application built with **ASP.NET Core MVC + Entity Framework Core + SQL Server**.

This project is part of my journey to build a **series of production-ready full stack applications** using:

* ASP.NET Core (Backend)
* Razor Pages / MVC (Server-side Rendering)
* SQL Server (Database)
* Angular (Frontend – upcoming projects)
* Enterprise backend architecture concepts

---

## 📸 Screenshots

<img width="1918" height="807" alt="image" src="https://github.com/user-attachments/assets/8f8536a9-9dd8-46aa-bd2b-867b72548056" />
<img width="1918" height="803" alt="image" src="https://github.com/user-attachments/assets/a50448cf-c6bd-4f07-87ef-d4c8ddf98dfa" />
<img width="1917" height="805" alt="image" src="https://github.com/user-attachments/assets/4c7cc950-72f3-4a78-a231-4c9d03834c5d" />
<img width="1919" height="810" alt="image" src="https://github.com/user-attachments/assets/0855946f-9068-4f34-9b95-946112058151" />

---

## Project Overview

DiaryApp is a fully functional diary management system that allows users to:

* ✅ Create diary entries
* ✅ View all entries
* ✅ Edit existing entries
* ✅ Delete entries
* ✅ Validate user input
* ✅ Seed initial database data

The application follows clean architectural principles and demonstrates real-world backend practices.

---

## 🛠 Tech Stack

### 🔹 Backend

* ASP.NET Core MVC
* Entity Framework Core
* LINQ
* Data Annotations Validation
* Dependency Injection

### 🔹 Database

* SQL Server
* Code-First Migrations
* Seed Data via `HasData()`

### 🔹 Frontend

* Razor Views
* Bootstrap 5
* Server-side rendering
* Model binding & validation

---

## 🏗 Architecture & Concepts Applied

This project demonstrates:

* MVC architecture
* Clean separation of concerns
* Dependency Injection
* Entity Framework Core migrations
* Model validation using Data Annotations
* Strongly typed Razor views
* CRUD operation patterns
* Basic UI/UX structuring with Bootstrap
* Seed data best practices (static deterministic seeding)

---

## 📂 Project Structure

```
DiaryApp/
│
├── Controllers/
│   └── DiaryEntriesController.cs
│
├── Data/
│   └── ApplicationDbContext.cs
│
├── Models/
│   └── DiaryEntry.cs
│
├── Views/
│   └── DiaryEntries/
│       ├── Index.cshtml
│       ├── Create.cshtml
│       ├── Edit.cshtml
│       └── Delete.cshtml
│
└── Migrations/
```

---

## 🗄 Database Setup

This project uses **Entity Framework Core Code-First Approach**.

To run locally:

```bash
Add-Migration InitialCreate
Update-Database
```

The database will be created automatically with seeded entries.

---

## 🎯 Key Learning Highlights

During this project I practiced:

* Handling migration errors and model snapshot issues
* Fixing dynamic seed data problems
* Understanding expression trees & strongly-typed views
* Model validation with custom error messages
* Working with DbContext lifecycle
* Building structured CRUD flows

---

## 🔮 Upcoming Enhancements

This project is part of a larger roadmap.

Next improvements may include:

* Pagination
* Search functionality
* Sorting
* Toast notifications
* Delete confirmation modal
* Role-based authentication
* REST API version
* Angular frontend version
* Clean architecture refactor
* Repository & Service pattern
* Async EF operations
* Unit testing

---

## 🧠 Learning Roadmap

I am currently building a series of full-stack applications to master:

* Advanced ASP.NET Core
* Clean Architecture
* SOLID principles
* REST APIs
* Angular frontend integration
* Authentication & Authorization
* Production deployment strategies
* Logging & error handling
* Performance optimization

---

## 🏁 How to Run

1. Clone the repository
2. Configure connection string in `appsettings.json`
3. Run:

```bash
Update-Database
```

4. Press F5 / Run the project
---

## ⭐ If You Like This Project

Feel free to star the repository and follow my journey.

---
