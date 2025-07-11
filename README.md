## 🎯 E-Commerce  

### 💡 Overview  
This is an ASP.NET Web API project designed to manage an e-commerce system. The project includes various components such as:  

- **Entities**: Customer, Order, Product, ShoppingCart  
- **Data Transfer Objects (DTOs)**: CustomerDTOs, OrderDTOs, ProductDTOs, ShoppingCartDTO  
- **Repositories**: Interfaces and implementations for Customer, Order, Product, and ShoppingCart data management  
- **Models**: AppDbContext and EF Core migrations for database schema  
- **Controllers**: Organized to handle API requests and responses for customers, orders, and products  

The project is structured to provide a robust backend service with features for creating, managing, and retrieving data related to customers, orders, products, and shopping carts. It utilizes a clean architecture with separate layers for data, business logic, and API interfaces.  

### ✨ Features  
- RESTful API endpoints for CRUD operations  
- Entity Framework Core for data access and management  
- Repository pattern for clean data abstraction  
- Organized file structure for scalability and maintainability  

### 🌐 API Endpoints  
- **POST /api/customers**: Create a new customer profile  
- **GET /api/customers/{id}**: Retrieve customer details by ID  
- **PUT /api/customers/{id}**: Update existing customer information  
- **DELETE /api/customers/{id}**: Remove a customer profile  
- **POST /api/orders**: Place a new order  
- **GET /api/orders/{id}**: Retrieve order details by ID  
- **PUT /api/orders/{id}**: Update an existing order  
- **DELETE /api/orders/{id}**: Cancel an order  
- **POST /api/products**: Add a new product  
- **GET /api/products/{id}**: Get product information by ID  
- **PUT /api/products/{id}**: Edit product details  
- **DELETE /api/products/{id}**: Remove a product from the catalog  
