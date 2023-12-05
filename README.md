# Online Burger Ordering Application

Welcome to our Online Burger Ordering Application! This project was a collaborative effort by a 3-person team to create a user-friendly platform for ordering delicious burger menus and sauces online. Below are some of the key features and technologies we've utilized in this application:

## Features

-   **Onion Architecture**: We've structured our codebase using the Onion Architecture principles, ensuring scalability and maintainability.
-   **Entity Framework Code First**: Our database modeling was implemented using Entity Framework's Code First approach, enabling seamless integration and updates.
-   **Bogus Library for Seed Data**: We used the Bogus library to generate sample data, populating our database for testing and demonstration purposes.
-   **MSSQL**: Leveraging MSSQL as our relational database management system ensured robust data management and integrity.
-   **ASP.NET Core MVC**: The application is built following the ASP.NET Core MVC architectural pattern, providing modularity, scalability, and maintainability.
-   **Custom Attributes for Data Validation**: We integrated custom attributes for precise data validation and efficient input handling.
-   **ASP.NET Core Identity Framework**: Authentication and authorization were implemented using the Identity Framework, ensuring secure user access.
-   **Dependency Injection**: Employing Dependency Injection helped manage application dependencies, promoting modular and testable code.
-   **Session and Cookies Handling**: We utilized session and cookies to maintain user state and preferences across sessions.
-   **jQuery for Enhanced User Experience**: Implementing jQuery enhanced user interaction with features like filtering, search bars, and pagination, ensuring smooth asynchronous operations.

## Admin Features

-   **Admin Privileges**: The application includes an admin role with specific privileges.
-   **Menu and Sauce Management**:
    -   **Add, List, Update, Remove**: Admins can perform CRUD operations on menus and sauces, managing their details effectively.
-   **Order Management**:
    -   **Access Orders List**: Admins have access to view all orders made through the system.
    -   **Order Details**: Admins can delve into order details, allowing for better insights and management.

## Customer Features

-   **Login Required for Ordering**: Customers are required to log in to the website before placing orders, ensuring security and personalized interactions.
-   **Registration and Login**:
    -   **Registration with Email**: Customers can register using an email address to create their account.
    -   **Login System**: Once registered, customers can log in securely to access the ordering functionalities.
-   **Ordering Process**:
    -   **Add to Cart**: Authenticated customers can add menus and sauces to their cart for convenient ordering.
    -   **Place Orders**: Customers can make orders after adding desired items to the cart.
-   **Access Limitation**:
    -   **No Admin Dashboard Access**: Customers do not have access to the admin dashboard or its related functionalities.

Happy ordering! 🍔🛒
