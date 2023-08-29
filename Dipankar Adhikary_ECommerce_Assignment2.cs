

using System;
using System.Reflection;

namespace ECommerce
{
    public class User
    {
        private Boolean role=true;
        private String loginID="User_101_New";
        private String password="User@101";

        public void verifyUser()
        {
            Console.WriteLine("User "+loginID+" is verified successfully.");
        }
    }



    public class Customer:User
    {
        private String id="User_101";
        private String address ="20 No. Road, Chakdaha-Bongaon, North 24 Parganas, West Bengal-743262" ;
        private String phone = "9087654321";
        private String email = "user101@gmail.com";

        public void lonin()
        {
            Console.WriteLine("The customer "+id+" is logging successfully");
        }

        public void register()
        {
            Console.WriteLine("The customer "+id+" is registered successfully.");
        }

        public void updateProfile()
        {
            Console.WriteLine("The customer "+id+" profile is updated successfully in flieds: \n" +
                "\n1. Adress: "+address+
                "\n2. E-mail Id: "+email+
                "\n3. Phone No: "+phone);
        }


    }

    public class ShoppingCart
    {

        //DateTime d = DateTime.Now;
        private DateTime d = DateTime.Now;

        public void addCartItem()
        {
            Console.WriteLine("The item is added to the cart.");
        }
        public void checkOut()
        {
            Console.WriteLine("The item is recently check out by you.");
        }
        public void viewCartDetails()
        {
            Console.WriteLine("The cart details are showing now....");
        }
        public void updateQuantity()
        {
            Console.WriteLine("The quantity is added to the cart.");
        }

    }

    public class Reviews
    {
        private String reviewID = "User_101_Review";
        private String customerID="Customer_101";
        private int rating=Convert.ToInt32(4.5);
        private String parentID = "User_101";
        private String productID = "Product_101";

        public void addReview()
        {
            Console.WriteLine("The customer "+customerID+" review the pruduct "+productID+" " +
                "successfully with rating of "+rating);
        }

        public void editReview()
        {
            Console.WriteLine("The review "+reviewID+" is edited successfully.");
        }

        public void deleteReview()
        {
            Console.WriteLine("The review "+reviewID+" is deleted successfully.");
        }
    }

    public class Orders
    {
        private int id = Convert.ToInt32(101);
        private String customerID = "Customer_101";
        private String sellerID = "Seller_101";
        private String productID = "Product_101";
        private String totalAmount = "1999";
        private String address = "20 No. Road, Chakdaha-Bongaon, North 24 Parganas, West Bengal-743262";
        private String deliveryStatus = "Delivered";
        private DateTime orderDate = DateTime.Now;
        private DateTime deliveredDate = DateTime.Now;

        public void placeOrder()
        {
            Console.WriteLine("The order details are below: \n" +
                "\n1. Customer Id: "+customerID+
                "\n2. Product Id: "+productID+
                "\n3. Price: "+totalAmount+
                "\n4. Seller Id: "+sellerID+
                "\n5. Order Date: "+orderDate+
                "\n6. Address: "+address+
                "\n7. Delivery Status: "+deliveryStatus+
                "\n8. Delivery Date: "+deliveredDate);
        }



    }

    public class Product
    {
        private String productID = "Product_101";
        private String productName = ".NET Basic Programming with Microsoft.";
        private int productCost= Convert.ToInt32(1999);
        private String sellerID = "Seller_101";
        //ateTime d = DateTime.Now;
        private DateTime postedDate = DateTime.Now;

        public void addToCart()
        {
            Console.WriteLine("The item '"+productName+"' with product Id "+productID+" is added to cart successfully.");

        }

        public void sellProduct()
        {
            Console.WriteLine("The item '"+productName+"' is sold successfully.");

        }

        public void getProductDetails()
        {
            Console.WriteLine("Getting the selected Product details: \n" +
                "\n1. Product Name: "+productName+
                "\n2. Product Id: "+productID+
                "\n3. Product Price: "+productCost+
                "\n4. Seller Id: "+sellerID+
                "\n5. Order posted date: "+postedDate);
        }

        public void buyProduct()
        {
            Console.WriteLine("The product '"+productName+"' is Buying successfully from the seller "+sellerID+
                " at price "+productCost+" only.");

        }


    }


    public class Payment
    {
        private int ID = Convert.ToInt32(86429753);
        private String orderID = "Order_101";
        private int total = Convert.ToInt32(1999);
        private String details = "#86429753Abc101";
        private Boolean paid = true;

        private void sendOtp()
        {
            Console.WriteLine("OTP is send to your registered mobile number and Email.");
        }

        private void comfirmTransaction()
        {
            Console.WriteLine("The transaction "+ID+" is successfull.");
        }

        public void getPaymentDetails()
        {
            Console.WriteLine("The payment detail is given below: \n"+
                "\n1. Payment Id: "+ID+
                "\n2. Order Id: "+orderID+
                "\n3. Transaction Id: "+details+
                "\n4. Total Price: "+total+
                "\n5. Payment status: "+paid);
        }

        private void makeTransaction()
        {
            Console.WriteLine("The Transaction is successful with transaction Id "+details);
        }

    }


    public class Seller:User
    {
        private String id = "Seller_101";
        private String address = "MG street, Block-88, Kolkata-91";
        private String phone = "1800000888";
        private String email = "CollegeBookStall@gmail.com";
        private int sellerRating = Convert.ToInt32(4.8);

        public void lonin()
        {
            Console.WriteLine("The seller "+id+" is loging successfully.");
        }

        public void register()
        {
            Console.WriteLine("The seller "+id+" is registered successfully.");
        }

        public void updateProfile()
        {
            Console.WriteLine("The seller's profile is updated successfully and updated" +
                " details are: \n"+
                "\n1. Seller Id: "+id+
                "\n2. Address:"+address+
                "\n3. E-mail Id: "+email+
                "\n4. Phone No: "+phone+
                "\n5. Seller rating: "+sellerRating);
        }

    }


    public class ECommerce
    {
        static void Main(string[] args)
        {
           User user = new User();
            user.verifyUser();
            Console.WriteLine("You are successfully login to the E_commerce.\n");
            bool ch = true;

            while (ch)
            {
                Console.WriteLine("Please choose below categories by their index number: \n" +
                "\n1. Customer Details 1" +
                "\n2. Seller Details 2"+
                "\n3. Shopping Cart 3"+
                "\n4. Orders 4"+
                "\n5. Product Details 5"+
                "\n6. Reviews 6"+
                "\n7. Payment Details 7"+
                "\n8. Exit the E_Commerce 8");

                int choose=Convert.ToInt32(Console.ReadLine());
                if (choose == 1) 
                { 

                    Customer customer = new Customer();
                    customer.lonin();
                    customer.register();
                    customer.updateProfile();
                    Console.WriteLine("\n");

                }
                else if (choose == 2)
                {
                    Seller seller = new Seller();
                    seller.lonin();
                    seller.register();
                    seller.updateProfile();
                    Console.WriteLine("\n");

                }
                else if (choose == 3)
                {
                    ShoppingCart cart = new ShoppingCart();
                    cart.addCartItem();
                    cart.checkOut();
                    cart.viewCartDetails();
                    cart.updateQuantity();
                    Console.WriteLine("\n");

                }
                else if(choose == 4)
                {
                    Orders orders = new Orders();
                    orders.placeOrder();
                    Console.WriteLine("\n");
                }
                else if(choose==5)
                {
                    Product product = new Product();
                    product.addToCart();
                    product.sellProduct();
                    product.getProductDetails();
                    product.buyProduct();
                    Console.WriteLine("\n");

                }
                else if(choose == 6)
                {
                    Reviews reviews = new Reviews();
                    reviews.addReview();
                    reviews.deleteReview();
                    reviews.editReview();
                    Console.WriteLine("\n");
                }
                else if(choose == 7)
                {
                    
                    Payment payment = new Payment();
                    payment.getPaymentDetails();
                    Console.WriteLine("\n");
                }
                else if(choose == 8)
                {
                    Console.WriteLine("Thank You for using our E_Commerce site" +
                        " for your daily requierments.\nYou are logout from our site now, " +
                        "We hope that you are enjoying our products and services." +
                        ".\nVisit again, have a good day.\nThank You.");
                    ch = false;

                }
            }


        }
    }
}





// User User_101_New is verified successfully.
// You are successfully logged in to the E_commerce.

// Please choose the below categories by their index number: 

// 1. Customer Details 1
// 2. Seller Details 2
// 3. Shopping Cart 3
// 4. Orders 4
// 5. Product Details 5
// 6. Reviews 6
// 7. Payment Details 7
// 8. Exit the E_Commerce 8
// 1
// The customer User_101 is logging in successfully
// The customer User_101 is registered successfully.
// The customer User_101 profile is updated successfully in fields: 

// 1. Address: 20 No. Road, Chakdaha-Bongaon, North 24 Parganas, West Bengal-743262
// 2. E-mail Id: user101@gmail.com
// 3. Phone No: 9087654321


// Please choose the below categories by their index number: 

// 1. Customer Details 1
// 2. Seller Details 2
// 3. Shopping Cart 3
// 4. Orders 4
// 5. Product Details 5
// 6. Reviews 6
// 7. Payment Details 7
// 8. Exit the E_Commerce 8
// 2
// The seller Seller_101 is loging successfully.
// The seller Seller_101 is registered successfully.
// The seller's profile is updated successfully and updated details are: 

// 1. Seller Id: Seller_101
// 2. Address:MG street, Block-88, Kolkata-91
// 3. E-mail Id: CollegeBookStall@gmail.com
// 4. Phone No: 1800000888
// 5. Seller rating: 5


// Please choose below categories by their index number: 

// 1. Customer Details 1
// 2. Seller Details 2
// 3. Shopping Cart 3
// 4. Orders 4
// 5. Product Details 5
// 6. Reviews 6
// 7. Payment Details 7
// 8. Exit the E_Commerce 8
// 3
// The item is added to the cart.
// The item is recently check out by you.
// The cart details are showing now....
// The quantity is added to the cart.


// Please choose below categories by their index number: 

// 1. Customer Details 1
// 2. Seller Details 2
// 3. Shopping Cart 3
// 4. Orders 4
// 5. Product Details 5
// 6. Reviews 6
// 7. Payment Details 7
// 8. Exit the E_Commerce 8
// 4
// The order details are below: 

// 1. Customer Id: Customer_101
// 2. Product Id: Product_101
// 3. Price: 1999
// 4. Seller Id: Seller_101
// 5. Order Date: 08/29/2023 08:40:41
// 6. Address: 20 No. Road, Chakdaha-Bongaon, North 24 Parganas, West Bengal-743262
// 7. Delivery Status: Delivered
// 8. Delivery Date: 08/29/2023 08:40:41


// Please choose below categories by their index number: 

// 1. Customer Details 1
// 2. Seller Details 2
// 3. Shopping Cart 3
// 4. Orders 4
// 5. Product Details 5
// 6. Reviews 6
// 7. Payment Details 7
// 8. Exit the E_Commerce 8
// 5
// ERROR!
// The item '.NET Basic Programming with Microsoft.' with product Id Product_101 is added to cart successfully.
// The item '.NET Basic Programming with Microsoft.' is sold successfully.
// Getting the selected Product details: 

// 1. Product Name: .NET Basic Programming with Microsoft.
// 2. Product Id: Product_101
// 3. Product Price: 1999
// 4. Seller Id: Seller_101
// 5. Order posted date: 08/29/2023 08:40:46ERROR!
// The product '.NET Basic Programming with Microsoft.' is Buying successfully from the seller Seller_101 at price 1999 only.


// Please choose below categories by their index number: 

// 1. Customer Details 1
// 2. Seller Details 2
// 3. Shopping Cart 3
// 4. Orders 4
// 5. Product Details 5
// 6. Reviews 6
// 7. Payment Details 7
// 8. Exit the E_Commerce 8
// 6
// The customer Customer_101 review the pruduct Product_101 successfully with rating of 4
// The review User_101_Review is deleted successfully.
// The review User_101_Review is edited successfully.


// Please choose below categories by their index number: 

// 1. Customer Details 1
// 2. Seller Details 2
// 3. Shopping Cart 3
// 4. Orders 4
// 5. Product Details 5
// 6. Reviews 6
// 7. Payment Details 7
// 8. Exit the E_Commerce 8
// 7
// The payment detail is given below: 

// 1. Payment Id: 86429753
// 2. Order Id: Order_101
// 3. Transaction Id: #86429753Abc101
// 4. Total Price: 1999
// 5. Payment status: True


// Please choose below categories by their index number: 

// 1. Customer Details 1
// 2. Seller Details 2
// 3. Shopping Cart 3
// 4. Orders 4
// 5. Product Details 5
// 6. Reviews 6
// 7. Payment Details 7
// 8. Exit the E_Commerce 8
// 8
// Thank You for using our E_Commerce site for your daily requierments.
// You are logout from our site now, We hope that you are enjoying our products and services..
// Visit again, have a good day.
// Thank You.

