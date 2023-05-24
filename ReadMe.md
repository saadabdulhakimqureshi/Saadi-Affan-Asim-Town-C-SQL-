# Saadi Affan Asim Town:

Saadi Affan Asim Town is an housing society app created for our database and systems course project.

Frontend: Console Application(C#)

Backend: SQL Server

## The app has three types of users:

1-Resident

2-Owner

3-Employee

# Resident:

If a user is not an existing resident/ tenant they can sign up to be one. They have to fill the in the sign up form by entering 
their first name, last name, phonenumber, gender and the plot they are interested in. The list of plots will be that are avaialble for rent.
A user must have unique phone number. As soon as their sign up form is submitted the application goes to the owner of the plot they 
are signing up for. As soon as the application is approved by the owner the user can enter their ID in the sign in page.

## An existing resident/ tenant can:

1- Update their information. 

2- Request transport.

3- Request emergency services which are forwarded to the employees of respected departments.

# Owner:

If a user is not an existing owner they can sign up to be one. They have to fill the in the sign up form by entering 
their first name, last name, phonenumber, gender and the plot they are interested in. The list of plots will be that are avaialble for purchase.
A user must have unique phone number. As soon as their sign up form is submitted the application goes to the owner of the plot they 
are signing up for. As soon as the application is approved by the executive department the user can enter their ID in the sign in page.

# An existing owner can:

1-Sell their properties.

2-Purchase new properties.

3-Change the rent for their tenants/ residents.

4-Evict their residents.

5-Approve the resident applications for their plots.

6-Open/Close a plot for rent.

# User:

If a user is not an existing employee they can sign up to be one. They have to fill the in the sign up form by entering 
their first name, last name, phonenumber, gender and the department they are interested in. 
A user must have unique phone number. As soon as their sign up form is submitted the application goes to the executive department.
As soon as the application is approved by the department the user can enter their ID in the sign in page.

## The services and departments are offered by the departments:

1-Executive(Executive)

2-Emergency(Police, Fire, Medical)

3-Public Transport(Transport).

The executive department approves applications for owners and employees. They also can fire employees or change their salaries.

The emergency and transport departments can see the requests raised by residents.

## Sample Date to login:
Resident Id: 1

Owner Id: 1 Can approve residents.

Executive Employee: 2 Can approve employees and owners.

Emergency Employee: 17 Can review requests made by residents.
