# 🛒 Shopping Cart – ASP.NET Core MVC Project

A web-based shopping cart application built with ASP.NET Core MVC. The system allows users to browse products, add them to a cart, manage their cart items, and proceed to checkout.

---

## 📌 Features

- User-friendly product listing  
- Add to cart / remove from cart  
- Cart quantity adjustment  
- Cart summary and total price calculation  
- Product details page  
- Session-based cart (or database-based if configured)  
- Basic checkout simulation  
- Clean MVC architecture  
- Responsive UI using Bootstrap  

---

## 🛠️ Technologies Used

- ASP.NET Core MVC (.NET 8)  
- Entity Framework Core  
- SQL Server / LocalDB  
- Razor Views  
- Bootstrap 5  
- LINQ, Sessions, Dependency Injection  

---

## 🗂️ Project Structure (with Descriptions)

The project follows a layered MVC architecture and is organized into:

- **Controllers/** – Handle user requests and define the flow of the application logic  
  *(e.g., `ProductController`, `CartController`)*

- **Models/** – Contains entity classes and data models used throughout the system  
  *(e.g., `Product`, `CartItem`)*

- **Views/** – Razor views responsible for rendering the UI, divided into:
  - **Product/** – Pages for product listing and product details  
  - **Cart/** – Pages for viewing and managing the shopping cart  
  - **Shared/** – Layout and shared components *(e.g., `_Layout.cshtml`, `_Navbar.cshtml`)*

- **Data/** – Contains `ApplicationDbContext` and database initialization/seeding logic  

- **wwwroot/** – Stores static files such as CSS, JavaScript, images, and assets  

- **appsettings.json** – Configuration file for database connections and other app settings  

- **Program.cs** – Entry point of the application; configures services, middleware, and routing  

---

## 🧱 Architecture: N-Tiers Design

This project is built using the **N-Tiers Architecture** pattern, which separates the application into distinct logical layers:

- **Presentation Layer** – Responsible for user interaction *(Controllers + Views)*  
- **Business Logic Layer** – Contains core business rules and operations *(Services)*  
- **Data Access Layer** – Handles all data-related operations and queries *(Repositories)*  
- **Data Layer** – Contains EF Core `DbContext` and entity models *(ApplicationDbContext)*  

---

📌 *By applying the N-Tiers Architecture, the project achieves better maintainability, testability, and scalability by clearly separating responsibilities across presentation, business, and data layers.*
