using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Calculadora
{
    internal class Calculadora
    {
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

            Console.WriteLine("\u001b[1;33m\u001b[1mUtilice las flechas hacia arriba y hacia abajo de su teclado para cambiar de opción:\u001b[0m ");

        }

        private static string[] OpcionesMenu = new string[]
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
        static void OperaciónSuma(double numSuma1, double numSuma2) => Console.WriteLine($"El resultado de sumar {numSuma1} más {numSuma2} es: \u001b[1;36m{(numSuma1 + numSuma2)}\u001b[0m");

        static void OperaciónResta(double numResta1, double numResta2) => Console.WriteLine("El resultado de la resta de " + numResta1 + " y " + numResta2 + " es: " + "\u001b[1;36m" + (numResta1 - numResta2) + "\u001b[0m");

        static void OperaciónMultiplicación(double numMultiplicación1, double numMultiplicación2)
        {
            double ResultadoMultiplicación = numMultiplicación1 * numMultiplicación2;

            Console.WriteLine($"El resultado de multiplicar {numMultiplicación1} por {numMultiplicación2} es: \u001b[1;36m{ResultadoMultiplicación}\u001b[0m");
        }

        static void OperaciónDivisión(double numDivisión1, double numDivisión2)
        {
            double ResultadoDivisión = numDivisión1 / numDivisión2;

            Console.WriteLine("El resultado de la división (o cociente) de " + numDivisión1 + " entre " + numDivisión2 + " es: " + "\u001b[1;36m" + ResultadoDivisión + "\u001b[0m");
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

        static void CalcularPotencia(double basePotencia, double exponentePotencia)
        {
            double resultadoPotencia = Math.Pow(basePotencia, exponentePotencia);

            Console.WriteLine("El resultado de la potencia es: " + "\u001b[1;36m" + resultadoPotencia + "\u001b[0m");
        }

        static void CalcularRaizCuadrada(double NumRaizCuadrada)
        {
            double ResultadoRaizCuadrada = Math.Sqrt(NumRaizCuadrada);

            Console.WriteLine("El resultado de la raíz cuadrada de " + NumRaizCuadrada + " es: " + "\u001b[1;36m" + ResultadoRaizCuadrada + "\u001b[0m");
        }

        static void CalcularNotaciónCientífica(double basePotenciación, double exponentePotenciación)
        {
            double ResultadoPotenciación = basePotenciación * (double)Math.Pow(10, exponentePotenciación);

            Console.WriteLine(basePotenciación + " multiplicado por 10 elevado a " + exponentePotenciación + " es: " + "\u001b[1;36m" + ResultadoPotenciación + "\u001b[0m");
        }

        static void CalcularPorcentaje(double PorcentajeQueSeDeseaCalcular, double NumDelQueSeDeseaCalcularSuPorcentaje)
        {
            double ResultadoPorcentaje = (NumDelQueSeDeseaCalcularSuPorcentaje * PorcentajeQueSeDeseaCalcular) / 100;

            Console.WriteLine("El " + PorcentajeQueSeDeseaCalcular + "% de " + NumDelQueSeDeseaCalcularSuPorcentaje + " es: " + "\u001b[1;36m" + ResultadoPorcentaje + "\u001b[0m");
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

        static void PreguntarPorOtraOperacionDespuesDeCalcularAlgo()
        {
            Console.WriteLine("\u001b[1;33m¿Desea realizar otra operación con la CALCULADORA?\u001b[0m" + Environment.NewLine);

            Console.WriteLine("-. Pulse 1 para realizar otra operación" + Environment.NewLine);
            Console.WriteLine("-. Pulse 2 si desea SALIR" + Environment.NewLine);

            Console.CursorVisible = true;
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
                    Console.WriteLine("Por favor, ingrese solo '1' o '2'.");
                }
            } while (DecisionUsuario != "1" && DecisionUsuario != "2"); // El bucle continúa mientras Loop sea true
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

            Console.WriteLine(); // Agrega un espacio entre las líneas

            Console.WriteLine("\u001b[1;33m¡Hasta pronto! Gracias por utilizar la CALCULADORA. ¡Que tengas un buen día!\u001b[0m ");

            Console.WriteLine(); // Agrega un espacio entre las líneas
        }

        static void Main(string[] args)
        {
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
                    System.Console.Clear();

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    HistoriaMatematicas();

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    PreguntarPorOtraOperacionDespuesdeHistoriaMatematicas();

                    SolicitarDecisionUsuario();
                }

                if (Resultado.Contains("Realizar una SUMA"))
                {
                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.CursorVisible = true;

                    //Permitir que el usuario pueda realizar una SUMA de 2 números (por consola)

                    Console.WriteLine("Introduce el primer número de la suma: ");

                    //Conversión a número con int.Parse
                    double numSuma1 = double.Parse(Console.ReadLine());

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.WriteLine("Introduce el segundo número de la suma: ");

                    double numSuma2 = double.Parse(Console.ReadLine());

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    OperaciónSuma(numSuma1, numSuma2);

                    PasarASiguienteOperación();
                }

                if (Resultado.Contains("Realizar una RESTA"))
                {
                    //Permitir que el usuario pueda realizar una RESTA de 2 números (por consola)

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.CursorVisible = true;

                    Console.WriteLine("Introduce el minuendo (el número del que restarás): ");

                    //Conversión a número con int.Parse
                    double numResta1 = double.Parse(Console.ReadLine());

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.WriteLine("Introduce el sustraendo (el número que restarás): ");

                    double numResta2 = double.Parse(Console.ReadLine());

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    OperaciónResta(numResta1, numResta2);

                    PasarASiguienteOperación();
                }

                if (Resultado.Contains("Realizar una MULTIPLICACIÓN"))
                {
                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.CursorVisible = true;

                    // Permitir que el usuario pueda realizar una MULTIPLICACIÓN de 2 números(por consola)

                    Console.WriteLine("Introduce el primer factor para la multiplicación: ");

                    //Conversión a número con int.Parse
                    double numMultiplicación1 = double.Parse(Console.ReadLine());

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.WriteLine("Introduce el segundo factor para la multiplicación: ");

                    double numMultiplicación2 = double.Parse(Console.ReadLine());

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    OperaciónMultiplicación(numMultiplicación1, numMultiplicación2);

                    PasarASiguienteOperación();
                }

                if (Resultado.Contains("Realizar una DIVISIÓN"))
                {
                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.CursorVisible = true;

                    // Permitir que el usuario pueda realizar una DIVISIÓN de 2 números(por consola)

                    Console.WriteLine("Introduce el dividendo (el número que será dividido) de la división: ");

                    //Conversión a número con int.Parse
                    double numDivisión1 = double.Parse(Console.ReadLine());

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.WriteLine("Introduce el divisor (el número por el cual se dividirá el dividendo) de la división: ");

                    double numDivisión2 = double.Parse(Console.ReadLine());

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    OperaciónDivisión(numDivisión1, numDivisión2);

                    PasarASiguienteOperación();
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
                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.CursorVisible = true;

                    // Calcular POTENCIAS

                    Console.WriteLine("Introduce la base de la potencia: ");

                    double basePotencia = double.Parse(Console.ReadLine());

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.WriteLine("Introduce el exponente de la potencia: ");

                    double exponentePotencia = double.Parse(Console.ReadLine());

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    CalcularPotencia(basePotencia, exponentePotencia);

                    PasarASiguienteOperación();
                }

                if (Resultado.Contains("Realizar una RAÍZ CUADRADA"))
                {
                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.CursorVisible = true;

                    // Calcular RAÍCES CUADRADAS

                    Console.WriteLine("Introduce el número del que quieres calcular su raíz cuadrada: ");

                    double NumRaizCuadrada = double.Parse(Console.ReadLine());

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    CalcularRaizCuadrada(NumRaizCuadrada);

                    PasarASiguienteOperación();
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
                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.CursorVisible = true;

                    // Calcular PORCENTAJES

                    Console.WriteLine("Introduce el % que quieres calcular: ");

                    double PorcentajeQueSeDeseaCalcular = double.Parse(Console.ReadLine());

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    Console.WriteLine("Introduce el número del que quieres calcular su porcentaje: ");

                    double NumDelQueSeDeseaCalcularSuPorcentaje = double.Parse(Console.ReadLine());

                    Console.WriteLine(); // Agrega un espacio entre las líneas

                    CalcularPorcentaje(PorcentajeQueSeDeseaCalcular, NumDelQueSeDeseaCalcularSuPorcentaje);

                    PasarASiguienteOperación();
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
    }
}