using System;

namespace Classes_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            
            Colour col1 = new Colour(100, 100, 100, "grey");
            Cookie cook1 = new Cookie(50, "round", col1);
            Cookie cook2 = new Cookie(100, "square", col1);
            Cookie cook3 = new Cookie(60, "hexagonal", 50, 100, 220, "blue");
            Cookie cook4 = new Cookie(200, "triangle", 250, 0, 0, "red");

            //==============================================================================

            //Task 2

            Person pers1 = new Person("Dylan", "Dinsdale", "08/10/1998", 178);
            Person pers2 = new Person("Tracy", "Whatsherface", "15/08/1995", 165);
            Person pers3 = new Person("Michael","Somethingsomething", "17/05/1999", 192);
            Random rnd = new Random();
            Subject maths = new Subject("Maths", 2015);
            Subject english = new Subject("English", 2006);
            
            pers1.GetFullName();
            pers1.GetHeightDifference(pers2);
            pers1.GetHeightDifference(pers3);

            pers2.GetFullName();
            pers2.GetHeightDifference(pers1);
            pers2.GetHeightDifference(pers3);

            pers3.GetFullName();
            pers3.GetHeightDifference(pers1);
            pers3.GetHeightDifference(pers2);

            pers1.AssignID(rnd);
            pers1.ListID();
            
            pers1.AddSubject(maths);
            pers1.AddSubject(english);
            pers1.ListSubjects();
        }
    }
    
//Task 1
    class Colour{
        public int red;
        public int green;
        public int blue;
        public string name;

        //==================================

        public Colour(){
            this.red = 0;
            this.green = 0;
            this.blue = 0;
            this.name = "";
        }
        public Colour(int r, int g, int b, string n){
            this.red = r;
            this.green = g;
            this.blue = b;
            this.name = n;
        }
    }
    class Cookie
    {
        public int weight;
        public string shape;
        public Colour colour;
        
        //=================================
        public Cookie(){
            this.weight = 0;
            this.shape = "";
        }

        public Cookie(int w, string s, Colour c){
            this.weight = w;
            this.shape = s;
            this.colour = c;
        }

        public Cookie(int w, string s, int r, int g, int b, string n){
            this.weight = w;
            this.shape = s;
            this.colour = new Colour(r,g,b,n);
        }
    }

//================================================================================

//Task 2
    class Person{
        
       //Attributes 
        public string Firstname;
        public string Surname;
        public string dob;
        public int height;
        public string list;
        public int id;

    //=========================================================================
    //Constructors

        public Person(string f, string s, string d, int h){
            this.Firstname = f;
            this.Surname = s;
            this.dob = d;
            this.height = h;
            this.list = "";
            this.id = 0;
    }

    //=========================================================================
    //Methods

        public void GetFullName(){
            Console.WriteLine(Firstname + " " + Surname);
        }

        public void GetHeightDifference(Person x){
            int difference;
            difference = (x.height - height);
            if (difference < 0){
                difference = difference * -1;
            }
            Console.WriteLine("Height Difference is " + difference);
        }

        public void AssignID(Random x){
            id = x.Next(1000,9999);
        }

        public void ListID(){
            Console.WriteLine("ID: " + id);
        }

        public void AddSubject(Subject x){
            list += x.Name + "   " + x.YoD + Environment.NewLine;
            Console.WriteLine("Added " + x.Name + " to the list.");
        }

        public void ListSubjects(){
            Console.WriteLine(list);
        }
    }
    
    class Subject{
    //Attributes
        public string Name;
        public int YoD;
    //===========================================================================
    //Constructors
        public Subject(string n, int y){
            this.Name = n;
            this.YoD = y;
    }

    //===========================================================================
    //Methods
    }
   
}

