using System;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
namespace Fitness
{
    struct Fitness //structs and methods 
    {
        public int age;
        public string name;
        public string exercise;
        public double weight;
        public double height;
        public string bmi;
        public Fitness(int a, string n, string e, double w, double h, string b)
        {
            this.age = a;
            this.name = n;
            this.exercise = e;
            this.weight = w;
            this.height = h;
            this.bmi = b;
        }
        public void setAge(int newAge)
        {
            this.age = newAge;
        }
        public int getAge()
        {
            return this.age;
        }
        public void setName(string newName)
        {
            this.name = newName;
        }
        public string getName()
        {
            return this.name;
        }
        public void setExercise(string newExercise)
        {
            this.exercise = newExercise;
        }
        public string getExercise()
        {
            return this.exercise;
        }
        public void setWeight(double newWeight)
        {
            this.weight = newWeight;
        }
        public double getHeight()
        {
            return this.height;
        }
        public void setHeight(double newHeight)
        {
            this.height = newHeight;
        }
        public double getWeight()
        {
            return this.weight;
        }
        public void setBMI(string newBMI)
        {
            this.bmi = newBMI;
        }
        public string getBMI()
        {
            return (this.bmi);
        }
        public void showInformation()
        {

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("--- Your Fitness Stats ---");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Name: ");
            Console.ResetColor();
            Console.WriteLine(this.getName());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Your age is: ");
            Console.ResetColor();
            Console.WriteLine(this.getAge());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Your weight is: ");
            Console.ResetColor();
            Console.WriteLine(this.getWeight() + " Kg");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Your height is: ");
            Console.ResetColor();
            Console.WriteLine(this.getHeight() + " Meters");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Exercise: ");
            Console.ResetColor();
            Console.WriteLine(this.getExercise());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("You are: ");
            Console.ResetColor();
            Console.WriteLine(this.getBMI());
        }
        public void ShowMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("THE FITNESS HUB");
            Console.ResetColor();
            Console.WriteLine();//title
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" --- MENU --- ");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(" 1. Show information");
            Console.WriteLine(" 2. Diet Schedule");
            Console.WriteLine(" 3. Exercise Schedule");
            Console.WriteLine(" 4. Set Goals");
            Console.WriteLine(" 5. Finish");
        }
        public void calculateName()
        {
            string nom;
            Console.WriteLine("Please enter your name: ");
            nom = Console.ReadLine();
            this.setName(nom);
        }
        public void calculateAge()
        {
            while (true)
            {
                int birthyear;
                string a;
                Console.WriteLine("Please enter the year you were born in: ");
                a = Console.ReadLine();
                if (int.TryParse(a, out birthyear)) // with TRY.PARSE we check if the variable is a number, if it is with OUT we save it in the new variable 
                {
                    birthyear = 2023 - birthyear;
                    this.setAge(birthyear);
                    break;

                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Please try again");
                Console.ResetColor();
            }

        }
        static void displayTitle()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("THE FITNESS HUB");
            Console.ResetColor();
            Console.WriteLine();//title
        }
        static void case1(Fitness person)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("THE FITNESS HUB");
            Console.ResetColor();
            Console.WriteLine();//title
            person.showInformation();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.WriteLine("Continue? Press any key to continue");
            Console.ReadKey();
        }
        static void case2(Fitness person)
        {

            Console.Clear();

            string[] Weekdays = { "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            string[] Momentofday = { "Breakfast", "Lunch", "Snack", "Dinner" };
            string[,] matrix1 = new string[4, 6];
            Random r = new Random();
            int e = r.Next(2, 3);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("THE FITNESS HUB");
            Console.ResetColor();
            Console.WriteLine();//title


            if (person.bmi == "Healthy")
            {


                string[] breakfastArray = { "Smoothie Bowl with Greens", "Smoked Salmon and Whole Grain Bagel", "Avocado Toast with Poached Egg", "Burrito", "Shakshuka", "Blueberry and Almond Butter Smoothie" };
                string[] snacksArray = { "Apple Slices with Nut Butter", "Greek Yogurt with Granola and Berries", "Trail Mix", "Edamame", "Hard-Boiled Eggs", "Cherry Tomatoes with Mozzarella Balls" };
                string[] lunchArray = { "Salmon and Avocado Wrap", "Tuna Salad Lettuce Wraps", "Turkey and Vegetable Stir-Fry", "Chicken and Quinoa Bowl with Roasted Vegetables", "Pasta Salad with Veggies", "Homemade Pizza" };
                string[] dinnerArray = { "Baked Chicken with Sweet Potato Fries", "Margherita Pizza", "Spaghetti Bolognese", "Beef or Veggie Tacos", "Quesadillas with Guacamole", "Vegetable Stir-Fry with Rice" };

                //for Monday
                matrix1[0, 0] = breakfastArray[e];
                matrix1[1, 0] = lunchArray[e];
                matrix1[2, 0] = snacksArray[e];
                matrix1[3, 0] = dinnerArray[e];

                //for Tuesday
                matrix1[0, 1] = breakfastArray[e + 1];
                matrix1[1, 1] = lunchArray[e + 1];
                matrix1[2, 1] = snacksArray[e + 1];
                matrix1[3, 1] = dinnerArray[e + 1];

                //for wednesday
                matrix1[0, 2] = breakfastArray[e - 1];
                matrix1[1, 2] = lunchArray[e - 1];
                matrix1[2, 2] = snacksArray[e - 1];
                matrix1[3, 2] = dinnerArray[e - 1];

                // for Thursday
                matrix1[0, 3] = breakfastArray[e + 3];
                matrix1[1, 3] = lunchArray[e + 3];
                matrix1[2, 3] = snacksArray[e + 3];
                matrix1[3, 3] = dinnerArray[e + 3];

                //for Friday
                matrix1[0, 4] = breakfastArray[e + 2];
                matrix1[1, 4] = lunchArray[e + 2];
                matrix1[2, 4] = snacksArray[e + 2];
                matrix1[3, 4] = dinnerArray[e + 2];

                //for Saturday
                matrix1[0, 5] = breakfastArray[e - 2];
                matrix1[1, 5] = lunchArray[e - 2];
                matrix1[2, 5] = snacksArray[e - 2];
                matrix1[3, 5] = dinnerArray[e - 2];

                for (int i = 0; i < matrix1.GetLength(1); i++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("                                            " + Weekdays[i]);
                    Console.ResetColor();
                    for (int j = 0; j < matrix1.GetLength(0); j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("       " + Momentofday[j] + ": ");
                        Console.ResetColor();
                        Console.WriteLine(matrix1[j, i]);
                    }
                    Console.WriteLine();
                }
            }

            else if (person.bmi == "Underweight")
            {
                Console.Clear();

                string[] breakfastArray = { "Toasts with Peanut", "Cereal with Yoghurt", "A glass of milk with dry fruit", "Vegetable Poha with Fruits", "Smoothie with seeds", "Pancakes with Honey" };
                string[] snacksArray = { "Greek yogurt", "Almonds", "Grapes", "1 Apple", "2 boiled eggs", "A glass of milk" };
                string[] lunchArray = { "macaroni cheese with grated cheese and tomato", "reamy soup with grated cheese or cream and a roll or sandwich", "cheese, baked beans, peanut butter, tinned spaghetti", "Jacket potato with butter or margarine, cheese and baked beans, tuna and mayonnaise", "Chicken pie, potatoes and vegetables", "sausages, baked beans and mashed potatoes" };
                string[] dinnerArray = { "Poached fish with potatoes and tinned or frozen vegetables", "Shepherd’s pie", "Chorizo & halloumi and baguette", "Creamy salmon, prawn & almond curry", "Rigatoni sausage bake", "Roast chicken pie" };


                //for Monday
                matrix1[0, 0] = breakfastArray[e];
                matrix1[1, 0] = lunchArray[e];
                matrix1[2, 0] = snacksArray[e];
                matrix1[3, 0] = dinnerArray[e];

                //for Tuesday
                matrix1[0, 1] = breakfastArray[e + 1];
                matrix1[1, 1] = lunchArray[e + 1];
                matrix1[2, 1] = snacksArray[e + 1];
                matrix1[3, 1] = dinnerArray[e + 1];

                //for wednesday
                matrix1[0, 2] = breakfastArray[e - 1];
                matrix1[1, 2] = lunchArray[e - 1];
                matrix1[2, 2] = snacksArray[e - 1];
                matrix1[3, 2] = dinnerArray[e - 1];

                // for Thursday
                matrix1[0, 3] = breakfastArray[e + 3];
                matrix1[1, 3] = lunchArray[e + 3];
                matrix1[2, 3] = snacksArray[e + 3];
                matrix1[3, 3] = dinnerArray[e + 3];

                //for Friday
                matrix1[0, 4] = breakfastArray[e + 2];
                matrix1[1, 4] = lunchArray[e + 2];
                matrix1[2, 4] = snacksArray[e + 2];
                matrix1[3, 4] = dinnerArray[e + 2];

                //for Saturday
                matrix1[0, 5] = breakfastArray[e - 2];
                matrix1[1, 5] = lunchArray[e - 2];
                matrix1[2, 5] = snacksArray[e - 2];
                matrix1[3, 5] = dinnerArray[e - 2];

                for (int i = 0; i < matrix1.GetLength(1); i++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("                                            " + Weekdays[i]);
                    Console.ResetColor();

                    for (int j = 0; j < matrix1.GetLength(0); j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("       " + Momentofday[j] + ": ");
                        Console.ResetColor();
                        Console.WriteLine(matrix1[j, i]);
                    }
                    Console.WriteLine();
                }
            }

            else if (person.bmi == "Overweight")
            {
                Console.Clear();
                string[] breakfastArray = { "Overnight Chia Seed Pudding", "Quinoa Breakfast Bowl with Fruit", "Whole Grain Pancakes with Berries", "Smoked Salmon and Cream Cheese Bagel", "Muesli with Yogurt and Fresh Fruit", "Cottage Cheese and Fruit Bowl" };
                string[] snacksArray = { "Apple Slices", "Carrot Sticks", "Rice Cake", "Cherry Tomatoes", "Grapes", "Yogurt" };
                string[] lunchArray = { "Grilled Chicken Salad", "Quinoa Bowl", "Baked Salmon with Steamed Broccoli", "Vegetarian Stir-Fry", "Turkey and Vegetable Wrap", "Egg White Omelette with Spinach and Mushrooms" };
                string[] dinnerArray = { "Grilled Chicken Breast with Roasted Vegetables", "Baked Cod with Quinoa and Steamed Asparagus", "Vegetarian Lentil Soup", "Spaghetti Squash with Turkey Bolognese", "Grilled Salmon with Quinoa and Stir-Fried Broccoli", "Chickpea and Vegetable Stir-Fry" };

                //for Monday
                matrix1[0, 0] = breakfastArray[e];
                matrix1[1, 0] = lunchArray[e];
                matrix1[2, 0] = snacksArray[e];
                matrix1[3, 0] = dinnerArray[e];

                //for Tuesday
                matrix1[0, 1] = breakfastArray[e + 1];
                matrix1[1, 1] = lunchArray[e + 1];
                matrix1[2, 1] = snacksArray[e + 1];
                matrix1[3, 1] = dinnerArray[e + 1];

                //for wednesday
                matrix1[0, 2] = breakfastArray[e - 1];
                matrix1[1, 2] = lunchArray[e - 1];
                matrix1[2, 2] = snacksArray[e - 1];
                matrix1[3, 2] = dinnerArray[e - 1];

                // for Thursday
                matrix1[0, 3] = breakfastArray[e + 3];
                matrix1[1, 3] = lunchArray[e + 3];
                matrix1[2, 3] = snacksArray[e + 3];
                matrix1[3, 3] = dinnerArray[e + 3];

                //for Friday
                matrix1[0, 4] = breakfastArray[e + 2];
                matrix1[1, 4] = lunchArray[e + 2];
                matrix1[2, 4] = snacksArray[e + 2];
                matrix1[3, 4] = dinnerArray[e + 2];

                //for Saturday
                matrix1[0, 5] = breakfastArray[e - 2];
                matrix1[1, 5] = lunchArray[e - 2];
                matrix1[2, 5] = snacksArray[e - 2];
                matrix1[3, 5] = dinnerArray[e - 2];

                for (int i = 0; i < 6; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("                                            " + Weekdays[i]);
                    Console.ResetColor();
                    for (int j = 0; j < 4; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("       " + Momentofday[j] + ": ");
                        Console.ResetColor();
                        Console.WriteLine(matrix1[j, i]);
                    }
                    Console.WriteLine();
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                                                SUNDAY");
            Console.ResetColor();
            Console.WriteLine("       It is your own choice :P");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Continue? Press any key to continue");
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();
        }
        static void case3(Fitness person)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("THE FITNESSHUB");
            Console.ResetColor();
            Console.WriteLine();//title
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Exercise schedule ");
            Console.ResetColor();
            Console.WriteLine();

            if (person.bmi == "Healthy")
            {
                Console.Clear();
                Console.WriteLine("Recommended " + person.getBMI() + " exercise schedule: ");
                Console.WriteLine("------------------");

                Random random = new Random();
                string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
                string[] exercises = { "Rest day", "Running or Jogging", "Yoga", "Meditation", "Bodyweight Exercises", "Cycling", "High-Intensity Interval Training (HIIT)", "Weightlifting" };

                foreach (string day in days)
                {
                    int randomex = random.Next(0, exercises.Length);
                    string randomexs = exercises[randomex];
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("On " + day);
                    Console.ResetColor();
                    Console.Write("You should do " + randomexs);
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("On Sunday");
                Console.ResetColor();
                Console.WriteLine("Rest day");

            }
            else if (person.bmi == "Underweight")
            {
                Console.Clear();
                Console.WriteLine("Recommended " + person.getBMI() + " exercise schedule: ");
                Console.WriteLine("------------------");
                Random random = new Random();
                string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
                string[] exercises = { "Rest day", "Running or Jogging", "Yoga", "Meditation", "Bodyweight Exercises", "Cycling", "High-Intensity Interval Training (HIIT)", "Weightlifting" };

                foreach (string day in days)
                {
                    int randomex = random.Next(0, exercises.Length);
                    string randomexs = exercises[randomex];
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("On " + day);
                    Console.ResetColor();
                    Console.Write("You should do " + randomexs);
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("On Sunday");
                Console.ResetColor();
                Console.WriteLine("Rest day");

            }
            else if (person.bmi == "Overweight")
            {
                Console.Clear();
                Console.WriteLine("Recommended " + person.getBMI() + " exercise schedule: ");
                Console.WriteLine("------------------");
                Random random = new Random();
                string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
                string[] exercises = { "Rest day", "Running or Jogging", "Yoga", "Meditation", "Bodyweight Exercises", "Cycling", "High-Intensity Interval Training (HIIT)", "Weightlifting" };

                foreach (string day in days)
                {
                    int randomex = random.Next(0, exercises.Length);
                    string randomexs = exercises[randomex];
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("On " + day);
                    Console.ResetColor();
                    Console.Write("You should do " + randomexs);
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("On Sunday");
                Console.ResetColor();
                Console.WriteLine("Rest day");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Continue? Press any key to continue");
            Console.ResetColor();
            Console.ReadKey();
        }
        static void case4(Fitness person)
        {
            Console.Clear();
            displayTitle();
            double c, cal2, m, m2, r, r2;
            string goal, goal2, goal3, gain, gain2;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Before exercise");
            Console.ResetColor();
            Console.WriteLine();

            //User setting goals
            while (true)
            {

                Console.WriteLine("Enter the amount of calories you wish to burn to set as a goal");
                goal = Console.ReadLine();

                if (double.TryParse(goal, out c))
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please type a number");
                    Console.ResetColor();
                }
            }
            while (true)
            {
                Console.WriteLine("Enter how much muscle you plan on gaining in kg");
                goal2 = Console.ReadLine();
                if (double.TryParse(goal2, out m))
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please type a number");
                    Console.ResetColor();
                }
            }
            while (true)
            {
                Console.WriteLine("Enter the distance you plan on running in km");
                goal3 = Console.ReadLine();
                if (double.TryParse(goal3, out r))
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please type a number");
                    Console.ResetColor();
                }
            }

            //User results
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("After exercise");
            Console.ResetColor();
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Please insert amount of gains in kg since the start of your goal");
                gain = Console.ReadLine();
                if (double.TryParse(gain, out m2))
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please type a number");
                    Console.ResetColor();
                }
            }
            while (true)
            {
                Console.WriteLine("Please insert distance ran in km");
                gain2 = Console.ReadLine();
                if (double.TryParse(gain2, out r2))
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please type a number");
                    Console.ResetColor();
                }
            }

            //Calory formula
            cal2 = (62 * r2) + (110 + person.weight);
            if (c == cal2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations you have met your calorie burn goals");
                Console.ResetColor();
                Console.WriteLine();
            }
            else if (c < cal2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations you have surpassed your calorie burn goals");
                Console.ResetColor();
                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unfortunately you have not met your goal for calorie burn at this time");
                Console.WriteLine("");
                Console.WriteLine("Try increasing your fiber intake by eating berries, oats and seeds and other low cal foods such as eggs and Greek yogurt");
                Console.WriteLine();
                Console.ResetColor();
            }
            //Muscle gain section 
            if (m == m2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations you have met your muscle gain goals");
                Console.ResetColor();
                Console.WriteLine();
            }
            else if (m < m2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations you have surpassed your muscle gain goals");
                Console.ResetColor();
                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unfortunately you have not met your goal for muscle gains at this time");
                Console.WriteLine("");
                Console.WriteLine("Try increasing your protein intake by eating meat such as beef, chicken and fish or other protein rich foods like eggs and beans or even Greek yogurt and milk");
                Console.ResetColor();
                Console.WriteLine();
            }
            //Running distance section
            if (r == r2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations you have met your running goals!");
                Console.ResetColor();
                Console.WriteLine();
            }
            else if (r < r2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations you have surpassed your running goals");
                Console.ResetColor();
                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unfortunately you have not met your goals for running at this time");
                Console.WriteLine("");
                Console.WriteLine("Try increasing your vitsmin intake by eating more nuts, fruits and quinoa or vegetables for carbs");
                Console.ResetColor();
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Continue? Press any key to continue");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        static void defau()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("THE FITNESS APPLICATION");
            Console.ResetColor();
            Console.WriteLine();//title
            Console.WriteLine("Please choose a valid option");
        }
        static void case5()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("THE FITNESS HUB");
            Console.ResetColor();
            Console.WriteLine();//title
            Console.WriteLine("Thanks for using our fitness app :D");
        }
        public void calculateExercise()
        {
            while (true)
            {
                string checkExercise;
                int exercise;
                Console.WriteLine("Do you exercise, please type 1 for Yes or 2 for No");
                checkExercise = Console.ReadLine();
                if (int.TryParse(checkExercise, out exercise))
                {
                    if (exercise == 1)
                    {
                        this.exercise = "Yes";
                        break;
                    }
                    else if (exercise == 2)
                    {
                        this.exercise = "No";
                        break;
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Please try again");
                Console.ResetColor();
            }

        }
        public void calculateWeightandHeight()
        {
            while (true)
            {
                string checkWeight, checkHeigh;
                double we, bmi, he;
                Console.Write("Please enter your weight(kg): ");
                checkWeight = Console.ReadLine();
                Console.Write("Please enter your height(centimeters): ");
                checkHeigh = Console.ReadLine();
                if (double.TryParse(checkWeight, out we) && (double.TryParse(checkHeigh, out he)))
                {
                    he = (he / 100);
                    this.setHeight(he);
                    this.setWeight(we);
                    bmi = we / (he * 100);
                    if (bmi <= 0.95 && bmi >= 0.71)
                    {
                        this.bmi = "Healthy";
                    }
                    else if (bmi <= 0.71)
                    {
                        this.bmi = "Underweight";
                    }
                    else
                    {
                        this.bmi = "Overweight";
                    }
                    break;
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Please try again");
                Console.ResetColor();
            }

        }
        public class Program
        {
            static void Main(string[] args)
            {
                Console.Clear();
                displayTitle();

                Fitness person = new Fitness(); //connections with the structs and methods 

                person.calculateName();
                person.calculateAge();
                person.calculateExercise();
                person.calculateWeightandHeight();
                Fitness Menu = new Fitness(); //MENU

                while (true) //OPTIONS FOR THE MENU 
                {
                    string od;
                    int op;
                    Console.Clear();
                    Menu.ShowMenu();
                    od = Console.ReadLine();
                    if (int.TryParse(od, out op))
                    {
                        if (op == 1 || op == 2 || op == 3 || op == 4 || op == 5) { }
                    }
                    switch (op)
                    {
                        case 1:
                            case1(person);
                            break; //Showing user information
                        case 2:  //diet schedule                       
                            case2(person);
                            break;
                        case 3:
                            case3(person);
                            break;
                        case 4:
                            case4(person);
                            break;
                        default:
                            defau();
                            break;
                    }
                    if (op == 5)
                    {
                        case5();
                        break;
                    }
                }
            }
        }
    }
}
