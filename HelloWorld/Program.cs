namespace HelloWorld
{

    class progrma
    {



        static void Main()
        {
            /* Data type */

            int num =5;
            double mydouble = 7.8979;
            char mylatter =V
            bool mybool =true
            string mytext = "Anderson"
            var = namer = "Jenny"

            DateOnly dataconverted = new DateOnly ();
            string nameImput;
            string BirthdayInput;
            Console.WriteLine ("HOLA BIENVENIDO AL CALCULADOR DE DAÑOS" );
            Console.WriteLine ("Escribe tu nombre:" );
            nameImput = Console.ReadLine();
            Console.WriteLine ($"un gusto conocerte {nameImput}");
            Console.WriteLine ($"Escribe tu fecha de nacimiento en formado dd/mm/aa:" );
            birthdayInput = Console.ReadLine();
            bool isDateValid= DateOnly.Tryparse(birthdayInput. out dataconverted);
            if (isDateValid== false) Console.WriteLine ("Fecha no valida " );
            var person= new Person{
                Name = nameImput,
                BirthdayInput= dataconverted,
                Age=DateTime.Now.Year=dataconverted.Year

            };

            Console.WriteLine ($"tu nombre:" {person.Name} );
            Console.WriteLine ($"tu nombre:" {person.Birthday} );
            Console.WriteLine ($"tu nombre:" {person.Age} );

            Console.WriteLine ();

            

        }
    }
}

    public class person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public DateOnly Birthday Age {get; set; }
        
        }