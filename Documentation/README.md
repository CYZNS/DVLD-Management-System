# 🚗 DVLD — Driving & Vehicle License Department Management System

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET%20WinForms-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)
![ADO.NET](https://img.shields.io/badge/ADO.NET-0078D4?style=for-the-badge&logo=microsoft&logoColor=white)
![Architecture](https://img.shields.io/badge/Architecture-3--Tier-orange?style=for-the-badge)

A full-scale desktop management system simulating real-world government licensing workflows. Engineered from scratch using **C# (.NET Windows Forms)**, **ADO.NET** (without an ORM), and a **14-table normalized SQL Server database** structured under a clean **3-Tier Architecture**.

<!-- Replace with a GIF or Screenshot of your main dashboard -->
![DVLD Dashboard Preview](assets/dashboard-preview.png)

---

## 📋 Table of Contents
- [Key Features](#-key-features)
- [Engineering Highlights](#-engineering-highlights)
- [System Architecture](#-system-architecture)
- [Database Schema (14 Tables)](#-database-schema-14-tables)
- [Screenshots](#-screenshots)
- [Getting Started](#-getting-started)
- [Author](#-author)

---

## ✨ Key Features

### 👥 People & User Management
- Full CRUD operations for managing citizens/applicants with national ID validation, photo storage, and dynamic filtering.
- User authentication system with account activation toggles, password updates, and audit tracking (`CreatedByUserID`) across transactions.

### 📝 Local Driving License Applications & Testing Engine
- End-to-end application tracking with strict business rules (preventing duplicate active applications for the same license class).
- **3-Stage Testing Workflow:** Sequential scheduling and grading for **Vision**, **Written**, and **Street** tests.
- **Automated Retake Handling:** Automatically detects failed prior attempts, generates a linked Retake Test application, calculates combined fees, and locks completed appointments.

### 🪪 Complete License Lifecycle
- **Issue First-Time License:** Converts passed applications into active driver records and licenses with class-based validity periods.
- **Renew License:** Validates expiration status, deactivates the old license, and issues a renewed license automatically.
- **Replacement for Lost / Damaged:** Issues replacement licenses while preserving original expiration dates and deactivating compromised ones.
- **International Driving Licenses:** Validates active ordinary license eligibility and prevents duplicate active international licenses.
- **Detain & Release Management:** Tracks detained licenses with fine records and links release applications to unlock driving privileges.
- **License History:** Dedicated view displaying complete Local and International license records per driver.

---

## 🧠 Engineering Highlights

Beyond implementing the functional requirements, this project focused on writing maintainable, performance-conscious code:

- **Event-Driven Reusable User Controls:** Built composite controls (e.g., `ctrlDriverLicenseInfoWithFilter`, `ctrlScheduleTest`) that communicate with parent forms via C# `event` and `Action<T>` delegates—eliminating code duplication across Renew, Replace, Detain, Release, and International License forms.
- **Optimized ADO.NET Data Access:** Built all SQL interactions manually using parameterized queries (SQL injection protection), deterministic `using` blocks for connection disposal, and lightweight `SELECT TOP 1 1` + `ExecuteScalar()` checks instead of hydrating full objects for boolean validations.
- **Targeted UI Refreshing:** Avoids redundant full-form database reloads by leveraging `DialogResult.OK` and custom save events to refresh only the affected `DataGridView` when changes actually persist.
- **Defensive State Management:** Enforces strict UI state resets when searches fail (preventing stale driver data from remaining on screen), guards `DateTimePicker` ranges against past/locked appointments, and cleanly separates `AddNew` vs. `Update` modes.

---

## 🏗️ System Architecture

The solution follows a strict **3-Tier Architecture** to decouple UI rendering, business rules, and SQL persistence:

```text
DVLD_Solution/
├── DVLD_Project/               # Presentation Layer (WinForms, Reusable User Controls, Guna2 UI)
│   ├── Applications/           # Local, International, Renew, Replace, Detain/Release Forms
│   ├── Appointments/           # Test Scheduling & Evaluation Forms
│   ├── Controls/               # Reusable Composite Controls (License Cards, Filters, Person Cards)
│   ├── Driving_License/        # License Issuance & Driver History
│   ├── People/ & Users/        # Citizen & Account Management
├── DVLD_BusinessLayer/         # Business Logic Layer (Validation Rules, Orchestration)
├── DVLD_DataAccess/            # Data Access Layer (Pure ADO.NET, Parameterized SQL Queries)
└── DVLD.Models/                # Shared Entity Models (Licenses, Drivers, Applications, Tests)
```

---

## 🗄️ Database Schema (14 Tables)

The relational database is normalized in **SQL Server** and covers 14 interconnected tables:
`People`, `Countries`, `Users`, `Drivers`, `Applications`, `ApplicationTypes`, `LocalDrivingLicenseApplications`, `LicenseClasses`, `Licenses`, `InternationalLicenses`, `DetainedLicenses`, `TestTypes`, `TestAppointments`, and `Tests`.

<!-- Export your ERD from SSMS and save it in assets/erd.png -->
![Database ERD](assets/erd.png)

---

## 📸 Screenshots

| Main Dashboard | Manage Applications |
| :---: | :---: |
| ![Dashboard](assets/dashboard.png) | ![Applications](assets/applications.png) |

| Test Scheduling & Retake Flow | Detain / Release License |
| :---: | :---: |
| ![Schedule Test](assets/schedule-test.png) | ![Detain License](assets/detain-license.png) |

---

## 🚀 Getting Started

Follow these steps to run the project locally on your machine.

### Prerequisites
- **Visual Studio 2022** (with *.NET Desktop Development* workload)
- **Microsoft SQL Server** & **SQL Server Management Studio (SSMS)**
- **.NET Framework** (version matching project target, e.g., 4.7.2 / 4.8)

### Installation & Setup

1. **Clone the repository**
   ```bash
   git clone [https://github.com/](https://github.com/)<your-username>/<your-repo-name>.git
   cd <your-repo-name>
   ```

2. **Restore the Database**
   - Open **SQL Server Management Studio (SSMS)**.
   - Restore the provided backup file located in `/Database/DVLD.bak` *(or execute `/Database/DVLD_Schema.sql` to create the database and seed initial lookup tables like `Countries`, `LicenseClasses`, `ApplicationTypes`, and `TestTypes`)*.

3. **Configure the Connection String**
   - Open `DVLD_DataAccess/DataAccessSettings.cs`.
   - Update `connectionString` to match your local SQL Server instance:
```csharp
public static string connectionString = "Server=.;Database=DVLD;Integrated Security=True;TrustServerCertificate=True;";
```

4. **Restore NuGet Packages & Build**
   - Open the `.sln` file in Visual Studio.
   - Right-click the Solution $\rightarrow$ **Restore NuGet Packages** (for **Guna.UI2.WinForms**).
   - Set `DVLD_Project` as the **Startup Project** and press `F5` to run.

### Default Login Credentials (Demo)
| Username | Password |
| :--- | :--- |
| `admin` *(update to your seeded user)* | `1234` *(update to your seeded password)* |

---

## 👨‍💻 Author

**Yazan Aldalati**
- LinkedIn: [https://www.linkedin.com/public-profile/settings/?lipi=urn%3Ali%3Apage%3Ad_flagship3_profile_self_edit_contact_info%3BXQGO%2Fwg7TpicUwHK2iwaAg%3D%3D]
- GitHub: [@your-username](https://github.com/your-username)
