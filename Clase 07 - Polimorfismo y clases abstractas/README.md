Ejercicios de Programacion

I01. Sobre-sobrescribiendo esas advertencias

	Crear un proyecto de biblioteca de clases contenga la clase Sobrescrito.
	
	1. Sobrescribir el método ToString para que retorne "¡Este es mi método
	   ToString sobrescrito!".
	2. Sobrescribir el método Equals para que retorne true si son del mismo tipo
	   (objetos de la misma clase), false caso contrario.
	3. Sobrescribir el método GetHashCode para que retorne el número 1142510181.
	4. Agregar en el método Main el siguiente código:

	Console.Title = "Sobre-sobrescribiendo esas advertencias";
	Sobrescrito objetoSobrescrito = new Sobrescrito();
	Console.WriteLine(objetoSobrescrito.ToString());
	string objeto = "¡Este es mi método ToString sobrescrito!";
	Console.WriteLine("----------------------------------------------");
	Console.Write("Comparación Sobrecargas con String: ");
	Console.WriteLine(objetoSobrescrito.Equals(objeto));
	Console.WriteLine("----------------------------------------------");
	Console.WriteLine(objetoSobrescrito.GetHashCode());
	Console.ReadKey();

	Luego agrega las siguientes condiciones:

	1. Agregar a la clase Sobrescrito un atributo miAtributo del tipo string, con
	   visibilidad protected.
	2. Generar un constructor de instancia que inicialice miAtributo con el valor
	   "Probar abstractos".
	3. Agregará propiedad abstracta MiPropiedad de sólo lectura. Una vez
	   implementada, retornará el valor de miAtributo.
	4. Crear un método abstracto MiMetodo que retorne un string. Una vez
	   implementada, retornará el valor de MiPropiedad.
	5. Agregar una clase llamada SobreSobrescrito que herede de Sobrescrito.
	   Implementar el código necesario para que todo funcione correctamente.
	6. Modificar el método Main para probar las modificaciones.

I02. Calculadora de formas

	1. Crear una biblioteca de clases que contenga la siguiente jerarquía de herencia:
		a. La clase Figura será base de las demás y no deberá poder instanciarse.
		b. Las clases Rectangulo y Circulo heredarán de Figura.
		c. La clase Cuadrado heredará de Rectangulo.
		d. Las clases Circulo y Cuadrado no se deben poder heredar (ser base).
	2. Agregar el método Dibujar que tendrá una implementación por defecto en la
	   clase base y retornará el texto "Dibujando forma...". Las clases derivadas
	   directas invalidarán dicha implementación y la cambiarán por "Dibujando
	   círculo", "Dibujando rectángulo", según corresponda.
	3. Agregar el método CalcularSuperficie que deberá ser implementado de
	   manera obligatoria por las clases derivadas. Debe retornar un double con el
	   resultado del cálculo de superficie (área) para la figura correspondiente.
	4. Agregar el método CalcularPerimetro que deberá ser implementado de
	   manera obligatoria por las clases derivadas. Debe retornar un double con el
	   resultado del cálculo del perímetro para la figura correspondiente.
	5. Crear un proyecto de consola y en el método Main:
		a. Crear una lista de figuras.
		b. Agregar a la lista una figura de cada tipo.
		c. Recorrer la lista mostrando:
			i. El resultado del método Dibujar.
			ii. El área y el perímetro de cada figura con una precisión de 2 decimales.
			iii. El tipo del objeto (método GetType).

	Clase:

	● abstract Figura

	Metodos:

	● public virtual string Dibujar() { }
	● public abstract double CalcularSuperficie();
	● public abstract double CalcularPerimetro();

	Clase:

	● Rectangulo

	Atributos:

	● private float _longitudAltura
	● private float _longitudBase

	Metodos:
	
	● public Rectangulo(float longitudAltura, float longitudBase) { }
	● public override string Dibujar() { }
	● public override double CalcularPerimetro() { }
	● public override double CalcularSuperficie() { }

	Clase:

	● Circulo

	Atributos:

	● private float _radio

	Metodos:

	● public Circulo(float radio) { }
	● public override string Dibujar() { }
	● public override double CalcularPerimetro() { }
	● public override double CalcularSuperficie() { }

	Clase:
	
	● Cuadrado

	Metodos:

	● public Cuadrado(float longitudLado) : base(longitudLado, longitudLado) { }
	● public override string Dibujar() { }