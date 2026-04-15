Part 1- Project Initialization (Day 1)

Today I started working on the Restaurant Shopping Cart System. The goal is to build a console-based program in C# that allows users to select menu items, input quantities, and simulate a simple checkout process.

I began by planning the structure of the program. I decided to create a Product class that will represent each menu item. This class includes properties such as Id, Name, Price, and RemainingStock. These will allow me to manage each item properly, especially when tracking available stock.

I also added a method called DisplayProduct() to print each item in the menu. In addition, I planned to include helper methods like GetItemTotal(), HasEnoughStock(), and DeductStock() to handle computations and stock updates.

At the end of today, I created an array of Product objects to serve as the restaurant menu. The program can now display the menu using a loop, which is a good starting point.

Part 2 – Input Handling and Validation (Day 2)

Today I focused on making the program interactive by allowing user input. I added prompts for selecting a product number and entering a quantity.

To make the program more reliable, I used int.TryParse() when reading user input. This prevents the program from crashing if the user enters letters or invalid values.

I implemented several validation checks:

Detecting invalid product numbers
Rejecting negative or zero quantities
Handling non-numeric input
Checking if a product is out of stock
Preventing orders that exceed the available stock

I also added clear error messages to guide the user whenever something goes wrong. This made the program easier to use and less prone to errors.

At this stage, the system can properly accept and validate input, but it still does not store selected items in a cart.

Part 3 – Cart System and Stock Updates (Day 3)

Today I worked on implementing the cart functionality. I created a CartItem class to store the selected product, quantity, and subtotal.

I used a fixed-size array to hold cart items. Then I added logic to:

Add items into the cart
Detect duplicate products and update their quantity instead of adding a new entry
Prevent adding items when the cart is already full

I also connected the cart system to stock management. When a user adds an item, the program deducts the quantity from the product’s RemainingStock. This ensures that stock levels are always updated correctly.

A loop was added so the user can continue adding items until they choose to stop. This made the system feel more complete and interactive.

By the end of today, the program can successfully manage multiple items, update quantities, and track remaining stock.

