# Book Heaven - Bookstore Management System

## Project Overview
Book Heaven is a comprehensive bookstore management system developed as an academic project. This Windows Forms application provides a complete solution for managing bookstore operations, including inventory management, sales, customer management, and supplier relationships.

## Features
- **User Authentication**
  - Secure login system with role-based access (Admin and Cashier)
  - Password encryption using BCrypt

- **Inventory Management**
  - Book catalog management with ISBN tracking
  - Stock quantity monitoring
  - Genre categorization (Fictions, Non-Fictions, Collectibles, Education Materials)
  - Price management

- **Order Processing**
  - Support for both pickup and delivery orders
  - Order status tracking (Pending, Processing, Sent, Fulfilled, Canceled)
  - Delivery cost calculation
  - Order history

- **Customer Management**
  - Customer profile creation and management
  - Contact information tracking
  - Order history per customer

- **Supplier Management**
  - Supplier information management
  - Contact details tracking
  - Supply chain integration

## Technical Stack
- **Framework**: .NET 8.0 Windows Forms
- **Database**: MySQL (MariaDB)
- **ORM**: Entity Framework Core 6.0.1
- **Security**: BCrypt.Net-Next for password hashing
- **Database Provider**: Pomelo.EntityFrameworkCore.MySql

## Project Structure
```
BookHeaven/
├── Actions/         # Business logic and operations
├── Assets/          # Static resources
├── Components/      # Reusable UI components
├── Enums/          # Enumeration definitions
├── Helpers/        # Utility and helper classes
├── Models/         # Data models
├── Screens/        # UI forms and screens
│   ├── Dashboard/  # Main dashboard components
│   └── Forms/      # Modal forms
└── Util/           # Utility functions
```

## Database Schema
The system uses a relational database with the following main tables:
- `book`: Stores book information
- `customer`: Manages customer data
- `order`: Tracks orders
- `order_item`: Manages order details
- `supplier`: Stores supplier information
- `user`: Handles user authentication
- `inventory_record`: Tracks inventory changes

## Setup Instructions
1. **Prerequisites**
   - .NET 8.0 SDK
   - MySQL Server (MariaDB 10.4.32 or compatible)
   - Visual Studio 2022 or compatible IDE

2. **Database Setup**
   - Create a new MySQL database named `book_heaven`
   - Import the `DataBase.sql` file to set up the schema and initial data

3. **Application Setup**
   - Clone the repository
   - Open the solution in Visual Studio
   - Update the database connection string in the application configuration
   - Build and run the application

## Default Login Credentials
- **Admin Account**
  - Email: admin@sample.com
  - Password: (Please contact administrator for initial password)

- **Cashier Account**
  - Email: cashier@sample.com
  - Password: (Please contact administrator for initial password)

## Security Features
- Password hashing using BCrypt
- Role-based access control
- Secure database connections
- Input validation and sanitization

## Contributing
This is an academic project. For any questions or suggestions, please contact the project maintainers.

## License
This project is created for academic purposes. All rights reserved.

## Acknowledgments
- Developed as an academic project
- Uses various open-source libraries and frameworks
- Special thanks to all contributors and mentors
