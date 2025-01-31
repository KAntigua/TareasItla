namespace mapaDeClases
{
    internal class Program
    {

        public class MiembroComunidad
        {
            public string Nombre { get; set; }
            public string Numero { get; set; }
            public string Direccion { get; set; }



            public MiembroComunidad(string nombre, string numero, string direccion)
            {
                Nombre = nombre;
                Numero = numero;
                Direccion = direccion;


            }

            public void mostrarInformacion()
            {

                Console.WriteLine($"miembro: {Nombre}");
                Console.WriteLine($"numero: {Numero}");
                Console.WriteLine($"direccion: {Direccion}");

            }
        }
        public class Empleado : MiembroComunidad
        {

            public string Puesto { get; set; }
            public double Sueldo { get; set; }


            public Empleado(string nombre, string puesto, double sueldo, string numero, string direccion)
                : base(nombre, numero, direccion)
            {
                Puesto = puesto;
                Sueldo = sueldo;
            }

            public void infoEmpleado()
            {
                Console.WriteLine($"miembro: {Nombre}");
                Console.WriteLine($"puesto: {Puesto}");
                Console.WriteLine($"sueldo {Sueldo}");

            }



        }

        public class Estudiante : MiembroComunidad
        {

            public int Grado { get; set; }
            public string Seccion { get; set; }


            public Estudiante(string nombre, int grado, string seccion, string numero, string direccion)
                : base(nombre, numero, direccion)
            {
                Grado = grado;
                Seccion = seccion;
            }

            public void infoEstudiante()
            {
                Console.WriteLine($"Estudiante: {Nombre}");
                Console.WriteLine($"Curso: {Grado} Seccion {Seccion}");


            }
        }
        public class exAlumno : MiembroComunidad
        {

            public double Indice { get; set; }
            public string Profesion { get; set; }


            public exAlumno(string nombre, string profesion, double indice, string numero, string direccion)
                : base(nombre, numero, direccion)
            {
                Indice = indice;
                Profesion = profesion;
            }

            public void infoexAlumno()
            {
                Console.WriteLine($"exalumno: {Nombre}");
                Console.WriteLine($"direccion: {Direccion}");
                Console.WriteLine($"numero: {Numero}");
                Console.WriteLine($"profesion: {Profesion}");
                Console.WriteLine($"indice academico: {Indice}");

            }
        }
        public class Docente : Empleado
        {

            public string Especialidad { get; set; }



            public Docente(string puesto, double sueldo, string nombre, string numero, string direccion, string especialidad)
                : base(nombre, puesto, sueldo, numero, direccion)
            {
                Especialidad = especialidad;
            }

            public void infoDocente()
            {
                Console.WriteLine($"Docente: {Nombre}");
                Console.WriteLine($"puesto: {Puesto}");
                Console.WriteLine($"sueldo: {Sueldo}");
                Console.WriteLine($"especialidad: {Especialidad}");

            }



        }

        public class Administrativo : Empleado
        {

            public string Departamento { get; set; }



            public Administrativo(string puesto, double sueldo, string nombre, string numero, string direccion, string departamento)
                : base(nombre, puesto, sueldo, numero, direccion)
            {
                Departamento = departamento;
            }

            public void infoAdmi()
            {
                Console.WriteLine($"Administrativo: {Nombre}");
                Console.WriteLine($"departamento: {Departamento}");
                Console.WriteLine($"sueldo: {Sueldo}");
                Console.WriteLine($"numero: {Numero}");
                Console.WriteLine($"direccion: {Direccion}");

            }



        }

        public class Administrador : Docente
        {

            public string Area { get; set; }



            public Administrador(string puesto, double sueldo, string nombre, string numero, string direccion, string area, string especialidad)
                : base(puesto, sueldo, nombre, numero, direccion, especialidad)
            {
                Area = area;
            }

            public void infoAdministrador()
            {
                Console.WriteLine($"nombre: {Nombre}");
                Console.WriteLine($"area: {Area}");
                Console.WriteLine($"sueldo: {Sueldo}");
                Console.WriteLine($"numero: {Numero}");
                Console.WriteLine($"direccion: {Direccion}");

            }



        }

        public class Maestro : Docente
        {

            public string cursoEncargado { get; set; }



            public Maestro(string puesto, double sueldo, string nombre, string numero, string direccion, string area, string especialidad, string curso)
                : base(puesto, sueldo, nombre, numero, direccion, especialidad)
            {
                cursoEncargado = curso;
            }

            public void infoMaestro()
            {
                Console.WriteLine($"nombre: {Nombre}");
                Console.WriteLine($"Curso encargado: {cursoEncargado}");
                Console.WriteLine($"sueldo: {Sueldo}");
                Console.WriteLine($"numero: {Numero}");
                Console.WriteLine($"direccion: {Direccion}");

            }



        }



        public static void Main(string[] args)
        {
            MiembroComunidad miembro = new MiembroComunidad("julio", "8297880261", "jacobo majluta");
            miembro.mostrarInformacion();


            Empleado empleado = new Empleado("juan", "docente", 200.3, "8298897378", "buenaventuranza");
            empleado.infoEmpleado();

            Estudiante estudiante = new Estudiante("ana", 7, "B", "8297880922", "los mameye");
            estudiante.infoEstudiante();

            exAlumno exalumno = new exAlumno("lolo", "destista", 8.7, "829876098", "guaricanos");
            exalumno.infoexAlumno();

            Docente docente = new Docente("maestro", 300.3, "koko", "8298776545", "villa mella", "fisica");
            docente.infoDocente();


            Administrativo admi = new Administrativo("recepcion", 200, "jijo", "829873980", "villa espana", "atencion al cliente");
            admi.infoAdmi();

            Administrador admin = new Administrador("Director", 400, "lolo", "8298775431", "piantini", "director general", "finanzas");
            admin.infoAdministrador();

            Maestro maestro = new Maestro("maestro", 230, "karen", "8296543445", "jacobo majluta", "ciencias", "ciencias de la naturaleza", "4toB");
            maestro.infoMaestro();
            Console.ReadKey();


        }




    }
}
