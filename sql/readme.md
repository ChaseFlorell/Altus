#All SQL Related answers are located in this directory.#

----

**Part One**

 - Write a query that retrieves all employees and departments they work in. Return their name, job description and their respective departments ordering by the employee’s name. [[Answer](https://github.com/ChaseFlorell/AltusTest/blob/master/sql/FindAllEmployeesAndTheirDepartments.sql)]
 - Write a query that retrieves all employees that work in more than one department. Return the employee’s name and the name of each department. [[Answer](https://github.com/ChaseFlorell/AltusTest/blob/master/sql/FindEmployeesThatWorkInMoreThanOneDepartment.sql)]
 - Write a query that retrieves the most popular selling item. Return the item’s name, the amount sold and the total profit. Bonus: Use Common Table Expressions (CTE). [[Answer](https://github.com/ChaseFlorell/AltusTest/blob/master/sql/GetMostPopularSellingItem.sql)]
 - Write a query that retrieves the employee that has earned the most commission for January 2014. Return the employee’s name and the amount of commission they earned. [[Answer](https://github.com/ChaseFlorell/AltusTest/blob/master/sql/GetTopCommissionedEmployeeForTheMonthOfJanuary.sql)]
 - A new table is introduced to keep track of system logs called “System_Logs”. This table consists of 4 columns. Assuming the table has 100 rows and includes no NULL values and has no primary keys or unique constraints, write a single SQL statement that deletes all duplicate records (i.e. keep one copy) from the table “System_Logs”. [[Answer](https://github.com/ChaseFlorell/AltusTest/blob/master/sql/RemoveDuplicatesFromSystemLogs.sql)]

**Part Two**

 - What is the role or purpose of the “Employee_Departments” table? What is this type of SQL table typically referred to as?

> The purpose of the `Employee_Departments` table is to join Employees with Departments in a Many-To-Many relationship. One Employee can be a member of many Departments, and likewise one Department can have many Employees. This table is called a join table.

 - There is a flaw in the current database schema. Currently the commission rate can exceed 100%. How would you modify the table “Items” to ensure that the commissions cannot exceed 100%?
 - The business is booming and as a new business requirement customers are required to be tracked. How would you modify the existing database to keep track of customers and the items that they buy? [[Answer](https://github.com/ChaseFlorell/AltusTest/blob/master/sql/CustomerTrackingANDOrdersTablePerfImprovements.sql)]
    - *note: I've combined the answer for this and the orders improvement challenge in a single script.*
 - As the main developer of the system (backend and frontend), what can you do to improve the performance of this interface? [[Same script as above](https://github.com/ChaseFlorell/AltusTest/blob/master/sql/CustomerTrackingANDOrdersTablePerfImprovements.sql)]
 - Design a database structure that represents a tree of categories. Each category has a name and exactly one parent category. Describe using T-SQL syntax how you would retrieve all categories directly under a particular category (all children). [[Answer](https://github.com/ChaseFlorell/AltusTest/blob/master/sql/CreateAndQueryTheCategoriesTable.sql)]



