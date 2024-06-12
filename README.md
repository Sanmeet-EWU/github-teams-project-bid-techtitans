# SeamlessEscapesBlazor

Welcome to SeamlessEscapesBlazor! This project is a web application designed to help users plan their trips, find flights, discover hotels, and explore activities seamlessly. Built using Blazor and ASP.NET Core, this application integrates various services and APIs to provide a comprehensive trip planning experience.

## Table of Contents

- [Features](#features)
- [Technologies Used](#technologies-used)
- [Setup and Installation](#setup-and-installation)
- [Usage](#usage)
- [Team Members](#team-members)

## Features

- **Trip Planning:** Plan your trips by entering departure and arrival dates, source and destination cities, number of people, and mode of transportation.
- **Flight Search:** Search for round-trip flights using an external flight API.
- **Hotel Information:** Display hotel information including name, address, and price per night.
- **Activity Discovery:** Explore activities available at the destination.
- **User Registration and Login:** Register new users and allow existing users to log in.

## Technologies Used

- **Blazor:** For building interactive web UIs with C#.
- **ASP.NET Core:** Web framework for building web applications and APIs.
- **Entity Framework Core:** ORM for database interactions.
- **SQL Server:** Database for storing user, flight, hotel, and activity information.
- **HTTP Client:** For making API calls to external services.

## Setup and Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/yourusername/SeamlessEscapesBlazor.git
   cd SeamlessEscapesBlazor
   
2. **Configure the Database Connection**

   Update the `appsettings.json` file with your SQL Server connection string:
   
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=seamlessescapes;Trusted_Connection=True;TrustServerCertificate=True;"
     }
   }

3. **Install dependencies:**

    ```bash
    dotnet restore

4. **Run database migrations:**

   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update

5. **Run the application:**

   ```bash
   dotnet run

## Usage

- **Register a new user:** Navigate to `/Register` and fill out the registration form.
- **Log in:** Navigate to `/Login` and enter your credentials.
- **Plan a trip:** Go to `/Home`, enter your trip details, and submit the form.
- **View flights:** After submitting the trip details, view available flights on the `/Flights` page.
- **Discover hotels and activities:** Similarly, view hotel information and activities for the selected destination.

## Team Members

- **Rahat Bhatia:** Junior Comp. Sci. ([GitHub](https://github.com/rahat15))
- **Shahzeb Khan:** Senior Comp.Sci. ([GitHub](https://github.com/MuhammadShahzebKhan))
- **Andrea Diaz:** Senior Comp. Sci. ([GitHub](https://github.com/theandreahh))
- **Nathan Luiten:** Senior Comp. Sci. ([GitHub](https://github.com/nluiten))
- **Parbhat Rai:** Senior Comp. Sci. ([GitHub](https://github.com/prai42))



