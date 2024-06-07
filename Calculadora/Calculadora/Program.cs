using System.Diagnostics;
using System.Runtime.InteropServices;

namespace EnSucioCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*private static string[] OpcionesMenu2 = new string[]
        {
            "SI",
            "NO"
        };
                 ME GUSTARÍA HACER UN MENÚ BIEN HECHO EN EL QUE PODER SELECCIONAR ENTRE "SI" Y "NO" CON EL TECLADO (TAL Y COMO TENGO EL OTRO MENÚ GRANDE) CON TAN SOLO ESTAS 2 OPCIONES, PERO NO ME SALE.
        
        private static string Menu2(string[] items, int opcion)
        {
            string SeleccionActual = string.Empty;
            int destacado = 0;

            foreach (var element in items)
            {
                // Limpiar la línea actual antes de escribir la nueva opción
                Console.SetCursorPosition(x, y + destacado);
                Console.Write(new string(' ', Console.WindowWidth - x));
                Console.SetCursorPosition(x, y + destacado);

                if (destacado == opcion)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\t\t\t" + "< " + element.Trim() + " >");
                    Console.ResetColor();
                    SeleccionActual = element;
                }
                else
                {
                    Console.WriteLine(element);
                }
                destacado++;

            }

            return SeleccionActual;
        }
        */

            //          ----------------------------------------------------- 

            /*
               // Funciones matemáticas "especiales"

                   // Permitir que el usuario pueda extraer el RESTO de 2 números(por consola)

                       Console.WriteLine("Introduce el primer número para calcular el resto (dividendo) ");

                       //Conversión a número con int.Parse
                       int numDivisiónResto1 = int.Parse(Console.ReadLine());

                       Console.WriteLine(); // Agrega un espacio entre las líneas

                       Console.WriteLine("Introduce el segundo número para calcular el resto (divisor):");

                       int numDivisiónResto2 = int.Parse(Console.ReadLine());

                       Console.WriteLine(); // Agrega un espacio entre las líneas

                       int Resto = numDivisiónResto1 % numDivisiónResto2;

                       Console.WriteLine("El resto al dividir " + numDivisiónResto1 + " entre " + numDivisiónResto2 + " es: " + "\u001b[1;36m" + Resto + "\u001b[0m");

                       Console.WriteLine(); // Agrega un espacio entre las líneas
            */

            /* 
             * El siguiente código/programa permite al usuario realizar operaciones matemáticas.
             * Se pretende realizar una CALCULADORA, que permita al usuario calcular diferentes cosas (desde operaciones arítméticas básicas o funciones trigonométricas hasta
             * la edad de una persona o matemáticas computacionales).
            */

            /* MEJORAS QUE SE PUEDEN HACER AL CÓDIGO:
             * 
             *  Están todas en la herramienta TRELLO.   https://trello.com/b/fkO7oRFY/calculadora                                   
             */

            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

            MaximizeConsoleWindow(); // Maximizar la ventana de la consola al iniciar

            Console.OutputEncoding = System.Text.Encoding.UTF8;  //Cambia la fuente de la consola

            MensajeBienvenida(); //Mensaje de bienvenida

            Console.WriteLine(); // Agrega un espacio entre las líneas

            bool Loop = true;

            ElegirOpcionDelMenu();

            Console.ReadKey();
            Console.Clear();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_MAXIMIZE = 3;

        private static void MaximizeConsoleWindow()
        {
            IntPtr consoleWindow = GetConsoleWindow();
            ShowWindow(consoleWindow, SW_MAXIMIZE);
        }

        static void MensajeBienvenida()
        {
            Console.WriteLine(); // Agrega un espacio entre las líneas

            Console.WriteLine("\u001b[1;33m\u001b[1m¡Hola! ¡Bienvenido/a a la CALCULADORA!\u001b[0m ");

            Console.WriteLine(); // Agrega un espacio entre las líneas

            string DibujoCalculadora = "\t┌─────┬─────┬─────┬─────┬─────┬─────┬─────┐\r\n" +
                                       "\t│  %  │ sin │ hyp │  7  │  8  │  9  │  ÷  │\r\n" +
                                       "\t├─────┼─────┼─────┼─────┼─────┼─────┼─────┤\r\n" +
                                       "\t│  π  │ cos │ log │  4  │  5  │  6  │  x  │\r\n" +
                                       "\t├─────┼─────┼─────┼─────┼─────┼─────┼─────┤\r\n" +
                                       "\t│  e  │ tan │  √  │  1  │  2  │  3  │  -  │\r\n" +
                                       "\t├─────┼─────┼─────┼─────┼─────┼─────┼─────┤\r\n" +
                                       "\t│  A  │ EXP │  ^  │  0  │  .  │  =  │  +  │\r\n" +
                                       "\t└─────┴─────┴─────┴─────┴─────┴─────┴─────┘\r\n";


            Console.WriteLine(DibujoCalculadora);

            Console.WriteLine(); // Agrega un espacio entre las líneas

            Console.WriteLine("\u001b[1;33m\u001b[1mUtilice las FLECHAS hacia arriba y hacia abajo de su TECLADO para cambiar de opción:\u001b[0m ");

        }

        public static string[] OpcionesMenu = new string[]
        {
            // Secciones y opciones del menú
                "\t\u001b[1;33mAcerca del desarrollador:\u001b[0m", // Sección  
                " ",
                "\t\t\t  Ver su LinkedIn",
                " ",
                "\t\u001b[1;33mCuriosidades:\u001b[0m", // Sección    
                " ",
                "\t\t\t  Historia de las Matemáticas",
                " ",
                "\t\u001b[1;33mOperaciones Aritméticas básicas:\u001b[0m", // Sección
                " ",
                "\t\t\t  Realizar una SUMA",
                "\t\t\t  Realizar una RESTA",
                "\t\t\t  Realizar una MULTIPLICACIÓN",
                "\t\t\t  Realizar una DIVISIÓN",
                " ",
                "\t\u001b[1;33mFunciones Trigonométricas:\u001b[0m", // Sección
                " ",
                "\t\t\t  Calcular el SENO",
                "\t\t\t  Calcular el COSENO",
                "\t\t\t  Calcular la TANGENTE",
                " ",
                "\t\u001b[1;33mOperaciones de Potencia y Raíz:\u001b[0m", // Sección
                " ",
                "\t\t\t  Calcular una POTENCIA",
                "\t\t\t  Realizar una RAÍZ CUADRADA",
                "\t\t\t  Calcular una expresión con POTENCIACIÓN (NOTACIÓN CIENTÍFICA)",
                " ",
                "\t\u001b[1;33mOtras operaciones:\u001b[0m", // Sección
                " ",
                "\t\t\t  Realizar un PORCENTAJE",
                "\t\t\t  Realizar un LOGARITMO NEPERIANO",
                "\t\t\t  Realizar un LOGARITMO COMÚN",
                "\t\t\t  Calcular el ÁREA de un CÍRCULO",
                "\t\t\t  SALIR",

            "\r\n\u001b[1;33m- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\u001b[0m"
        };

        static void ElegirOpcionDelMenu()
        {
            bool Loop = true;

            int counter = 2; // Iniciar desde la primera opción seleccionable

            ConsoleKeyInfo Tecla;

            Console.CursorVisible = false; // Para que desaparezca el cursor de la pantalla

            x = Console.CursorLeft;
            y = Console.CursorTop;

            string Resultado = Menu(OpcionesMenu, counter);

            while (Loop)
            {
                while ((Tecla = Console.ReadKey(true)).Key != ConsoleKey.Enter)
                {
                    switch (Tecla.Key)
                    {
                        case ConsoleKey.DownArrow:
                            do
                            {
                                counter = (counter + 1) % OpcionesMenu.Length;
                            } while (OpcionesMenu[counter].StartsWith("\t\u001b[1;33m") || string.IsNullOrWhiteSpace(OpcionesMenu[counter]) || (OpcionesMenu[counter].StartsWith("\r\n\u001b[1;33m-"))); // Saltar secciones y espacios en blanco                        
                            break;

                        case ConsoleKey.UpArrow:
                            do
                            {
                                counter = (counter - 1 + OpcionesMenu.Length) % OpcionesMenu.Length;
                            } while (OpcionesMenu[counter].StartsWith("\t\u001b[1;33m") || string.IsNullOrWhiteSpace(OpcionesMenu[counter]) || (OpcionesMenu[counter].StartsWith("\r\n\u001b[1;33m-"))); // Saltar secciones y espacios en blanco
                            break;

                        default:
                            break;
                    }

                    // Restaurar la posición del cursor y actualizar el menú
                    Console.SetCursorPosition(x, y);
                    Resultado = Menu(OpcionesMenu, counter);
                }

                if (Resultado.Contains("LinkedIn"))
                {
                    System.Console.Clear();

                    // Abrir la URL en el navegador predeterminado
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "https://www.linkedin.com/in/pavel-rodr%C3%ADguez-galisteo-27976a132/",
                        UseShellExecute = true
                    });

                    Console.WriteLine("\n\u001b[1;33m\u001b[1m¿Qué operación desea realizar?:\u001b[0m ");

                    Console.WriteLine(); // Agrega un espacio entre las líneas
                }

                if (Resultado.Contains("Historia de las Matemáticas"))
                {
                    Console.Clear();

                    HistoriaMatematicas();

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    PreguntarPorOtraOperacionDespuesdeHistoriaMatematicas();

                    SolicitarDecisionUsuario();
                }

                if (Resultado.Contains("Realizar una SUMA"))
                {
                    //Permitir que el usuario pueda realizar una SUMA de x números (por consola)

                    Console.Clear();

                    Console.CursorVisible = true;

                    OperaciónSuma();

                    PasarASiguienteOperaciónSuma();
                }

                if (Resultado.Contains("Realizar una RESTA"))
                {
                    //Permitir que el usuario pueda realizar una RESTA de x números (por consola)

                    Console.Clear();

                    Console.CursorVisible = true;

                    OperaciónResta();

                    PasarASiguienteOperaciónResta();
                }

                if (Resultado.Contains("Realizar una MULTIPLICACIÓN"))
                {
                    // Permitir que el usuario pueda realizar una MULTIPLICACIÓN de x números(por consola)

                    Console.Clear();

                    Console.CursorVisible = true;

                    OperaciónMultiplicación();

                    PasarASiguienteOperaciónMultiplicación();
                }

                if (Resultado.Contains("Realizar una DIVISIÓN"))
                {
                    // Permitir que el usuario pueda realizar una DIVISIÓN de 2 números(por consola)

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.Clear();

                    Console.CursorVisible = true;

                    OperaciónDivisión();

                    PasarASiguienteOperaciónDivisión();

                }

                if (Resultado.Contains("Calcular el SENO"))
                {
                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.CursorVisible = true;

                    // Calcular el SENO 

                    Console.WriteLine("Introduce el ángulo: ");

                    double AnguloSen = double.Parse(Console.ReadLine());

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    CalcularSeno(AnguloSen);

                    PasarASiguienteOperación();
                }

                if (Resultado.Contains("Calcular el COSENO"))
                {
                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.CursorVisible = true;

                    // Calcular el COSENO 

                    Console.WriteLine("Introduce el ángulo: ");

                    double AnguloCos = double.Parse(Console.ReadLine());

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    CalcularCoseno(AnguloCos);

                    PasarASiguienteOperación();
                }

                if (Resultado.Contains("Calcular la TANGENTE"))
                {
                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.CursorVisible = true;

                    // Calcular la TANGENTE 

                    Console.WriteLine("Introduce el ángulo: ");

                    double AnguloTan = double.Parse(Console.ReadLine());

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    CalcularTangente(AnguloTan);

                    PasarASiguienteOperación();
                }

                if (Resultado.Contains("Calcular una POTENCIA"))
                {
                    // Calcular POTENCIAS

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.Clear();

                    Console.CursorVisible = true;

                    CalcularPotencia();

                    PasarASiguienteOperaciónPotencia();
                }

                if (Resultado.Contains("Realizar una RAÍZ CUADRADA"))
                {
                    // Calcular RAÍCES CUADRADAS

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.Clear();

                    Console.CursorVisible = true;

                    CalcularRaizCuadrada();

                    PasarASiguienteOperaciónRaizCuadrada();
                }

                if (Resultado.Contains("Calcular una expresión con POTENCIACIÓN (NOTACIÓN CIENTÍFICA)"))
                {
                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.CursorVisible = true;

                    // Calcular una NOTACIÓN CIENTÍFICA

                    Console.WriteLine("Introduce un número (base): ");

                    double basePotenciación = double.Parse(Console.ReadLine());

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.WriteLine("Introduce un número (exponente): ");

                    int exponentePotenciación = int.Parse(Console.ReadLine());

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    CalcularNotaciónCientífica(basePotenciación, exponentePotenciación);

                    PasarASiguienteOperación();
                }

                if (Resultado.Contains("Realizar un PORCENTAJE"))
                {
                    // Calcular PORCENTAJES

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.Clear();

                    Console.CursorVisible = true;

                    CalcularPorcentaje();

                    PasarASiguienteOperaciónPorcentaje();
                }

                if (Resultado.Contains("Realizar un LOGARITMO NEPERIANO"))
                {
                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.CursorVisible = true;

                    // Calcular Logaritmo Neperiano

                    Console.WriteLine("Introduce el número del que quieres calcular su Logaritmo Neperiano: ");

                    double NúmeroDelQueSeQuiereCalcularSuLn = double.Parse(Console.ReadLine());

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    CalcularLogaritmoNeperiano(NúmeroDelQueSeQuiereCalcularSuLn);

                    PasarASiguienteOperación();
                }

                if (Resultado.Contains("Realizar un LOGARITMO COMÚN"))
                {
                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.CursorVisible = true;

                    // Calcular Logaritmo común o Logaritmo en base 10 

                    Console.WriteLine("Introduce el número del que quieres calcular su Logaritmo común: ");

                    double NúmeroDelQueSeQuiereCalcularSuLog = double.Parse(Console.ReadLine());

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    CalcularLogaritmoComunOEnBase10(NúmeroDelQueSeQuiereCalcularSuLog);

                    PasarASiguienteOperación();
                }

                if (Resultado.Contains("Calcular el ÁREA de un CÍRCULO"))
                {
                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.CursorVisible = true;

                    // Calcular el área de un círculo:

                    Console.WriteLine("Introduce la medida del radio: ");

                    double radio = double.Parse(Console.ReadLine());

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    CalcularAreaCírculo(radio);

                    PasarASiguienteOperación();
                }

                if (Resultado.Contains("SALIR"))
                {
                    Loop = false; // Salir del bucle si la opción seleccionada es "SALIR"
                    MensajeDespedida();
                    Environment.Exit(0);
                }

                if (Loop)
                {
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    x = Console.CursorLeft;
                    y = Console.CursorTop;

                    Resultado = Menu(OpcionesMenu, counter);
                }
            }

            Console.ReadKey();
            Console.Clear();
        }

        //Para controlar la posición actual del cursor:
        private static int x;
        private static int y;

        private static string Menu(string[] items, int opcion)
        {
            string SeleccionActual = string.Empty;
            int destacado = 0;

            foreach (var element in items)
            {
                // Limpiar la línea actual antes de escribir la nueva opción
                Console.SetCursorPosition(x, y + destacado);
                Console.Write(new string(' ', Console.WindowWidth - x));
                Console.SetCursorPosition(x, y + destacado);

                if (destacado == opcion)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\t\t\t" + "< " + element.Trim() + " >");
                    Console.ResetColor();
                    SeleccionActual = element;
                }
                else
                {
                    Console.WriteLine(element);
                }
                destacado++;

            }

            return SeleccionActual;
        }

        static bool Loop = true;
        static int counter = 0;

        static void HistoriaMatematicas()
        {
            Console.WriteLine(); // Agrega un espacio entre las líneas

            Console.WriteLine("\r\nLa \u001b[1;33mhistoria de las matemáticas\u001b[0m es vasta y rica, abarcando miles de años y múltiples civilizaciones. " +
                                     "Aquí tienes un recorrido detallado:" +
                                     "\r\n\r\n\t\u001b[1;33mAntigüedad:\u001b[0m " +
                                     "\r\n\r\n\t\t- \u001b[1mCivilizaciones Antiguas:\u001b[0m Las primeras evidencias de actividad matemática se encuentran en Mesopotamia (actual Irak) y Egipto, donde se desarrollaron sistemas de numeración" +
                                     "\r\n\t\t\t\t\t   y geometría básica para la agricultura, la construcción y la astronomía. Por ejemplo, los egipcios utilizaban fracciones y tenían una buena compren- " +
                                     "\r\n\t\t\t\t\t   sion de la geometría práctica, como se evidencia en las pirámides." +
                                     "\r\n\r\n\t\t- \u001b[1mGrecia Antigua:\u001b[0m Los griegos llevaron las matemáticas a un nuevo nivel con figuras como Pitágoras, Euclides y Arquímedes. Euclides escribió \"Los Elementos\", una colección de " +
                                     "\r\n\t\t\t\t  libros que sistematiza el conocimiento geométrico de la época y se convirtió en una referencia durante siglos. Arquímedes, por su parte, hizo importantes con-" +
                                     "\r\n\t\t\t\t  tribuciones en geometría y cálculo." +
                                     "\r\n\r\n\t\u001b[1;33mEdad Media:\u001b[0m" +
                                     "\r\n\r\n\t\t- \u001b[1mMatemáticas en el Mundo Islámico:\u001b[0m Durante la Edad Media, los matemáticos islámicos, como Al-Juarismi y Omar Khayyam, hicieron avances significativos. Al-Juarismi escribió " +
                                     "\r\n\t\t\t\t\t\t    sobre álgebra y aritmética, introduciendo métodos que se utilizaron en Europa más tarde. La palabra \"álgebra\" proviene del título de su libro " +
                                     "\r\n\t\t\t\t\t\t    Al-Kitab al-Mukhtasar fi Hisab al-Jabr wal-Muqabala\"." +
                                     "\r\n\r\n\t\t- \u001b[1mIndia y China:\u001b[0m En India, matemáticos como Aryabhata y Brahmagupta desarrollaron conceptos avanzados en aritmética, álgebra y trigonometría. En China, figuras como Zu Chongzhi" +
                                     "\r\n\t\t\t         calcularon el valor de π con gran precisión." +
                                     "\r\n\r\n\t\u001b[1;33mRenacimiento y Edad Moderna:\u001b[0m" +
                                     "\r\n\r\n\t\t- \u001b[1mRenacimiento Europeo:\u001b[0m El Renacimiento trajo una revitalización de las matemáticas en Europa. Fibonacci introdujo el sistema numérico árabe (incluyendo el cero) a Europa con su" +
                                     "\r\n\t\t\t\t\tlibro \"Liber Abaci\". Matemáticos como Cardano y Tartaglia avanzaron en la resolución de ecuaciones cúbicas y cuárticas." +
                                     "\r\n\r\n\t\t- \u001b[1mSiglo XVII:\u001b[0m Este siglo vio la invención del cálculo por Isaac Newton y Gottfried Wilhelm Leibniz, un desarrollo crucial que permitió el avance de la física y otras ciencias." +
                                     "\r\n\t\t\t      Pierre de Fermat y Blaise Pascal sentaron las bases de la teoría de probabilidades." +
                                     "\r\n\r\n\t\u001b[1;33mSiglos XVIII y XIX:\u001b[0m" +
                                     "\r\n\r\n\t\t- \u001b[1mTeoría de Números y Algebra:\u001b[0m Matemáticos como Carl Friedrich Gauss hicieron importantes contribuciones en teoría de números, álgebra y análisis. La teoría de grupos comenzó a" +
                                     "\r\n\t\t\t\t\t       desarrollarse, con Évariste Galois haciendo contribuciones fundamentales." +
                                     "\r\n\r\n\t\t- \u001b[1mGeometría No Euclidiana:\u001b[0m Nikolai Lobachevsky y János Bolyai, seguidos por Bernhard Riemann, desarrollaron geometrías no euclidianas, que más tarde se convertirían en fundamen-" +
                                     "\r\n\t\t\t\t           tales para la teoría de la relatividad de Einstein." +
                                     "\r\n\r\n\t\u001b[1;33mSiglo XX y Actualidad:\u001b[0m" +
                                     "\r\n\r\n\t\t- \u001b[1mMatemáticas Aplicadas y Computación:\u001b[0m El siglo XX vio un crecimiento explosivo en todas las ramas de las matemáticas. La lógica matemática fue desarrollada por Kurt Gödel, Alan" +
                                     "\r\n\t\t\t\t\t\t       Turing y otros, sentando las bases para la informática y la teoría de la computación." +
                                     "\r\n\r\n\t\t- \u001b[1mTeoría de Conjuntos y Topología:\u001b[0m La teoría de conjuntos, desarrollada por Georg Cantor, se convirtió en la base para gran parte de la matemática moderna. La topología, el estu-" +
                                     "\r\n\t\t\t\t\t           dio de las propiedades de los espacios, también se expandió significativamente." +
                                     "\r\n\r\n\t\t- \u001b[1mMatemáticas Modernas:\u001b[0m Hoy en día, las matemáticas abarcan campos tan diversos como la criptografía, teoría de juegos, análisis funcional, y aplicaciones en biología, economía" +
                                     "\r\n\t\t\t                y otras ciencias." +
                                     "" +
                                     "\r\n\r\nLa historia de las matemáticas es un testimonio del ingenio humano y su capacidad para abstraer, generalizar y aplicar conceptos a una variedad de problemas en el mundo real." +

            "\r\u001b[1;33m- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - \u001b[0m");
        }
        static void OperaciónSuma()
        {
            Console.WriteLine();
            Console.WriteLine("Introduce el primer número de la suma:");
            double numSuma1;

            if (!double.TryParse(Console.ReadLine(), out numSuma1))
            {
                Console.WriteLine(); // Agrega un espacio entre las líneas
                Console.WriteLine("\u001b[1;33m\u001b[1mPor favor, introduzca un número válido.\u001b[0m");
                OperaciónSuma();
                return; // Salir del programa si la entrada no es válida
            }

            Console.WriteLine(); // Agrega un espacio entre las líneas

            double numSuma2;
            while (true)
            {
                Console.WriteLine("Introduce el segundo número de la suma:");

                if (double.TryParse(Console.ReadLine(), out numSuma2))
                {
                    break; // Salir del bucle si la entrada es válida
                }
                else
                {
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    Console.WriteLine("\u001b[1;33m\u001b[1mPor favor, introduzca un número válido.\u001b[0m");
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                }
            }

            // Variable para almacenar los números introducidos por el usuario
            string numerosSumados = $"{numSuma1} + {numSuma2}";

            Console.WriteLine(); // Agrega un espacio entre las líneas

            // Variable para almacenar la suma total
            double sumaTotal = numSuma1 + numSuma2;

            Console.WriteLine($"El resultado de la suma de {numerosSumados} es: \u001b[1;36m{sumaTotal}\u001b[0m");

            Console.WriteLine(); // Agrega un espacio entre las líneas

            // Preguntar al usuario si desea sumar más números
            string DecisionUsuario = "";
            bool mostradoResultado = false; // Variable para rastrear si se ha mostrado la suma durante la iteración
            do
            {
                Console.WriteLine("\u001b[1;33m\u001b[1m¿Desea incluir algún número más a su suma? (s/n)\u001b[0m ");
                DecisionUsuario = Console.ReadLine().ToLower();


                if (DecisionUsuario == "s")
                {
                    double numSumax;

                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    Console.WriteLine("Introduce el siguiente número de la suma: ");

                    while (!double.TryParse(Console.ReadLine(), out numSumax))
                    {
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        Console.WriteLine("\u001b[1;33m\u001b[1mPor favor, introduzca un número válido.\u001b[0m");
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        Console.WriteLine("Introduce el siguiente número de la suma: ");
                    }

                    // Agregar el número a la lista de números sumados
                    numerosSumados += $" + {numSumax}";

                    // Agregar el número a la suma total
                    sumaTotal += numSumax;

                    // Mostrar la suma actualizada
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    Console.WriteLine($"La suma de {numerosSumados} es: \u001b[1;36m{sumaTotal}\u001b[0m");
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    mostradoResultado = true; // Marcar como verdadero porque se ha mostrado la suma
                }

                if (DecisionUsuario == "n")
                {
                    break;
                }

                else if (DecisionUsuario != "n" && DecisionUsuario != "s")
                {
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    Console.WriteLine("Entrada no válida. Por favor, introduzca '\u001b[1;33m\u001b[1ms\u001b[0m' para continuar sumando o '\u001b[1;33m\u001b[1mn\u001b[0m' para finalizar.");
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                }

            } while (DecisionUsuario != "n");
        }

        static void OperaciónResta()
        {
            Console.WriteLine();
            Console.WriteLine("Introduce el primer número de la resta:");
            double numResta1;

            if (!double.TryParse(Console.ReadLine(), out numResta1))
            {
                Console.WriteLine(); // Agrega un espacio entre las líneas
                Console.WriteLine("\u001b[1;33m\u001b[1mPor favor, introduzca un número válido.\u001b[0m");
                OperaciónResta();
                return; // Salir del programa si la entrada no es válida
            }

            Console.WriteLine(); // Agrega un espacio entre las líneas

            double numResta2;
            while (true)
            {
                Console.WriteLine("Introduce el segundo número de la resta:");

                if (double.TryParse(Console.ReadLine(), out numResta2))
                {
                    break; // Salir del bucle si la entrada es válida
                }
                else
                {
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    Console.WriteLine("\u001b[1;33m\u001b[1mPor favor, introduzca un número válido.\u001b[0m");
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                }
            }

            // Variable para almacenar los números introducidos por el usuario
            string numerosRestados = $"{numResta1} - {numResta2}";

            Console.WriteLine(); // Agrega un espacio entre las líneas

            // Variable para almacenar la resta total
            double restaTotal = numResta1 - numResta2;

            Console.WriteLine($"El resultado de la resta de {numerosRestados} es: \u001b[1;36m{restaTotal}\u001b[0m");

            Console.WriteLine(); // Agrega un espacio entre las líneas

            // Preguntar al usuario si desea sumar más números
            string DecisionUsuario = "";
            bool mostradoResultado = false; // Variable para rastrear si se ha mostrado la suma durante la iteración
            do
            {
                Console.WriteLine("\u001b[1;33m\u001b[1m¿Desea incluir algún número más a su resta? (s/n)\u001b[0m ");
                DecisionUsuario = Console.ReadLine().ToLower();


                if (DecisionUsuario == "s")
                {
                    double numRestax;

                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    Console.WriteLine("Introduce el siguiente número de la resta: ");

                    while (!double.TryParse(Console.ReadLine(), out numRestax))
                    {
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        Console.WriteLine("\u001b[1;33m\u001b[1mPor favor, introduzca un número válido.\u001b[0m");
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        Console.WriteLine("Introduce el siguiente número de la resta: ");
                    }

                    // Agregar el número a la lista de números sumados
                    numerosRestados += $" - {numRestax}";

                    // Agregar el número a la resta total
                    restaTotal -= numRestax;

                    // Mostrar la suma actualizada
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    Console.WriteLine($"La resta de {numerosRestados} es: \u001b[1;36m{restaTotal}\u001b[0m");
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    mostradoResultado = true; // Marcar como verdadero porque se ha mostrado la suma
                }

                if (DecisionUsuario == "n")
                {
                    break;
                }

                else if (DecisionUsuario != "n" && DecisionUsuario != "s")
                {
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    Console.WriteLine("Entrada no válida. Por favor, introduzca '\u001b[1;33m\u001b[1ms\u001b[0m' para continuar restando o '\u001b[1;33m\u001b[1mn\u001b[0m' para finalizar.");
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                }

            } while (DecisionUsuario != "n");
        }

        static void OperaciónMultiplicación()
        {
            Console.WriteLine();
            Console.WriteLine("Introduce el primer número de la multiplicación:");
            double numMultiplicación1;

            if (!double.TryParse(Console.ReadLine(), out numMultiplicación1))
            {
                Console.WriteLine(); // Agrega un espacio entre las líneas
                Console.WriteLine("\u001b[1;33m\u001b[1mPor favor, introduzca un número válido.\u001b[0m");
                OperaciónMultiplicación();
                return; // Salir del programa si la entrada no es válida
            }

            Console.WriteLine(); // Agrega un espacio entre las líneas
            double numMultiplicación2;
            while (true)
            {
                Console.WriteLine("Introduce el segundo número de la multiplicación:");

                if (double.TryParse(Console.ReadLine(), out numMultiplicación2))
                {
                    break; // Salir del bucle si la entrada es válida
                }
                else
                {
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    Console.WriteLine("\u001b[1;33m\u001b[1mPor favor, introduzca un número válido.\u001b[0m");
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                }
            }

            // Variable para almacenar los números introducidos por el usuario
            string numerosMultiplicados = $"{numMultiplicación1} x {numMultiplicación2}";

            Console.WriteLine(); // Agrega un espacio entre las líneas

            // Variable para almacenar la resta total
            double multiplicaciónTotal = numMultiplicación1 * numMultiplicación2;

            Console.WriteLine($"El resultado de la multiplicación de {numerosMultiplicados} es: \u001b[1;36m{multiplicaciónTotal}\u001b[0m");

            Console.WriteLine(); // Agrega un espacio entre las líneas

            // Preguntar al usuario si desea multiplicar más números
            string DecisionUsuario = "";
            bool mostradoResultado = false; // Variable para rastrear si se ha mostrado la multiplicación durante la iteración
            do
            {
                Console.WriteLine("\u001b[1;33m\u001b[1m¿Desea incluir algún número más a su multiplicación? (s/n)\u001b[0m ");
                DecisionUsuario = Console.ReadLine().ToLower();

                if (DecisionUsuario == "s")
                {
                    double numMultiplicaciónx;

                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    Console.WriteLine("Introduce el siguiente número de la multiplicación: ");

                    while (!double.TryParse(Console.ReadLine(), out numMultiplicaciónx))
                    {
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        Console.WriteLine("\u001b[1;33m\u001b[1mPor favor, introduzca un número válido.\u001b[0m");
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        Console.WriteLine("Introduce el siguiente número de la multiplicación: ");
                    }

                    // Agregar el número a la lista de números sumados
                    numerosMultiplicados += $" X {numMultiplicaciónx}";

                    // Agregar el número a la multiplicación total
                    multiplicaciónTotal *= numMultiplicaciónx;

                    // Mostrar la multiplicación actualizada
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    Console.WriteLine($"La multiplicación de {numerosMultiplicados} es: \u001b[1;36m{multiplicaciónTotal}\u001b[0m");
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    mostradoResultado = true; // Marcar como verdadero porque se ha mostrado la multiplicación
                }

                if (DecisionUsuario == "n")
                {
                    break;
                }

                else if (DecisionUsuario != "n" && DecisionUsuario != "s")
                {
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    Console.WriteLine("Entrada no válida. Por favor, introduzca '\u001b[1;33m\u001b[1ms\u001b[0m' para continuar multiplicando o '\u001b[1;33m\u001b[1mn\u001b[0m' para finalizar.");
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                }

            } while (DecisionUsuario != "n");
        }

        static void OperaciónDivisión()
        {
            Console.WriteLine();
            Console.WriteLine("Introduce el primer número de la división:");
            double numDivisión1;

            if (!double.TryParse(Console.ReadLine(), out numDivisión1))
            {
                Console.WriteLine(); // Agrega un espacio entre las líneas
                Console.WriteLine("\u001b[1;33m\u001b[1mPor favor, introduzca un número válido.\u001b[0m");
                OperaciónDivisión();
                return; // Salir del programa si la entrada no es válida
            }

            Console.WriteLine(); // Agrega un espacio entre las líneas
            double numDivisión2;
            while (true)
            {
                Console.WriteLine("Introduce el segundo número de la división:");

                if (double.TryParse(Console.ReadLine(), out numDivisión2))
                {
                    break; // Salir del bucle si la entrada es válida
                }
                else
                {
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    Console.WriteLine("\u001b[1;33m\u001b[1mPor favor, introduzca un número válido.\u001b[0m");
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                }
            }

            // Variable para almacenar los números introducidos por el usuario
            string numerosDivididos = $"{numDivisión1} : {numDivisión2}";

            Console.WriteLine(); // Agrega un espacio entre las líneas

            // Variable para almacenar la división total
            double DivisiónTotal = numDivisión1 / numDivisión2;

            Console.WriteLine($"El resultado de la división de {numerosDivididos} es: \u001b[1;36m{DivisiónTotal}\u001b[0m");

            Console.WriteLine(); // Agrega un espacio entre las líneas

            // Preguntar al usuario si desea multiplicar más números
            string DecisionUsuario = "";
            bool mostradoResultado = false; // Variable para rastrear si se ha mostrado la multiplicación durante la iteración
            do
            {
                Console.WriteLine("\u001b[1;33m\u001b[1m¿Desea incluir algún número más a su división? (s/n)\u001b[0m ");
                DecisionUsuario = Console.ReadLine().ToLower();

                if (DecisionUsuario == "s")
                {
                    double numDivisiónx;

                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    Console.WriteLine("Introduce el siguiente número de la división: ");

                    while (!double.TryParse(Console.ReadLine(), out numDivisiónx))
                    {
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        Console.WriteLine("\u001b[1;33m\u001b[1mPor favor, introduzca un número válido.\u001b[0m");
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        Console.WriteLine("Introduce el siguiente número de la división: ");
                    }

                    // Agregar el número a la lista de números divididos
                    numerosDivididos += $" : {numDivisiónx}";

                    // Agregar el número a la división total
                    DivisiónTotal /= numDivisiónx;

                    // Mostrar la suma actualizada
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    Console.WriteLine($"La división de {numerosDivididos} es: \u001b[1;36m{DivisiónTotal}\u001b[0m");
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    mostradoResultado = true; // Marcar como verdadero porque se ha mostrado la multiplicación
                }

                if (DecisionUsuario == "n")
                {
                    break;
                }

                else if (DecisionUsuario != "n" && DecisionUsuario != "s")
                {
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    Console.WriteLine("Entrada no válida. Por favor, introduzca '\u001b[1;33m\u001b[1ms\u001b[0m' para continuar dividiendo o '\u001b[1;33m\u001b[1mn\u001b[0m' para finalizar.");
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                }

            } while (DecisionUsuario != "n");
        }

        static void CalcularSeno(double AnguloSen)
        {
            double ResultadoSen = Math.Sin(AnguloSen);

            Console.WriteLine("El seno del ángulo " + AnguloSen + " es: " + "\u001b[1;36m" + ResultadoSen + "\u001b[0m");
        }

        static void CalcularCoseno(double AnguloCos)
        {
            double ResultadoCos = Math.Cos(AnguloCos);

            Console.WriteLine("El coseno del ángulo " + AnguloCos + " es: " + "\u001b[1;36m" + ResultadoCos + "\u001b[0m");
        }

        static void CalcularTangente(double AnguloTan)
        {
            double ResultadoTan = Math.Tan(AnguloTan);

            Console.WriteLine("La tangente del ángulo " + AnguloTan + " es: " + "\u001b[1;36m" + ResultadoTan + "\u001b[0m");
        }

        static void CalcularPotencia()
        {
            Console.WriteLine();

            Console.WriteLine("Introduce la base de la potencia: ");
            double basePotencia;
            while (!double.TryParse(Console.ReadLine(), out basePotencia))
            {
                Console.WriteLine(); // Agrega un espacio entre las líneas
                Console.WriteLine("\u001b[1;33m\u001b[1mPor favor, introduzca un número válido.\u001b[0m");
                Console.WriteLine(); // Agrega un espacio entre las líneas
                Console.WriteLine("Introduce la base de la potencia: ");
            }

            Console.WriteLine(); // Agrega un espacio entre las líneas

            Console.WriteLine("Introduce el exponente de la potencia: ");
            double exponentePotencia;
            while (!double.TryParse(Console.ReadLine(), out exponentePotencia))
            {
                Console.WriteLine(); // Agrega un espacio entre las líneas
                Console.WriteLine("\u001b[1;33m\u001b[1mPor favor, introduzca un número válido.\u001b[0m");
                Console.WriteLine(); // Agrega un espacio entre las líneas
                Console.WriteLine("Introduce el exponente de la potencia: ");
            }

            double PotenciaTotal = Math.Pow(basePotencia, exponentePotencia);

            List<string> numerosPotencia = new List<string> { $"{basePotencia} ^ {exponentePotencia}" };

            Console.WriteLine(); // Agrega un espacio entre las líneas

            Console.WriteLine($"El resultado de {basePotencia} ^ {exponentePotencia} es: \u001b[1;36m{PotenciaTotal}\u001b[0m");

            Console.WriteLine(); // Agrega un espacio entre las líneas

            // Preguntar al usuario si desea elevar más números
            string DecisionUsuario = "";
            do
            {
                Console.WriteLine("\u001b[1;33m\u001b[1m¿Desea elevar algún número más? (s/n)\u001b[0m ");
                DecisionUsuario = Console.ReadLine().ToLower();

                if (DecisionUsuario == "s")
                {
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    Console.WriteLine("Introduce el siguiente exponente que desea elevar: ");

                    double exponentex;
                    while (!double.TryParse(Console.ReadLine(), out exponentex))
                    {
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        Console.WriteLine("\u001b[1;33m\u001b[1mPor favor, introduzca un número válido.\u001b[0m");
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        Console.WriteLine("Introduce el siguiente exponente que desea elevar: ");
                    }

                    numerosPotencia.Add($" ^ {exponentex}");
                    PotenciaTotal = Math.Pow(PotenciaTotal, exponentex);

                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    Console.WriteLine($"El resultado de elevar a la potencia {string.Join("", numerosPotencia)} es: \u001b[1;36m{PotenciaTotal}\u001b[0m");
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                }

                if (DecisionUsuario == "n")
                {
                    break;
                }
                else if (DecisionUsuario != "n" && DecisionUsuario != "s")
                {
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    Console.WriteLine("Entrada no válida. Por favor, introduzca '\u001b[1;33m\u001b[1ms\u001b[0m' para continuar elevando a la potencia o '\u001b[1;33m\u001b[1mn\u001b[0m' para finalizar.");
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                }

            } while (DecisionUsuario != "n");
        }

        static void CalcularRaizCuadrada()
        {
            Console.WriteLine();
            Console.WriteLine("Introduce el número del que quieres calcular su raíz cuadrada: ");

            double NumRaizCuadrada;
            while (!double.TryParse(Console.ReadLine(), out NumRaizCuadrada))
            {
                Console.WriteLine(); // Agrega un espacio entre las líneas
                Console.WriteLine("\u001b[1;33m\u001b[1mPor favor, introduzca un número válido.\u001b[0m");
                Console.WriteLine();
                Console.WriteLine("Introduce el número del que quieres calcular su raíz cuadrada: ");
            }

            double ResultadoRaizCuadrada = Math.Sqrt(NumRaizCuadrada);

            Console.WriteLine(); // Agrega un espacio entre las líneas

            Console.WriteLine("El resultado de la raíz cuadrada de " + NumRaizCuadrada + " es: " + "\u001b[1;36m" + ResultadoRaizCuadrada + "\u001b[0m");

            Console.WriteLine(); // Agrega un espacio entre las líneas

            // Preguntar al usuario si desea continuar calculando la raíz cuadrada
            string DecisionUsuario = "";
            do
            {
                Console.WriteLine("\u001b[1;33m\u001b[1m¿Desea continuar con su raíz cuadrada? (s/n)\u001b[0m ");
                DecisionUsuario = Console.ReadLine().ToLower();

                if (DecisionUsuario == "s")
                {
                    NumRaizCuadrada = ResultadoRaizCuadrada; // Usamos el resultado anterior como nuevo número
                    ResultadoRaizCuadrada = Math.Sqrt(NumRaizCuadrada);

                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    Console.WriteLine("El resultado de la raíz cuadrada de " + NumRaizCuadrada + " es: " + "\u001b[1;36m" + ResultadoRaizCuadrada + "\u001b[0m");
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                }

                if (DecisionUsuario != "s" && DecisionUsuario != "n")
                {
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    Console.WriteLine("Entrada no válida. Por favor, introduzca '\u001b[1;33m\u001b[1ms\u001b[0m' para continuar o '\u001b[1;33m\u001b[1mn\u001b[0m' para finalizar.");
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                }

            } while (DecisionUsuario != "n");
        }

        static void CalcularNotaciónCientífica(double basePotenciación, double exponentePotenciación)
        {
            double ResultadoPotenciación = basePotenciación * (double)Math.Pow(10, exponentePotenciación);

            Console.WriteLine(basePotenciación + " multiplicado por 10 elevado a " + exponentePotenciación + " es: " + "\u001b[1;36m" + ResultadoPotenciación + "\u001b[0m");
        }

        static void CalcularPorcentaje()
        {
            double resultado = 0;

            Console.WriteLine();

            bool continuar = true;
            bool esPrimeraVez = true;
            double numero = 0;

            while (continuar)
            {
                double porcentaje;
                Console.WriteLine("Introduce el % que quieres calcular:");
                while (!double.TryParse(Console.ReadLine(), out porcentaje))
                {
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    Console.WriteLine("\u001b[1;33m\u001b[1mPor favor, introduzca un número válido.\u001b[0m");
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                    Console.WriteLine("Introduce el % que quieres calcular:");
                }

                Console.WriteLine();

                if (esPrimeraVez)
                {
                    Console.WriteLine("Introduce el número sobre el cual deseas calcular el porcentaje:");
                    while (!double.TryParse(Console.ReadLine(), out numero))
                    {
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        Console.WriteLine("\u001b[1;33m\u001b[1mPor favor, introduzca un número válido.\u001b[0m");
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        Console.WriteLine("Introduce el número sobre el cual deseas calcular el porcentaje:");

                    }
                    Console.WriteLine();
                    esPrimeraVez = false;  // La próxima vez ya no será la primera vez
                }

                resultado = (numero * porcentaje) / 100;
                Console.WriteLine($"El {porcentaje}% de {numero} es: \u001b[1;36m{resultado}\u001b[0m");
                Console.WriteLine();

                while (true)
                {
                    Console.WriteLine("\u001b[1;33m\u001b[1m¿Deseas calcular otro porcentaje sobre el último resultado? (s/n)\u001b[0m");
                    string respuesta = Console.ReadLine().ToLower();

                    if (respuesta == "s")
                    {
                        Console.WriteLine();
                        continuar = true;
                        break;
                    }
                    else if (respuesta == "n")
                    {
                        continuar = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Entrada no válida. Por favor, introduzca '\u001b[1;33m\u001b[1ms\u001b[0m' para continuar o '\u001b[1;33m\u001b[1mn\u001b[0m' para finalizar.");
                        Console.WriteLine();
                    }
                }

                if (continuar)
                {
                    numero = resultado; // Actualiza el número base para el siguiente cálculo
                }
            }
        }

        static void CalcularLogaritmoNeperiano(double NúmeroDelQueSeQuiereCalcularSuLn)
        {
            double ResultadoLogaritmoNeperiano = Math.Log(NúmeroDelQueSeQuiereCalcularSuLn);

            Console.WriteLine("El ln del número " + NúmeroDelQueSeQuiereCalcularSuLn + " es: " + "\u001b[1;36m" + ResultadoLogaritmoNeperiano + "\u001b[0m");
        }

        static void CalcularLogaritmoComunOEnBase10(double NúmeroDelQueSeQuiereCalcularSuLog)
        {
            double ResultadoLogaritmoComun = Math.Log(NúmeroDelQueSeQuiereCalcularSuLog, 10);

            Console.WriteLine("El log del número " + NúmeroDelQueSeQuiereCalcularSuLog + " es: " + "\u001b[1;36m" + ResultadoLogaritmoComun + "\u001b[0m");
        }

        static void CalcularAreaCírculo(double radio)
        {
            const double PI = Math.PI;

            double area = radio * radio * PI;

            Console.WriteLine($"El área del círculo es: \u001b[1;36m{area}\u001b[0m");
        }

        static void PreguntarPorOtraOperacionDespuesdeHistoriaMatematicas()
        {
            Console.WriteLine("\u001b[1;33m¿Desea realizar otra operación con la CALCULADORA?\u001b[0m" + Environment.NewLine);

            Console.WriteLine("\t\t- Pulse 1 para realizar otra operación" + Environment.NewLine);
            Console.WriteLine("\t\t- Pulse 2 si desea SALIR" + Environment.NewLine);

            Console.CursorVisible = true;
        }

        static void PreguntarPorOtraOperacionDespuesDeCalcularSuma()
        {
            bool opcionValida = false;

            do
            {
                //Console.WriteLine();
                Console.WriteLine("\u001b[1;33m¿Desea realizar otra operación con la CALCULADORA?\u001b[0m" + Environment.NewLine);

                Console.WriteLine("-. Pulse 1 para realizar otra Suma" + Environment.NewLine);
                Console.WriteLine("-. Pulse 2 para realizar otra operación" + Environment.NewLine);
                Console.WriteLine("-. Pulse 3 si desea SALIR" + Environment.NewLine);

                Console.CursorVisible = true;

                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        OperaciónSuma();
                        Console.WriteLine("\r\n\u001b[1;33m- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\u001b[0m");
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        PreguntarPorOtraOperacionDespuesDeCalcularSuma();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("\n\u001b[1;33m\u001b[1m¿Qué operación desea realizar? (Utilice las flechas hacia arriba y hacia abajo de su teclado para cambiar de opción):");
                        Console.CursorVisible = false;
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        bool Loop = true;

                        ElegirOpcionDelMenu();

                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case "3":
                        Console.CursorVisible = false;
                        MensajeDespedida();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("\u001b[1;33mOpción no válida. Pulse '1', '2' o '3'\u001b[0m");
                        Console.WriteLine();
                        break;
                }
            } while (!opcionValida); // Repetir hasta que se ingrese una opción válida

        }

        static void PreguntarPorOtraOperacionDespuesDeCalcularResta()
        {

            bool opcionValida = false;

            do
            {
                //Console.WriteLine();
                Console.WriteLine("\u001b[1;33m¿Desea realizar otra operación con la CALCULADORA?\u001b[0m" + Environment.NewLine);

                Console.WriteLine("-. Pulse 1 para realizar otra Resta" + Environment.NewLine);
                Console.WriteLine("-. Pulse 2 para realizar otra operación" + Environment.NewLine);
                Console.WriteLine("-. Pulse 3 si desea SALIR" + Environment.NewLine);

                Console.CursorVisible = true;

                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        OperaciónResta();
                        Console.WriteLine("\r\n\u001b[1;33m- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\u001b[0m");
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        PreguntarPorOtraOperacionDespuesDeCalcularResta();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("\n\u001b[1;33m\u001b[1m¿Qué operación desea realizar? (Utilice las flechas hacia arriba y hacia abajo de su teclado para cambiar de opción):");
                        Console.CursorVisible = false;
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        ElegirOpcionDelMenu();
                        bool Loop = true;
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Console.CursorVisible = false;
                        MensajeDespedida();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\u001b[1;33mOpción no válida. Pulse '1', '2' o '3'\u001b[0m");
                        Console.WriteLine();
                        break;
                }
            } while (!opcionValida); // Repetir hasta que se ingrese una opción válida
        }

        static void PreguntarPorOtraOperacionDespuesDeCalcularMultiplicación()
        {

            bool opcionValida = false;

            do
            {
                Console.WriteLine("\u001b[1;33m¿Desea realizar otra operación con la CALCULADORA?\u001b[0m" + Environment.NewLine);

                Console.WriteLine("-. Pulse 1 para realizar otra multiplicación" + Environment.NewLine);
                Console.WriteLine("-. Pulse 2 para realizar otra operación" + Environment.NewLine);
                Console.WriteLine("-. Pulse 3 si desea SALIR" + Environment.NewLine);

                Console.CursorVisible = true;

                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        OperaciónMultiplicación();
                        Console.WriteLine("\r\n\u001b[1;33m- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\u001b[0m");
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        PreguntarPorOtraOperacionDespuesDeCalcularMultiplicación();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("\n\u001b[1;33m\u001b[1m¿Qué operación desea realizar? (Utilice las flechas hacia arriba y hacia abajo de su teclado para cambiar de opción):");
                        Console.CursorVisible = false;
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        ElegirOpcionDelMenu();
                        bool Loop = true;
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Console.CursorVisible = false;
                        MensajeDespedida();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\u001b[1;33mOpción no válida. Pulse '1', '2' o '3'\u001b[0m");
                        Console.WriteLine();
                        break;
                }
            } while (!opcionValida); // Repetir hasta que se ingrese una opción válida
        }

        static void PreguntarPorOtraOperacionDespuesDeCalcularDivisión()
        {


            bool opcionValida = false;

            do
            {
                //Console.WriteLine();
                Console.WriteLine("\u001b[1;33m¿Desea realizar otra operación con la CALCULADORA?\u001b[0m" + Environment.NewLine);

                Console.WriteLine("-. Pulse 1 para realizar otra división" + Environment.NewLine);
                Console.WriteLine("-. Pulse 2 para realizar otra operación" + Environment.NewLine);
                Console.WriteLine("-. Pulse 3 si desea SALIR" + Environment.NewLine);

                Console.CursorVisible = true;

                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        OperaciónDivisión();
                        Console.WriteLine("\r\n\u001b[1;33m- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\u001b[0m");
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        PreguntarPorOtraOperacionDespuesDeCalcularDivisión();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("\n\u001b[1;33m\u001b[1m¿Qué operación desea realizar? (Utilice las flechas hacia arriba y hacia abajo de su teclado para cambiar de opción):");
                        Console.CursorVisible = false;
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        ElegirOpcionDelMenu();
                        bool Loop = true;
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Console.CursorVisible = false;
                        MensajeDespedida();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\u001b[1;33mOpción no válida. Pulse '1', '2' o '3'\u001b[0m");
                        Console.WriteLine();
                        break;
                }
            } while (!opcionValida); // Repetir hasta que se ingrese una opción válida
        }

        static void PreguntarPorOtraOperacionDespuesDeCalcularPotencia()
        {

            bool opcionValida = false;

            do
            {
                //Console.WriteLine();
                Console.WriteLine("\u001b[1;33m¿Desea realizar otra operación con la CALCULADORA?\u001b[0m" + Environment.NewLine);

                Console.WriteLine("-. Pulse 1 para realizar otra potencia" + Environment.NewLine);
                Console.WriteLine("-. Pulse 2 para realizar otra operación" + Environment.NewLine);
                Console.WriteLine("-. Pulse 3 si desea SALIR" + Environment.NewLine);

                Console.CursorVisible = true;

                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        CalcularPotencia();
                        Console.WriteLine("\r\n\u001b[1;33m- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\u001b[0m");
                        Console.WriteLine(); // Agrega un espacio entre las líneas;
                        PreguntarPorOtraOperacionDespuesDeCalcularPotencia();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("\n\u001b[1;33m\u001b[1m¿Qué operación desea realizar? (Utilice las flechas hacia arriba y hacia abajo de su teclado para cambiar de opción):");
                        Console.CursorVisible = false;
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        ElegirOpcionDelMenu();
                        bool Loop = true;
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Console.CursorVisible = false;
                        MensajeDespedida();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\u001b[1;33mOpción no válida. Pulse '1', '2' o '3'\u001b[0m");
                        Console.WriteLine();
                        break;
                }
            } while (!opcionValida); // Repetir hasta que se ingrese una opción válida
        }

        static void PreguntarPorOtraOperacionDespuesDeCalcularRaizCuadrada()
        {
            bool opcionValida = false;

            do
            {
                //Console.WriteLine();
                Console.WriteLine("\u001b[1;33m¿Desea realizar otra operación con la CALCULADORA?\u001b[0m" + Environment.NewLine);

                Console.WriteLine("-. Pulse 1 para realizar otra raíz cuadrada" + Environment.NewLine);
                Console.WriteLine("-. Pulse 2 para realizar otra operación" + Environment.NewLine);
                Console.WriteLine("-. Pulse 3 si desea SALIR" + Environment.NewLine);

                Console.CursorVisible = true;

                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        CalcularRaizCuadrada();
                        Console.WriteLine("\r\n\u001b[1;33m- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\u001b[0m");
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        PreguntarPorOtraOperacionDespuesDeCalcularRaizCuadrada();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("\n\u001b[1;33m\u001b[1m¿Qué operación desea realizar? (Utilice las flechas hacia arriba y hacia abajo de su teclado para cambiar de opción):");
                        Console.CursorVisible = false;
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        ElegirOpcionDelMenu();
                        bool Loop = true;
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Console.CursorVisible = false;
                        MensajeDespedida();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\u001b[1;33mOpción no válida. Pulse '1', '2' o '3'\u001b[0m");
                        Console.WriteLine();
                        break;
                }
            } while (!opcionValida); // Repetir hasta que se ingrese una opción válida
        }

        static void PreguntarPorOtraOperacionDespuesDeCalcularPorcentaje()
        {
            bool opcionValida = false;

            do
            {
                Console.WriteLine("\u001b[1;33m¿Desea realizar otra operación con la CALCULADORA?\u001b[0m" + Environment.NewLine);

                Console.WriteLine("-. Pulse 1 para realizar otro porcentaje" + Environment.NewLine);
                Console.WriteLine("-. Pulse 2 para realizar otra operación" + Environment.NewLine);
                Console.WriteLine("-. Pulse 3 si desea SALIR" + Environment.NewLine);

                Console.CursorVisible = true;

                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        CalcularPorcentaje();
                        Console.WriteLine("\r\n\u001b[1;33m- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\u001b[0m");
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        PreguntarPorOtraOperacionDespuesDeCalcularPorcentaje();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("\n\u001b[1;33m\u001b[1m¿Qué operación desea realizar? (Utilice las flechas hacia arriba y hacia abajo de su teclado para cambiar de opción):");
                        Console.CursorVisible = false;
                        Console.WriteLine(); // Agrega un espacio entre las líneas
                        ElegirOpcionDelMenu();
                        bool Loop = true;
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Console.CursorVisible = false;
                        MensajeDespedida();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\u001b[1;33mOpción no válida. Pulse '1', '2' o '3'\u001b[0m");
                        Console.WriteLine();
                        break;
                }
            } while (!opcionValida); // Repetir hasta que se ingrese una opción válida
        }

        static void PreguntarPorOtraOperacionDespuesDeCalcularAlgo()
        {
            Console.WriteLine("\u001b[1;33m¿Desea realizar otra operación con la CALCULADORA?\u001b[0m" + Environment.NewLine);

            Console.WriteLine("-. Pulse 1 para realizar otra operación" + Environment.NewLine);
            Console.WriteLine("-. Pulse 2 si desea SALIR" + Environment.NewLine);

            Console.CursorVisible = true;
        }

        static void SolicitarDecisionUsuarioSuma()
        {
            string DecisionUsuario; // Declarar Decision Usuario fuera del bucle

            do
            {
                DecisionUsuario = Console.ReadLine();


                if (DecisionUsuario == "1")
                {
                    System.Console.Clear();
                    Console.WriteLine();
                    OperaciónSuma();
                    Console.WriteLine();
                    PreguntarPorOtraOperacionDespuesDeCalcularSuma();
                }

                else if (DecisionUsuario == "2")
                {
                    System.Console.Clear();
                    Console.WriteLine("\n\u001b[1;33m\u001b[1m¿Qué operación desea realizar? (Utilice las flechas hacia arriba y hacia abajo de su teclado para cambiar de opción):");
                    counter = 2;
                    Console.CursorVisible = false;
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                }
                else if (DecisionUsuario == "3")
                {
                    Console.CursorVisible = false;
                    MensajeDespedida();
                    Environment.Exit(0);
                }
                else
                {
                    Loop = true; // Volver a solicitar la entrada
                    Console.WriteLine();
                    Console.WriteLine("\u001b[1;33mmPor favor, ingrese '1' o '2'.\u001b[0m");
                }
            } while (DecisionUsuario != "1" && DecisionUsuario != "2"); // El bucle continúa mientras Loop sea true
        }

        static void SolicitarDecisionUsuarioResta()
        {
            string DecisionUsuario; // Declarar Decision Usuario fuera del bucle

            do
            {
                DecisionUsuario = Console.ReadLine();


                if (DecisionUsuario == "1")
                {
                    System.Console.Clear();
                    Console.WriteLine();
                    OperaciónSuma();
                    Console.WriteLine();
                    PreguntarPorOtraOperacionDespuesDeCalcularSuma();
                }

                else if (DecisionUsuario == "2")
                {
                    System.Console.Clear();
                    Console.WriteLine("\n\u001b[1;33m\u001b[1m¿Qué operación desea realizar? (Utilice las flechas hacia arriba y hacia abajo de su teclado para cambiar de opción):");
                    counter = 2;
                    Console.CursorVisible = false;
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                }
                else if (DecisionUsuario == "3")
                {
                    Console.CursorVisible = false;
                    MensajeDespedida();
                    Environment.Exit(0);
                }
                else
                {
                    Loop = true; // Volver a solicitar la entrada
                    Console.WriteLine();
                    Console.WriteLine("\u001b[1;33mmPor favor, ingrese '1' o '2'.\u001b[0m");
                }
            } while (DecisionUsuario != "1" && DecisionUsuario != "2"); // El bucle continúa mientras Loop sea true
        }

        static void SolicitarDecisionUsuarioMultiplicación()
        {
            string DecisionUsuario; // Declarar Decision Usuario fuera del bucle

            do
            {
                DecisionUsuario = Console.ReadLine();


                if (DecisionUsuario == "1")
                {
                    System.Console.Clear();
                    Console.WriteLine();
                    OperaciónMultiplicación();
                    Console.WriteLine();
                    PreguntarPorOtraOperacionDespuesDeCalcularMultiplicación();
                }

                else if (DecisionUsuario == "2")
                {
                    System.Console.Clear();
                    Console.WriteLine("\n\u001b[1;33m\u001b[1m¿Qué operación desea realizar? (Utilice las flechas hacia arriba y hacia abajo de su teclado para cambiar de opción):");
                    counter = 2;
                    Console.CursorVisible = false;
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                }
                else if (DecisionUsuario == "3")
                {
                    Console.CursorVisible = false;
                    MensajeDespedida();
                    Environment.Exit(0);
                }
                else
                {
                    Loop = true; // Volver a solicitar la entrada
                    Console.WriteLine();
                    Console.WriteLine("\u001b[1;33mmPor favor, ingrese '1' o '2'.\u001b[0m");
                }
            } while (DecisionUsuario != "1" && DecisionUsuario != "2"); // El bucle continúa mientras Loop sea true
        }

        static void SolicitarDecisionUsuarioDivisión()
        {
            string DecisionUsuario; // Declarar Decision Usuario fuera del bucle

            do
            {
                DecisionUsuario = Console.ReadLine();


                if (DecisionUsuario == "1")
                {
                    System.Console.Clear();
                    Console.WriteLine();
                    OperaciónDivisión();
                    Console.WriteLine();
                    PreguntarPorOtraOperacionDespuesDeCalcularDivisión();
                }

                else if (DecisionUsuario == "2")
                {
                    System.Console.Clear();
                    Console.WriteLine("\n\u001b[1;33m\u001b[1m¿Qué operación desea realizar? (Utilice las flechas hacia arriba y hacia abajo de su teclado para cambiar de opción):");
                    counter = 2;
                    Console.CursorVisible = false;
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                }
                else if (DecisionUsuario == "3")
                {
                    Console.CursorVisible = false;
                    MensajeDespedida();
                    Environment.Exit(0);
                }
                else
                {
                    Loop = true; // Volver a solicitar la entrada
                    Console.WriteLine();
                    Console.WriteLine("\u001b[1;33mmPor favor, ingrese '1' o '2'.\u001b[0m");
                }
            } while (DecisionUsuario != "1" && DecisionUsuario != "2"); // El bucle continúa mientras Loop sea true
        }

        static void SolicitarDecisionUsuarioPotencia()
        {
            string DecisionUsuario; // Declarar Decision Usuario fuera del bucle

            do
            {
                DecisionUsuario = Console.ReadLine();


                if (DecisionUsuario == "1")
                {
                    System.Console.Clear();
                    Console.WriteLine();
                    OperaciónDivisión();
                    Console.WriteLine();
                    PreguntarPorOtraOperacionDespuesDeCalcularDivisión();

                }

                else if (DecisionUsuario == "2")
                {
                    System.Console.Clear();
                    Console.WriteLine("\n\u001b[1;33m\u001b[1m¿Qué operación desea realizar? (Utilice las flechas hacia arriba y hacia abajo de su teclado para cambiar de opción):");
                    counter = 2;
                    Console.CursorVisible = false;
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                }
                else if (DecisionUsuario == "3")
                {
                    Console.CursorVisible = false;
                    MensajeDespedida();
                    Environment.Exit(0);
                }
                else
                {
                    Loop = true; // Volver a solicitar la entrada
                    Console.WriteLine();
                    Console.WriteLine("\u001b[1;33mmPor favor, ingrese '1' o '2'.\u001b[0m");
                }
            } while (DecisionUsuario != "1" && DecisionUsuario != "2"); // El bucle continúa mientras Loop sea true
        }

        static void SolicitarDecisionUsuarioPorcentaje()
        {
            string DecisionUsuario; // Declarar Decision Usuario fuera del bucle

            do
            {
                DecisionUsuario = Console.ReadLine();


                if (DecisionUsuario == "1")
                {
                    System.Console.Clear();
                    Console.WriteLine();
                    CalcularPorcentaje();
                    Console.WriteLine();
                    PreguntarPorOtraOperacionDespuesDeCalcularPorcentaje();
                }

                else if (DecisionUsuario == "2")
                {
                    System.Console.Clear();
                    Console.WriteLine("\n\u001b[1;33m\u001b[1m¿Qué operación desea realizar? (Utilice las flechas hacia arriba y hacia abajo de su teclado para cambiar de opción):");
                    counter = 2;
                    Console.CursorVisible = false;
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                }
                else if (DecisionUsuario == "3")
                {
                    Console.CursorVisible = false;
                    MensajeDespedida();
                    Environment.Exit(0);
                }
                else
                {
                    Loop = true; // Volver a solicitar la entrada
                    Console.WriteLine();
                    Console.WriteLine("\u001b[1;33mmPor favor, ingrese '1' o '2'.\u001b[0m");
                }
            } while (DecisionUsuario != "1" && DecisionUsuario != "2"); // El bucle continúa mientras Loop sea true
        }

        static void SolicitarDecisionUsuario()
        {
            string DecisionUsuario; // Declarar Decision Usuario fuera del bucle

            do
            {
                DecisionUsuario = Console.ReadLine();

                if (DecisionUsuario == "1")
                {
                    System.Console.Clear();
                    Console.WriteLine("\n\u001b[1;33m\u001b[1m¿Qué operación desea realizar? (Utilice las flechas hacia arriba y hacia abajo de su teclado para cambiar de opción):");
                    counter = 2;
                    Console.CursorVisible = false;
                    Console.WriteLine(); // Agrega un espacio entre las líneas
                }
                else if (DecisionUsuario == "2")
                {
                    Console.CursorVisible = false;
                    MensajeDespedida();
                    Environment.Exit(0);
                }
                else
                {
                    Loop = true; // Volver a solicitar la entrada
                    Console.WriteLine();
                    Console.WriteLine("\u001b[1;33m\u001b[1mPor favor, ingrese '1' o '2'.\u001b[0m");
                }
            } while (DecisionUsuario != "1" && DecisionUsuario != "2"); // El bucle continúa mientras Loop sea true
        }

        static void PasarASiguienteOperaciónSuma()
        {
            Console.WriteLine("\r\n\u001b[1;33m- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\u001b[0m");

            Console.WriteLine(); // Agrega un espacio entre las líneas

            PreguntarPorOtraOperacionDespuesDeCalcularSuma();

            SolicitarDecisionUsuarioSuma();
        }

        static void PasarASiguienteOperaciónResta()
        {
            Console.WriteLine("\r\n\u001b[1;33m- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\u001b[0m");

            Console.WriteLine(); // Agrega un espacio entre las líneas

            PreguntarPorOtraOperacionDespuesDeCalcularResta();

            SolicitarDecisionUsuarioResta();
        }

        static void PasarASiguienteOperaciónMultiplicación()
        {
            Console.WriteLine("\r\n\u001b[1;33m- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\u001b[0m");

            Console.WriteLine(); // Agrega un espacio entre las líneas

            PreguntarPorOtraOperacionDespuesDeCalcularMultiplicación();

            SolicitarDecisionUsuarioMultiplicación();
        }

        static void PasarASiguienteOperaciónDivisión()
        {
            Console.WriteLine("\r\n\u001b[1;33m- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\u001b[0m");

            Console.WriteLine(); // Agrega un espacio entre las líneas

            PreguntarPorOtraOperacionDespuesDeCalcularDivisión();

            SolicitarDecisionUsuarioDivisión();
        }

        static void PasarASiguienteOperaciónPotencia()
        {
            Console.WriteLine("\r\n\u001b[1;33m- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\u001b[0m");

            Console.WriteLine(); // Agrega un espacio entre las líneas

            PreguntarPorOtraOperacionDespuesDeCalcularPotencia();

            SolicitarDecisionUsuarioPotencia();
        }

        static void PasarASiguienteOperaciónRaizCuadrada()
        {
            Console.WriteLine("\r\n\u001b[1;33m- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\u001b[0m");

            Console.WriteLine(); // Agrega un espacio entre las líneas

            PreguntarPorOtraOperacionDespuesDeCalcularRaizCuadrada();

            SolicitarDecisionUsuarioPotencia();
        }

        static void PasarASiguienteOperaciónPorcentaje()
        {
            Console.WriteLine("\r\n\u001b[1;33m- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\u001b[0m");

            Console.WriteLine(); // Agrega un espacio entre las líneas

            PreguntarPorOtraOperacionDespuesDeCalcularPorcentaje();

            SolicitarDecisionUsuarioPorcentaje();
        }

        static void PasarASiguienteOperación()
        {
            Console.WriteLine("\r\n\u001b[1;33m- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\u001b[0m");

            Console.WriteLine(); // Agrega un espacio entre las líneas

            PreguntarPorOtraOperacionDespuesDeCalcularAlgo();

            SolicitarDecisionUsuario();
        }

        static void MensajeDespedida()

        {
            Console.WriteLine(); // Agrega un espacio entre las líneas

            string DibujoCalculadora = "\t┌─────┬─────┬─────┬─────┬─────┬─────┬─────┐\r\n" +
                                           "\t│  %  │ sin │ hyp │  7  │  8  │  9  │  ÷  │\r\n" +
                                           "\t├─────┼─────┼─────┼─────┼─────┼─────┼─────┤\r\n" +
                                           "\t│  π  │ cos │ log │  4  │  5  │  6  │  x  │\r\n" +
                                           "\t├─────┼─────┼─────┼─────┼─────┼─────┼─────┤\r\n" +
                                           "\t│  e  │ tan │  √  │  1  │  2  │  3  │  -  │\r\n" +
                                           "\t├─────┼─────┼─────┼─────┼─────┼─────┼─────┤\r\n" +
                                           "\t│  A  │ EXP │  ^  │  0  │  .  │  =  │  +  │\r\n" +
                                           "\t└─────┴─────┴─────┴─────┴─────┴─────┴─────┘\r\n";

            Console.WriteLine(DibujoCalculadora);

            Console.WriteLine();

            Console.WriteLine("\u001b[1;33m¡Hasta pronto! Gracias por utilizar la CALCULADORA. ¡Que tengas un buen día!\u001b[0m ");

            Console.WriteLine();
        }
    }
}
