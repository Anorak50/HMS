# MediCore HMS: Hospital Management System

A desktop Hospital Management System built with **C# WinForms** and **SQL Server**. It covers patient registration, doctor management, appointment scheduling, billing and medical records, with role-based access for five user types. Developed as an academic project for Object-Oriented Programming 2 (OOP2).

## Features

| Role | Capabilities |
|---|---|
| **Admin** | Manage doctors, view all patients, manage appointments, generate billing reports, search records, **activate/disable/ban user accounts** |
| **Receptionist** | Register patients, book appointments (with availability check), view patient history, generate invoices, search records |
| **Doctor** | View assigned appointments, view patient details, add/update diagnosis and notes, mark appointments Completed/Pending |
| **Patient** | View profile, appointments, assigned doctor, billing info and medical history |
| **HR Staff** | Manage doctor info, schedules and contact details, search staff |

### Account Activation Flow
1. A new user signs up, and their account is created with `Status = 0` (Inactive).
2. Login is blocked until an Admin sets the account to `Status = 1` (Active).
3. Admins manage accounts from the **Manage Users** panel.

| Status | Meaning |
|---|---|
| 0 | Inactive (pending approval) |
| 1 | Active |
| 2 | Disabled |
| 3 | Banned |

## Tech Stack

- C# / .NET Framework, Windows Forms
- SQL Server Express (`System.Data.SqlClient`)
- Visual Studio
- OOP principles: encapsulation, inheritance, abstraction, object relationships

## Database

Main tables: `User`, `Patient`, `Doctor`, `Appointment`, `DoctorSchedule`, `Invoice`, `InvoiceItems`.
Invoices follow the rule *one appointment = one invoice, one invoice = many items*.

## Getting Started

1. **Clone the repo**
```bash
   git clone https://github.com/Anorak50/HMS.git
```
2. **Create the database** in SQL Server: create `HMS_DB` and run the SQL script to create the tables.
3. **Set the connection string** in `DB.cs`:
```csharp
   Data Source=YOUR_SERVER\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True
```
4. Open the solution in **Visual Studio** and press **F5**.
5. Insert an initial Admin row with `Status = 1` so you can log in and approve other users.

## Project Structure

```
HMS/
├── DB.cs                 # Shared connection helper
├── AppTheme.cs           # Colors and UI styling
├── Entities/             # Model classes
├── LoginForm.cs          # Role-based login with status check
├── SignUpForm.cs         # Patient self-registration (Status = 0)
└── Dashboards/           # Admin, Receptionist, Doctor, Patient, HR
```

## Team

- Taslim Sarker
- Nafis Imtiaz (login and receptionist part)
- Md. Mahfuzur Rahman
- Md Korshed Alam

Department of Computer Science, American International University-Bangladesh (AIUB)
