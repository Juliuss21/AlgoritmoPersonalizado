			int alturacilindro;
			int alturapiracuadrada;
			int alturapiratri;
			int areacilindro;
			int areacubo;
			int areaesfera;
			int areapiratri;
			int areatri;
			int basee;
			int ladobase;
			int ladocuadrado;
			int ladocubo;
			int radio;
			int radiocilindro;
			int respuesta;
			do {
				Console.WriteLine("Hola");
				Console.WriteLine("A que figura quieres sacar el volumen?");
				Console.WriteLine("1: Esfera");
				Console.WriteLine("2: Cubo");
				Console.WriteLine("3: Piramide (base triangular)");
				Console.WriteLine("4: Piramide (base cuadrada)");
				Console.WriteLine("5: Cilindro");
				Console.WriteLine("6: Salir");
				String figura = Console.ReadLine ();
				switch (figura) {
				case 1:
					Console.WriteLine("Ingrese el radio de la esfera");
					int radio = Convert.ToInt32( Console.ReadLine ());
					areaesfera = (4/3*3.14)*(radio^3);
					Console.WriteLine("El volumen de la esfera es: "+areaesfera);
					break;
				case 2:
					Console.WriteLine("Ingrese la medida del lado del cubo");
					int ladocubo = Convert.ToInt32( Console.ReadLine ());
					areacubo = ladocubo^3;
					Console.WriteLine("El volumen del cubo es: "+areacubo);
					break;
				case 3:
					Console.WriteLine("Ingrese lado de la base");
					int ladotriangulo = Convert.ToInt32( Console.ReadLine ());
					Console.WriteLine("Ingrese altura de la piramide");
					int alturapiratri = Convert.ToInt32( Console.ReadLine ());
					areapiratri = ((ladocuadrado^2)*alturapiratri)/3;
					Console.WriteLine("El volumen de la piramide es; "+areapiracuadrado);
					break;
				case 4:
					Console.WriteLine("Ingrese lado de la base de la piramide");
					int ladobase = Convert.ToInt32( Console.ReadLine ());
					Console.WriteLine("Ingrese la altura de la piramide");
					int alturapiracuadrada = Convert.ToInt32( Console.ReadLine ());
					areatri = ((1/3*(1/2*(ladobase*((basee,2)-(1/2*(ladobase,2))))*alturapiratri)),2);
					Console.WriteLine("El area de la piramide es: "+areatri);
					break;
				case 5:
					Console.WriteLine("Ingrese radio de la base");
					int radiocilindro = Convert.ToInt32( Console.ReadLine ());
					Console.WriteLine("Ingrese altura del cilindro");
					int alturacilindro = Convert.ToInt32( Console.ReadLine ());
					areacilindro = (((radiocilindro,2))*3.14)*alturacilindro;
					Console.WriteLine("El area del cilindro es: "+areacilindro);
					break;
				case 6:
					Console.WriteLine("Usted ha salido");
					break;
				}
				Console.ReadKey();
				Console.Clear();
			} while (respuesta!=6);