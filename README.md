# **Technical Challenge — Inventory Management System (Fullstack .NET + React)**

## 🎯 **Objective**
Develop a web application for product inventory management.  
The application must support full CRUD operations and include additional concerns around software quality, architecture, and scalability.

---

# **1. Technical Requirements**

## **1.1 Backend (.NET 8 + ASP.NET Core + PostgreSQL)**

### 🧩 **API**
Develop a RESTful API using ASP.NET Core Web API.

**Required endpoints:**
- Create product  
- List products (pagination, sorting, filtering)  
- Get product details  
- Update product  
- Delete product  

---

### 🗄️ **Data Model**
The **Product** entity must contain at least:

- Id (GUID)  
- Name (string, required)  
- Description (string)  
- Price (decimal)  
- StockQuantity (int)  
- CreatedAt (DateTime)  
- UpdatedAt (DateTime, optional)  

---

### 💾 **Persistence**
- Database: **PostgreSQL**  
- ORM: **Entity Framework Core**

**Implement:**
- Migrations  
- Fluent API configuration  

---

### 🏗️ **Architecture**
Use a **layered architecture**:

- API (Controllers)  
- Application (Services / Use Cases)  
- Domain (Entities and rules)  
- Infrastructure (Repositories, DB)  

**Additional requirements:**
- Apply **SOLID** principles  
- Use **Repository + Unit of Work** (or justify an alternative)  

---

### 🛡️ **Validation & Error Handling**
- Input validation (e.g., FluentValidation)  
- Global error-handling middleware  
- Consistent responses (e.g., ProblemDetails)  

---

### ⭐ **Additional Features (mid-level+)**
- Soft delete  
- Optimistic concurrency control  
- Structured logging (e.g., Serilog)  
- Support for cancellation tokens  

---

## **1.2 Frontend (React + TypeScript)**

### 🖥️ **Interface**
Main page must include:

- Product list  
- Search by name  
- Pagination  

Forms for:
- Creating a product  
- Editing a product  

---

### 🔄 **State Management**
Use one of the following:

- React Query (TanStack Query)  
- Context API + custom hooks  

Ensure clear separation between logic and presentation.

---

### 🔗 **API Communication**
- Integration with backend  
- Handle loading, error, and empty states  

---

### 🎨 **UI/UX**
- Simple but functional layout  
- Visual feedback for actions (loading, success, error)  

---

### 🎨 **Styling**
Free choice:
- Tailwind  
- CSS Modules  
- Other  

---

# **2. Infrastructure**

## 🐳 **Docker**
Create a `docker-compose.yml` including:

- API  
- Database  
- (Optional) frontend  

---

## ⚙️ **Configuration**
- Environment variables  
- Environment separation (Development / Production)  

---

# **3. Quality & Differentiators**

## 🧪 **Testing**

### Backend:
- Unit tests (xUnit, NUnit, or similar)  
- Integration tests (minimum 1 endpoint)  

### Frontend (bonus):
- Tests using React Testing Library  

---

## 📘 **Documentation**
`README.md` must include:

- Instructions to run the project  
- Technical decisions  
- Future improvements  

---

## ⭐ **Extra Points**
- Simple authentication (JWT)  
- Caching (e.g., MemoryCache)  
- API versioning  
- Well-documented Swagger  

---

# **4. Candidate Instructions**
- Create a GitHub repository.  
- Ensure the project runs with a single command (preferably Docker).  
- Backend and frontend must be properly integrated.  
- Code must be clean, organized, and readable.  
- Delivery deadline: **10 days**.  
- Send the repository link.  

---

# **5. Critical Notes (important for differentiation)**
- Avoid over-engineered solutions without justification — complexity must have purpose.  
- Justify architectural decisions in the README.  
- Functionality alone is not enough: structure, clarity, and maintainability matter.  

**Pay attention to:**
- Consistent naming  
- Separation of concerns  
- Avoid business logic inside controllers  
