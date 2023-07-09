## ASP.NET Core E-Commerce Application

The ASP.NET Core application is a web-based e-commerce platform designed to provide a seamless shopping experience for users. It allows customers to browse through a wide range of products, add them to their cart, and securely complete their purchases. The application also provides an intuitive admin dashboard for managing products, inventory, and orders.

### Running the Application Locally

To run the developed application locally, follow these steps:

1. Ensure that you have the .NET Core SDK installed on your machine. You can download it from the official Microsoft website.
2. Clone the application repository from the version control system of your choice (e.g., GitHub) or download the source code as a ZIP archive.
3. Open a terminal or command prompt and navigate to the project's root directory.
4. Restore the project dependencies by running the command:

dotnet restore

5. Next, build the application by running:

dotnet build

6. Once the build process is complete, you can run the application using the command:

dotnet run

7. The application will start a local web server and provide a URL (e.g., http://localhost:5000) where you can access it in your web browser.
8. Open your preferred web browser and enter the provided URL to access the application.
9. You should now be able to explore the e-commerce platform, register an account, add products to your cart, and complete test purchases.
10. If you want to access the admin dashboard, navigate to the appropriate URL (e.g., http://localhost:5000/admin) and use the provided credentials to log in.

By following these steps, you can set up and run the ASP.NET Core application locally, allowing you to test its functionality and make any necessary customizations or improvements.

Examples of urls:

URL: /en/Home/Index

In this example, the URL matches the route pattern {lang}/{controller}/{action}. The value en is provided for the lang segment, Home is provided for the controller segment, and Index is provided for the action segment. The default values are not used in this case, as all segments have explicit values specified.

URL: /fr/Products/Details

In this example, the URL matches the route pattern {lang}/{controller}/{action}. The value fr is provided for the lang segment, Products is provided for the controller segment, and Details is provided for the action segment. Again, the default values are not used as explicit values are provided for all segments.