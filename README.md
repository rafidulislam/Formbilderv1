# FormBuilder v1

A dynamic **Form Builder** built with **ASP.NET Core MVC** and **Entity Framework Core**.  
This project allows users to create custom forms with multiple fields and options, preview forms, and save them to a database.  

---

## Features

- Create forms dynamically with:
  - Short Answer fields
  - Multiple Choice fields (radio buttons)
- Add/remove questions and options dynamically
- Preview forms in a Google-Forms style interface
- Persist forms and fields to a SQL Server database (LocalDB supported)
- View all forms and preview them individually

---

## Technologies

- **Backend:** ASP.NET Core MVC  
- **Database:** SQL Server LocalDB / MDF  
- **ORM:** Entity Framework Core  
- **Frontend:** HTML, CSS, JavaScript, Bootstrap  

---

## Project Structure
- FormBuilder/
  - Controllers/
    - FormBuilderController.cs
  - Models/
    - FormModel.cs
    - FormField.cs
    - FormOption.cs
  - Views/
    - FormBuilder/
      - Index.cshtml        # List all forms
      - Create.cshtml       # Form creation page
      - Preview.cshtml      # Form preview page
  - appsettings.json       # Connection string
  - Program.cs / Startup.cs

