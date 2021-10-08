Algoritmo Taller
	// Variables
	x <-1
	cantidad1 <- 0
	cantidad2 <- 0
	cantidad3 <- 0
	Repetir
		escribir'Elija una opcion'
		escribir'1.Agregar articulo del tipo 1'
		escribir'2.Agregar articulo del tipo 2'
		escribir'3.Agregar articulo del tipo 3'
		escribir'4.Sumatoria'
		escribir'5.Promedio'
		escribir'6.Contar cantidad de tipo de articulo'
		escribir'7.Mayor valor de venta'
		escribir'8.menor valor de venta'
		escribir'9.Calcular Condicion <= a 1.000.000'
		escribir'10.Calcular Condicion >= a 1.000.000 y menor a 5.000.000'
		escribir'11.Calcular sumatoria con descuento'
		escribir'12.Calcular SumatoriaX'
		leer op 
		Segun op Hacer
			1:
				Escribir "Inserte el precio de articulo tipo1"
				leer precio1
				cantidad1 <- cantidad1 + 1
			2:
				Escribir "total precio y cantidad 1"
				Escribir precio1
				Escribir cantidad1
		FinSegun
	Hasta Que op=13
FinAlgoritmo
