# 🏥 Clinic App

> A Windows desktop application for managing clinic/hospital operations, focused on patient management and medical workflows — built with C# and SQL Server.

---

## Table of Contents

- [About](#about)
- [Features](#features)
- [Tech Stack](#tech-stack)
- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)

---

## About

The **Clinic App** (Hospital Management System) is a desktop application designed to streamline clinic operations. It helps medical staff efficiently manage patient records, appointments, and other day-to-day clinical tasks — all from a clean and straightforward Windows interface.

---

## Features

- 👤 **Patient Management** — Add, update, and track patient records
- 🏥 **Hospital Workflow** — Supports core clinic and hospital operations
- 📋 **Medical Records** — Maintain and review patient history

---

## Tech Stack

- **Language:** C# (.NET Framework)
- **UI Framework:** Windows Forms (WinForms)
- **Database:** Microsoft SQL Server
- **IDE:** Visual Studio

---

## Getting Started

### Prerequisites

- Visual Studio 2019 or later
- .NET Framework (4.x recommended)
- Microsoft SQL Server (LocalDB or full instance)
- SQL Server Management Studio (SSMS) — optional but recommended

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/abdelrahman1a/Clinic-App.git
   cd Clinic-App
   ```

2. **Set up the database**
   - Open SQL Server Management Studio
   - Run the provided SQL script to create and seed the database (if included)
   - Update the connection string in the project to match your SQL Server instance

3. **Open the solution**
   - Launch Visual Studio
   - Open `HospitalManagmentSystem.sln`
   - Restore NuGet packages if prompted

4. **Build & Run**
   - Set `HospitalManagmentSystem` as the startup project
   - Press `F5` or click **Start** to run the application

---

## Project Structure

```
Clinic-App/
│
└── HospitalManagmentSystem/         # Main project — UI + Logic
    ├── Forms/                       # Windows Forms screens
    ├── Classes/                     # Business logic and data classes
    ├── Database/                    # SQL scripts / connection helpers
    └── Program.cs                   # Application entry point
```

---

## License

This project is open source and available under the [MIT License](LICENSE).

---

> Built by [Abdelrahman Ahmed](https://github.com/abdelrahman1a) 🛠️
