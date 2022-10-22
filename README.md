# API_Customer_Registration

##General description
[.NET Core Api](https://api-customer-management.azurewebsites.net/api/customers) designed for customer registration. Contains specific methods designed for CRUD operations regarding customer information. Deployed in Azure, leveraging Azure SQL Server Database for persistence and Azure Key Vault to store the encrypted connection string. 

##How-to
The customer registration API provides ready-to-use interfaces considering the main HTTP verbs (GET, POST, PUT, DELETE). Using Postman or any other CLI, simply build a request containing the desired HTTP verb and the required customer data, if necessary. The fully-managed service deployed in Azure will respond with the appropriate success/error Status.

Customer information that may be stored involves:

- Name
- (Address) - Street Name
- (Address) - City
- Age
- Email
- Phone

Please note: 

1. **Name** is a **required** field;
2. **Age** will not accept values that are not in the range of 1 to 130;
3. **Age** will not accept non-numeric values;
4. **Phone** will not accept non-numeric values;
5. **Email** must be at least be formatted as *xxxx@yyyy*.

##Request examples

To interact with the API, simply send a request to the [API](https://api-customer-management.azurewebsites.net). Here's some examples on how to interact with it:

###GET - return all Customers
To retrieve all customers as a JSON file, you can directly access the [default GET URL](https://api-customer-management.azurewebsites.net/api/customers) or send a plain GET request:
![get-1](https://user-images.githubusercontent.com/32580031/197343926-232940b6-7976-47b6-b936-23ab8676960e.PNG)

###GET + id - return a specific customer
To retrieve information from a specific customer, include the ID on your request:
![get-2](https://user-images.githubusercontent.com/32580031/197343928-83d674d9-bbbf-4acc-bea4-25f5c62234d9.PNG)

###POST + customer info - insert a customer
To insert a customer, send a POST request to the URL mentioned above and input the customer information into the body of the request:
![image](https://user-images.githubusercontent.com/32580031/197343755-3c8f95b8-24ec-4d7c-a28e-90243c96a3c4.png)

###PUT + id/customer info - edit a customer
To edit a customer, send a PUT request and input the customer information and include the ID on top of your request:
![image](https://user-images.githubusercontent.com/32580031/197344099-efe2658c-920e-409a-a461-cbd53b7c26c9.png)

###DELETE + id - delete a customer
To delete a customer, send a DELETE request and include the customer ID:
![image](https://user-images.githubusercontent.com/32580031/197344138-f215dc82-47ad-4150-af68-7db85c3140cd.png)

If you have any doubts, fell free to reach me through my personal [e-mail](ricardo_morello@hotmail.com).
