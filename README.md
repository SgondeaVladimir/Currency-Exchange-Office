Exchange Office Management System (C# CRUD)

📌 Project Overview
This is a desktop application developed in C# Windows Forms (.NET Framework) designed for managing the daily operations of a currency exchange office. The application implements a full CRUD (Create, Read, Update, Delete) system and stores data persistently in a local SQL Server database.

The project was built with a focus on Code Styling Awareness, clean architecture, and proper namespace organization as part of the Windows Applications Programming (PAW) curriculum.

🚀 Key Features
Entity Management: Comprehensive management for Currencies, Clients, Cashiers, Exchange Rates, and Transactions.

Transaction Logic: Automated calculation of exchange totals based on current rates (Buying vs. Selling).

Persistent Storage: Integration with SQL Server LocalDB for reliable data management.

Clean UI: Organized interface with separate forms for each entity and a central dashboard.

Relational Database: Proper implementation of Foreign Keys to maintain data integrity between transactions, clients, and currencies.

📂 Project Structure
The project follows a modular structure for better maintainability:

Models/: Contains the entity classes (POCOs) representing the data structure.

DataAccess/: Logic for database communication using ADO.NET (SqlConnection, SqlCommand).

Forms/: The User Interface layer, containing all Windows Forms and event handling logic.

ExchangeDB.mdf: The local SQL Server database file.

📊 Database Schema
The system manages 5 main entities:

Valute (Currencies): ISO codes (EUR, USD) and full names.

Clienti (Clients): Full name, National ID (CNP), and contact info.

Casieri (Cashiers): Staff members and their unique employee codes.

CursuriValutare (Exchange Rates): Daily buy/sell rates linked to specific currencies.

Tranzactii (Transactions): Detailed records of exchanges including amount, type, and total value in local currency.

🛠 Technologies Used
Language: C#

Framework: .NET Framework 4.7.2+

UI: Windows Forms (WinForms)

Database: Microsoft SQL Server LocalDB

Data Access: ADO.NET

⚙️ Setup & Installation
Clone the repository: git clone <repository-url>

Prerequisites: Ensure you have Visual Studio installed with the "Data storage and processing" workload (SQL Server Data Tools).

Open the Solution: Load the .sln file in Visual Studio.

Database Connection: The ExchangeDB.mdf file is included in the project. Ensure its property "Copy to Output Directory" is set to Copy if newer.

Build & Run: Press F5 to compile and launch the application.

👨‍💻 Author
Vladimir Sgondea
