Contract Monthly Claim System
This repository contains a prototype for a Contract Monthly Claim System, a software solution designed to streamline the claim submission and approval process for academic staff. The project focuses on three key areas: a WPF front-end prototype, a relational database design, and comprehensive project documentation.

Getting Started
To explore the project, you will need Visual Studio with the .NET desktop development workload.

Clone the repository:

git clone [https://github.com/your-username/ContractMonthlyClaimSystem.git](https://github.com/your-username/ContractMonthlyClaimSystem.git)
cd ContractMonthlyClaimSystem

Open the solution:

Open the solution file (.sln) in Visual Studio.

Run the project:

Press F5 or click the "Start" button to launch the WPF application.

 Project Components
This project is structured into several key parts, each with its own purpose.

1. GUI Prototype
The graphical user interface is a front-end prototype built with Windows Presentation Foundation (WPF) and C#. It provides a clean, user-friendly interface that demonstrates the primary functionalities of the system.

Key Features:

Lecturer Options:

Submit Claim: Initiates a new claim submission process.

Upload Documents: Allows for attaching supporting files to a claim.

Track Claim Status: Provides an overview of the status of submitted claims.

Coordinator / Academic Manager Options:

Verify Claims: Enables managers to review and verify submitted claims.

Approve Claims: Approves claims for final processing.

2. Database Design
The database is designed to support a simple, efficient relational model. The structure is represented using a UML Class Diagram, which serves as a blueprint for implementation.

Database Schema:

User Table: Stores user details, including UserID, Username, PasswordHash, and Role.

Claim Table: Contains information about each claim, such as ClaimID, DateSubmitted, and ClaimStatus. It links to the User table via UserID.

Document Table: Holds metadata for supporting documents, including DocumentID, FileName, and FilePath. It links to the Claim table via ClaimID.

3. Project Documentation
The documentation provides a deep dive into the project's design and decision-making process. It covers:

Design Choices: Justification for the chosen technologies and UI layout.

Assumptions and Constraints: Defines the boundaries of this prototype, such as the absence of a live backend.

Project Plan: A detailed timeline for the development of the prototype.

🗓 Project Plan
The project was developed following a structured plan to ensure a smooth and efficient workflow.

Phase

Task

Duration

Phase 1: Design

Define requirements and features

1-2 days



Create GUI wireframes

1 day



Design database schema (UML)

1 day

Phase 2: Development

Set up WPF project

1 day



Implement Main Window UI (XAML)

2 days



Implement C# code-behind

3 days



Connect UI to logic

1 day

Phase 3: Testing & Review

Test all button functionality

1-2 days



Review and refine GUI

1 day

Total Estimated Time



2 weeks

 Author
Lisakhanya Notununu (ST10437798)

🤝 Contribution
This project is a starting point. If you would like to contribute, feel free to fork the repository and propose enhancements, such as integrating with a live database or implementing user authentication.
