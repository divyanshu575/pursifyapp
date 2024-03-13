Web Application Security - CYB206
Group Name:Gamma
Lokesh Donga
GopiKrishna Thottathil
Divyanshu Sharma

2024-01-15 1600 hrs

- Fields decided:

Name (String)	
Type (String)	
Color (String)	
Comp (decimal)	
Size (String)	
Price (decimal)
Material (String)	

- Entries decided:

Scudera Ferrari Style Wallet
Gucci GG Marmont Bifold Wallet
Tom Ford Micro Grain Bifold Wallet
Balenciaga Superbusy Messenger Bag
Swissgear Anti-Theft Backpack
Ralph Lauren Ranger Backpack
Adidas Defender Duffle bag





2024-01-17 1345 hrs, Time: 2 hrs 30 min

Divyanshu

- Finalized the fields to be used in the database. (Id, Name, Type, Color, Material, Compartments, Size, Price)

- Created a new Web App project "pursify" in Visual Studio, using the ASP.NET Core Web App (Model-View-Controller) template.

- Added a Model in the "Models" section, new class named "Purse.cs."

- Added scaffolding to generate CRUD pages for the "Movie" model.

- Add a new scaffolded item; in "Controllers", which creates: a purses controller: Controllers/PursesController.cs, Razor view files for Create, Delete, Details, Edit, and Index pages: Views/Purses/*.cshtml, and a database context class: Data/pursifyContext.cs.

- Created a new class "SeedData" in the Models folder, it has the data that will be used to populate the DB. 

- In the Package Manager Console (PMC), Added Migration InitialCreate (20240125095935_InitialCreate.cs) and updated database to the latest migration.

- Added search functionality to the website, added <form> tags in Views/Purses/Index.cshtml and modified Controllers/PursesController.cs.

- Added a search by genre option, by adding the class  PurseTypeV iewModel to models, updated the index view Views/Purses/Index.cshtml.

- Added new field "Material" to the model. Updated the view templates (Create.cshtml, Delete.cshtml, Details.cshtml, Edit.cshtml, Index.cshtml).

- Added Material field and data in SeedData.cs, in order to update te database with the new field. Build and creayed another migration "Material".

- Added validation rules to the movie model, attributes such as StringLength, MinimumLength, Required, Range, etc. in movie.cs.

- Added shortcut link at home page, modified UI.

- Added github account to visual studio, created repository and pushed the project.

Errors- 

- SQL error: Due to different data types, we fix this by correcting data types in the Model
- Naming convention was a little confusing and run into some errors
- Reasearch online for styling options for modifying UI.

2024-01-18 1801 hrs
Divyanshu
- Migration is created - 20240218235606_InitialCreate, 20240219030338_Material, 20240222165514_Initial2

2024-02-18 1345 hrs, Time: 1 hr

GopiKrishna
- Customized background, colours, added icon on home page.


2024-02-22 1335 hrs 
 
Lokesh 
- Added a button to naviagvte to the inventory
- Updated Readme and modified the seddata file with 3 more items.
- Commited project.


2024-03-06 2034 hrs Total Time worked on 2024-03-06 = 120 minutes

Lokesh

- Navigated to Program.cs and added a Authentication.Cookies method, then
Added a builder services to add Authentication where we defined login path and timespan.
- Also Modified MapControllerRoute logic to call the pattern where controller=Access and Action =Login

2024-03-06 2105
- Added a new class to Models folder with name as PursifyLogin
- Created a Model for login view page

2024-03-06 2115
- Added a new controller to under controller folder with name AccessController
- Once Controller page is create added some Authentication Classes likes System.Security.Claims, Authentication, Authentication Cookies
- Created a public IActionResult Login action logic within the AccessController where we have hard coded the Username and Password.

2024-03-06 2145
- Navigated to PursesController.cs controller and added some predifiend methods like Authentication, Authentication Cookies, and Authorization
- Aded a new public class as async Task IActionResult LogOut
- Defined a method [Authorize] in the intial phase so that only logged in user can enter the web page

2024-03-06 22:05
- Navigated to Layout.cshtml and added a class with stating asp-controller="Home" and asp-action="LogOut"
- Navigated to AccessController controller and right click on the Login public action result and select Add View and select Razor View
- Now Added a model method to callout the Models.PursifyLogin class 

Problmes Faced - LogOut Button Now Working where it is giving the error page when ever user click on logout button.
Reference - Lokesh have referedd to some online materail to add the authentication, here is the reference https://www.youtube.com/watch?v=uGoNCJf0t1g

Gopi - Time: 1.5 hr

Date & Time: 2024-03-07 0905
- Modified the AccessController to impliment log out action method to sign users out and redirect them to the login page after logout.
- Conducted testing of the logout button functionality following the adjustments made in the AccessController

Divyanshu - Time: 30 min

Date & Time: 2024-03-07 1105
- Added register button 
// work in progress

- Added theme to authentication page.

2024-03-12 21:40

Gopi - Time: 1 hr 30 min

- Enabled authenticatin and authoriation (referance: https://www.youtube.com/watch?v=2Zwktsd6iSQ)

- @if (User.IsInRole("Administrator"))

- defined 2 roles Administrator and User.

- registered 2 users:

Admin: (Create delete edit details)

test@test.com
Password@2024

User: (deatils)

test2@test.com
Password@2023

// Took multiple attempts.

