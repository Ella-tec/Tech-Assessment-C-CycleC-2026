 
# 🚀 Tech Assessment – C# Cycle C 2026

<p align="center">

  <img src="https://img.shields.io/badge/Assessment-Cycle%20C%202026-2563EB?style=for-the-badge" alt="Assessment"/>
  <img src="https://img.shields.io/badge/Status-Corrected%20%26%20Completed-16A34A?style=for-the-badge" alt="Status"/>
  <img src="https://img.shields.io/badge/Documentation-README-7C3AED?style=for-the-badge" alt="Documentation"/>

</p>

<p align="center">
  **A corrected and improved collection of technical assessment tasks covering C#, SQL, API integration, and database design.**
</p>

---

## 👋 Project Overview

Welcome to the **Tech Assessment – C# Cycle C 2026** repository!

This repository contains the corrected and completed versions of the assessment tasks. Each task demonstrates practical technical skills, problem-solving, code improvement, data handling, and database design.

The goal of this assessment is to demonstrate not only the ability to write code, but also the ability to review existing work, identify problems, improve solutions, and document technical decisions.

## ✨ Assessment Summary

| Task | Topic | Status |
|---|---|---|
| 🟢 Task 1 | C# Programming and Logic | Corrected & Improved |
| 🔵 Task 2 | SQL Query and Database Analysis | Completed |
| 🟣 Task 3 | API Integration and Error Handling | Fixed |
| 🟠 Task 4 | Entity Relationship Diagram (ERD) and SQL Schema | Completed |

## 🛠️ Summary of Corrections

This version includes the following improvements:

### 🟢 Task 1 – C# Programming

- Improved code readability and organization.
- Added clearer comments.
- Improved input handling with explicit null protection.
- Corrected the logic for identifying positive even numbers and doubling them.
- Improved the explanation of the solution.

### 🔵 Task 2 – SQL Query

- Added the missing SQL query.
- Used a `LEFT JOIN` to connect employees and orders.
- Counted orders for each employee.
- Grouped results by employee first name.
- Sorted the results by order count in descending order.

**Purpose:** Demonstrate how related database tables can be queried to produce useful business information.

### 🟣 Task 3 – API Integration

- Added the missing `.env` configuration example.
- Added a `.gitignore` file.
- Improved environment-file path handling.
- Added more reliable error handling.
- Improved the API response processing.
- Extracted post titles from the JSONPlaceholder API.

**Purpose:** Demonstrate how an application can retrieve external data, process JSON responses, and handle errors safely.

### 🟠 Task 4 – Database Design

- Added an Entity Relationship Diagram (ERD).
- Identified the main database entities.
- Explained primary keys (PK) and foreign keys (FK).
- Added SQL `CREATE TABLE` statements.
- Explained the relationships between tables.
- Documented one-to-many relationships and how tables connect.

**Purpose:** Demonstrate how a relational database can organize customers, employees, orders, products, and order details.

---

## 🧩 Technologies Used

| Technology | Purpose |
|---|---|
| C# | Programming and application logic |
| SQL | Database queries and table creation |
| SQL Server | Relational database design |
| REST API | Retrieving external data |
| JSON | Processing API responses |
| `.env` | Managing environment configuration |
| `.gitignore` | Excluding unnecessary or sensitive files |
| Mermaid / ERD | Visualizing database relationships |
| Git & GitHub | Version control and project submission |

## 📁 Project Contents

The assessment is organized around four main tasks:

```text
Tech-Assessment-C-CycleC-2026/
│
├── README.md
│
├── Task 1/
│   └── C# programming solution
│
├── Task 2/
│   └── SQL query and explanation
│
├── Task 3/
│   ├── API integration
│   ├── .env.example
│   └── .gitignore
│
└── Task 4/
    ├── Task 4.md
    ├── Task4_ERD.png
    └── SQL schema
```

*Note: The folder and file names above are an example layout. Keep the actual names used in your repository.*

## 🗄️ Task 4 – Database Relationship Overview

The database design includes five main entities:

- **Customers:** Stores customer information.
- **Employees:** Stores employee information.
- **Orders:** Records customer orders and the employees handling them.
- **OrderDetails:** Stores individual product lines belonging to an order.
- **Products:** Stores product information.

### 🔗 How the relationships work

| Relationship | Meaning |
|---|---|
| Customers → Orders | One customer can place many orders. |
| Employees → Orders | One employee can handle many orders. |
| Orders → OrderDetails | One order can contain multiple product lines. |
| Products → OrderDetails | One product can appear in multiple order-detail records. |

**Primary Key (PK):** Uniquely identifies each record in a table.

**Foreign Key (FK):** Connects a record to a related record in another table.

The `OrderDetails` table connects orders and products. This resolves the many-to-many relationship between them.

## 🎯 Project Learning Objectives

Through these tasks, this assessment demonstrates the ability to:

- Write and improve C# code.
- Identify and correct programming issues.
- Build SQL queries using joins, grouping, and sorting.
- Connect to an external REST API.
- Read and process JSON data.
- Manage environment configuration safely.
- Design relational database tables.
- Understand primary and foreign keys.
- Create and explain an ERD.
- Use GitHub to organize and submit technical work.

## 📤 Submission Instructions

Before submitting, make sure that:

- [ ] All four task folders or files are included.
- [ ] Corrected code and SQL queries are saved.
- [ ] Task 3 includes the required configuration examples.
- [ ] No passwords, API keys, or private credentials are committed.
- [ ] Task 4 includes the ERD and SQL schema.
- [ ] The README accurately describes the submitted files.
- [ ] All required changes are committed and pushed to GitHub.

### Git commands

```bash
# Check changed files
git status

# Add the assessment files
git add .

# Commit your changes
git commit -m "Complete corrected Cycle C technical assessment"

# Push to GitHub
git push
```

## 🛡️ Responsible Development

This assessment emphasizes reviewing and testing technical work rather than accepting suggestions without verification.

Good development practices include:

- Review code before accepting changes.
- Test solutions with normal and edge-case inputs.
- Protect passwords, API keys, and private information.
- Keep configuration examples separate from real secrets.
- Document technical decisions and limitations.
- Verify database relationships and query results.

## 👨‍💻 Author

**Eliyas Eshtea**

**Project:** Tech Assessment – C# Cycle C 2026

**Submission:** Corrected Version

---

<p align="center">

  **🌟 Learn • Build • Test • Improve 🌟**

  *Building practical technical skills through problem-solving and continuous improvement.*

</p>
