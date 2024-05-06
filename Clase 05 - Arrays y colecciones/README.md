Ejercicios de Programacion

I01. Números locos

	Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos)
	distintos de cero de forma aleatoria utilizando la clase Random.
	
	1. Mostrar el vector tal como fue ingresado.
	2. Luego mostrar los positivos ordenados en forma decreciente.
	3. Por último, mostrar los negativos ordenados en forma creciente.

I02. Números locos II
	
	Crear una aplicación de consola que cargue en una Lista, Pila y Cola 20 números enteros
	(positivos y negativos) distintos de cero de forma aleatoria utilizando la clase Random.
	
	1. Mostrar la colección tal como fue cargada.
	2. Luego mostrar los positivos ordenados en forma decreciente.
	3. Por último, mostrar los negativos ordenados en forma creciente.

I03. Estadística deportiva

	Crear un proyecto de biblioteca de clases que contenga las clases Jugador y Equipo:

	Clase:

	● Equipo

	Atributos:

	● private short _cantidadDeJugadores
	● private List<Jugador> _jugadores
	● private string _nombre

	Propiedades:

	● public string Nombre { get; }

	Metodos:

	● private Equipo() { }
	● public Equipo(short cantidad, string nombre) { }
	● public static bool operator +(Equipo e, Jugador j) { }

	Clase:

	● Jugador

	Atributos:

	● private int _dni
	● private string _nombre
	● private int _partidosJugados
	● private float _promedioGoles
	● private int _totalGoles

	Metodos:

	● private Jugador() { }
	● public Jugador(int dni, string nombre) : this() { }
	● public Jugador(int dni, string nombre, int partidosJugados, int totalGoles) : this(dni, nombre) { }
	● public float GetPromedioGoles() { }
	● public string MostrarDatos() { }
	● public static bool operator ==(Jugador x, Jugador y) { }
	● public static bool operator !=(Jugador x, Jugador y) { }

	Clase Jugador:

	● Todos los datos estadísticos del jugador se inicializan en 0 dentro del constructor
	  privado.
	● El promedio de gol sólo se calculará cuando invoquen al método
	  GetPromedioGoles.
	● MostrarDatos retornará una cadena de string con todos los datos y
	  estadísticas del jugador.
	● Dos jugadores serán iguales si tienen el mismo DNI.

	Clase Equipo:

	● La lista de jugadores se inicializará sólo en el constructor privado de Equipo.
	● La sobrecarga del operador + agregará jugadores a la lista siempre y cuando no
	  exista aún en el equipo y la cantidad de jugadores no supere el límite
	  establecido por el atributo cantidadDeJugadores.

	Crear un proyecto de consola y generar las invocaciones necesarias en el método Main
	para probar el código.

I04. Enciendan sus motores

	Crear un proyecto de biblioteca de clases que contenga las clases Competencia y
	AutoF1:

	Clase:

	● AutoF1

	Atributos:

	● private short _cantidadCombustible
	● private bool _enCompetencia
	● private string _escuderia
	● private short _numero
	● private short _vueltasRestantes

	Propiedades:

	● public short Combustible { get; set; }
	● public bool EnCompetencia { get; set; }
	● public short Vueltas { get; set; }

	Metodos:

	● public AutoF1(short numero, string escuderia) { }
	● public string MostrarDatos() { }
	● public static bool operator ==(AutoF1 x, AutoF1 y) { }
	● public static bool operator !=(AutoF1 x, AutoF1 y) { }

	Clase:

	● Competencia

	Atributos:

	● private short _cantidadCompetidores
	● private short _cantidadVueltas
	● private List<AutoF1> _competidores
	● private Random _random

	Metodos:

	● private Competencia() { }
	● public Competencia(short cantidadCompetidores, short cantidadVueltas) : this() { }
	● public string MostrarDatos() { }
	● public static bool operator +(Competencia c, AutoF1 a) { }
	● public static bool operator ==(Competencia c, AutoF1 a) { }
	● public static bool operator !=(Competencia c, AutoF1 a) { }

	Clase AutoF1:

	● Al generar un auto se cargará el atributo enCompetencia como falso.
	  Inicializar cantidadCombustible y vueltasRestantes en 0.
	● Dos autos serán iguales si los atributos número y escuderia son iguales.
	● Realizar los métodos getters y setters para cantidadCombustible,
	  enCompetencia y vueltasRestantes.
	
	Clase Competencia:

	● El constructor privado será el único capaz de inicializar la lista de competidores.
	● La sobrecarga del operador + agregará un competidor si es que aún hay espacio
	  (validar con cantidadCompetidores) y el competidor no forma parte de la
	  lista (== entre Competencia y AutoF1).
	● Al ser agregado, el competidor cambiará su estado enCompetencia a
	  verdadero, la cantidad de vueltasRestantes será igual a la
	  cantidadVueltas de Competencia y se le asignará un número aleatorio
	  entre 15 y 100 a cantidadCombustible.

	Crear un proyecto de consola y generar las invocaciones necesarias en el método Main
	para probar el código.
