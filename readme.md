# Please answer ALL questions, use C# for coding exercises. T-SQL for SQL questions  #

**Technical**
  
 1. Write a program that counts from any number (under 100) in decimal down to 0 in binary output. DO NOT use the ToString() method. For example, the following line in a code snippet: BinCount(5); Would produce: 101 100 11 10 01 00 
 2. Write a program or method that takes in a string and reproduces the string on the console output in the following format: 
     a. All vowels are lowercase 
     b. All consonants are uppercase 
     c. even digits (0, 2, 4, 6, 8) are stripped 

    For example, the following line in a code snippet: ChangeCase(“alphabet0123”); Would produce or return: aLPHaBeT13 

 3. Design and implement the class structure for a drawing application. A drawing is made up of a canvas that contains a collection of three different shapes: circles, lines, and boxes. Each shape can be drawn by calling a Draw() method for that shape. The canvas class should also have a draw method that draws all of the shapes it contains. You don’t have to actually draw anything on a screen; you can simulate drawing by writing a message to the console. For example, the code snippet: canvas.Draw(); could produce something like the following output to the console: Drawing a circle at… Drawing a line at… etc. (For each shape on the canvas) 
 4. (Bonus) – consider re-writing the above answer (#3) differently where the canvas does not contain the shapes, but is able to draw any of the three shapes passed to it. Re-design canvas.Draw() if you need to. Your main() program should ask for user input on what shape to draw. Ask once, draw, then exit. 

**SQL Programming – Queries**

Note: Please refer to the attached database_schema.sql file which constructs the database schema required to answer the following questions. 


Items
 
 1.

   - Write a query that retrieves all employees and departments they work in. Return their name, job description and their respective departments ordering by the employee’s name. 

   - Write a query that retrieves all employees that work in more than one department. Return the employee’s name and the name of each department. 
     
 2.

   - Write a query that retrieves the most popular selling item. Return the item’s name, the amount sold and the total profit. Bonus: Use Common Table Expressions (CTE).

   - Write a query that retrieves the employee that has earned the most commission for January 2014. Return the employee’s name and the amount of commission they earned. 

   - A new table is introduced to keep track of system logs called “System_Logs”. This table consists of 4 columns. Assuming the table has 100 rows and includes no NULL values and has no primary keys or unique constraints, write a single SQL statement that deletes all duplicate records (i.e. keep one copy) from the table “System_Logs”.

**SQL Programming – Database Design**

Note: Question 1 is related to the database schema under the “SQL Programming – Queries” section of the test. 
 1.

   - What is the role or purpose of the “Employee_Departments” table? What is this type of SQL table typically referred to as?

   - There is a flaw in the current database schema. Currently the commission rate can exceed 100%. How would you modify the table “Items” to ensure that the commissions cannot exceed 100%?

   - The business is booming and as a new business requirement customers are required to be tracked. How would you modify the existing database to keep track of customers and the items that they buy?

   - Your company sells fruit baskets online. There exists an ORDERS archive table with the following specification to store all previous orders: 

    CREATE TABLE orders 
    ( [order_id] [bigint] NOT NULL, 
    [item_id] [bigint] NOT NULL, 
    [customer_id] [bigint] NOT NULL, 
    [date] [datetime] NOT NULL, 
    [price] [money] NOT NULL, 
    CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED ( [order_id] ASC ) ) 
    Your website provides customers with the functionality to display all their past orders. The traffic on the website is high and the below query is executed frequently and is extremely slow: 
    SELECT order_id, item_id, date, price 
    FROM orders 
    WHERE customer_id = @this_customer 

As the main developer of the system (backend and frontend), what can you do to improve the performance of this interface? 

   - Design a database structure that represents a tree of categories. Each category has a name and exactly one parent category. Describe using T-SQL syntax how you would retrieve all categories directly under a particular category (all children). 

   - (Bonus) Describe in T-SQL code how you would retrieve all categories and all subcategories of a particular category (all descendants). 

**Non-Technical** 

 1. In your opinion, what are the most important elements of making quality software? 
 2. In your opinion, what are the most important traits in a good development team? 
 3. From a high level, describe your understanding of what a software development process is and its cornerstones. 
 4. What is the role of testing in a development team? 
 5. In your opinion, what are code reviews, unit testing, and continuous integration? What role do they play in software development positively or negatively, when, and how are they used. Express your ideas as you see fit. 
