# School Management System

A full-stack **School Management System** starter skeleton built with React JS and ASP.NET Core Web API.

---

## 🗂️ Project Structure

```
SchoolManagementSystem/
├── backend/
│   ├── SchoolManagement.API/            ← Controllers, Program.cs, appsettings.json
│   ├── SchoolManagement.Application/    ← Services, Interfaces, DTOs
│   ├── SchoolManagement.Domain/         ← Entities (Student, Teacher, Class, Subject)
│   ├── SchoolManagement.Infrastructure/ ← DbContext, Repository implementations
│   └── SchoolManagement.slnx
│
├── frontend/
│   └── school-ui/                       ← React + Vite app
│
├── README.md
└── .gitignore
```

---

## 🛠️ Tech Stack

| Layer      | Technology                          |
|------------|-------------------------------------|
| Frontend   | React JS (Vite), React Router v6    |
| Backend    | ASP.NET Core Web API (.NET 8)       |
| ORM        | Entity Framework Core 8 (Code First)|
| Database   | SQL Server / LocalDB                |
| API Docs   | Swagger (Swashbuckle)               |

---

## ⚙️ Getting Started

### Backend

```bash
# Open solution in Visual Studio or run via CLI:
cd backend
dotnet restore
dotnet build

# Run the API (Swagger UI at https://localhost:{port}/swagger)
dotnet run --project SchoolManagement.API
```

> **Database:** Update the connection string in `appsettings.json` then run:
> ```bash
> dotnet ef migrations add InitialCreate --project SchoolManagement.Infrastructure --startup-project SchoolManagement.API
> dotnet ef database update --project SchoolManagement.Infrastructure --startup-project SchoolManagement.API
> ```

### Frontend

```bash
cd frontend/school-ui
npm install
npm run dev
# App runs at http://localhost:5173
```

---

## 📋 API Endpoints (Placeholders)

| Method | Route               | Description        |
|--------|---------------------|--------------------|
| GET    | /api/students       | List all students  |
| GET    | /api/students/{id}  | Get student by ID  |
| POST   | /api/students       | Create student     |
| PUT    | /api/students/{id}  | Update student     |
| DELETE | /api/students/{id}  | Delete student     |
| GET    | /api/teachers       | List all teachers  |
| GET    | /api/classes        | List all classes   |
| GET    | /api/subjects       | List all subjects  |

---

## 🏗️ Architecture

```
┌─────────────────────────────────────────────────┐
│                   React Frontend                │
│   (Pages → Components → Services → API calls)  │
└───────────────────┬─────────────────────────────┘
                    │ HTTP / REST
┌───────────────────▼─────────────────────────────┐
│              ASP.NET Core Web API               │
│  Controllers → Application Services → Repos     │
│                   ↕ EF Core                     │
│                SQL Server Database              │
└─────────────────────────────────────────────────┘
```

---

## 🚧 Status

This is a **starter skeleton** only. The following features are ready to be implemented:

- [ ] Full CRUD for Students, Teachers, Classes, Subjects  
- [ ] Authentication & Authorization (JWT)  
- [ ] Dashboard with statistics  
- [ ] Form validation  
- [ ] Real database migrations & seeding  
- [ ] Frontend API integration  

---

## 📄 License

MIT
