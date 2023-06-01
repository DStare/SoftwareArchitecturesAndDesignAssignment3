using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class Account
    {
        Customer customer;

        public Account() {

            customer = null;
            
        }

        public void showGUI() {

            string userInput;
            bool signOut = false;

            while (true)
            {
                if (customer != null)
                {   
                    customer.showGUI();

                    if (!customer.isSignedIn()) {
                        customer = null;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("****************");
                    Console.WriteLine("\tAccount\t");
                    Console.WriteLine("****************");
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine(
                        "enter \"1\" to log in,\n" +
                        "enter \"2\" to create a new account,\n" +
                        "enter \"5\" to return to navigation \n"
                        );

                    userInput = Console.ReadLine();

                    if (userInput != null)
                    {
                        switch (userInput)
                        {
                            case "1":
                                Console.WriteLine("You have chosen to log in\n");
                                this.logIn();
                                break;
                            case "2":
                                Console.WriteLine("You have chosen to create a new account\n");
                                this.createAccount();
                                break;
                            case "5":
                                Console.WriteLine("You have chosen to return to navigation\n"); break;
                            default:
                                Console.WriteLine("Invalid option, try again\n");
                                break;
                        }
                    }

                    if (userInput == "5")
                    {
                        Console.WriteLine("returning to navigation\n");
                        break;
                    }
                }

            }

        }

        private void logIn() {
            string passEnter = string.Empty;
            string userEnter = string.Empty;
            string exit = string.Empty;
            bool isValidCredentials = false;


            while (true) {
                Console.WriteLine("Enter username: ");
                userEnter = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                passEnter = Console.ReadLine();

                //check for valid password
                isValidCredentials = true;
                if (isValidCredentials)
                {
                    customer = new Customer(userEnter, passEnter);
                    break;
                }
                else {
                    Console.WriteLine("Incorrect log in, press \"1\" to try again. To exit, press \"5\""); 
                    exit = Console.ReadLine();
                    if (exit == "5") {
                        break;
                    }
                }
            }




        }

        private void createAccount()
        {
            string userInput, newUserName, newPassword;
               
                        Console.WriteLine("****************");
                        Console.WriteLine("\tCreating an Account\t");
                        Console.WriteLine("****************");
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine(
                            "enter username or press \"5\" to exit: \n"
                            );

                        userInput = Console.ReadLine();                    

                        if (userInput == "5")
                        {
                            Console.WriteLine("returning to Account\n");
                return;
                        }

                        newUserName = userInput;

                        Console.WriteLine(
                            "enter password or press \"5\" to exit: \n"
                            );

                        userInput = Console.ReadLine();

                        if (userInput == "5")
                        {
                            Console.WriteLine("returning to Account\n");
                return;
                        }

                        newPassword = userInput;

                        //read into file newUserName and newPassword

                        customer = new Customer(newUserName, newPassword);

                }


        public string getCustomerUsername() {
            if (customer == null)
            {
                return "";
            }
            else {
                return customer.getUsername();
            }

        }

      
        
    }


    }



    

