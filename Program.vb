Imports System
Imports System.Net.Http.Headers
Imports Tirando_código.Program

Module Program

    Public Class Hilatura

        'Declarar las variables

        Public Posturas As Integer
        Public Eficiencia As Integer
        Public KgHora As Integer
        Public KgTurno As Integer
        Public KgDia As Integer
        Public KgSemana As Integer
        Public Produccion As Double


        'Solicitar datos al ususario 
        Public Sub IngresarDatos()

            Console.WriteLine("¿Cuántas posturas se van a ingresar al Unifloc?")
            Posturas = Console.ReadLine()
            Console.WriteLine("¿Cuántos Kg por hora se pueden producir en el Unifloc?")
            KgHora = Console.ReadLine()
            Console.WriteLine("¿Cuál será la eficiencia a la que se va a trabajar (del 0 al 100%)?")
            Eficiencia = Console.ReadLine()


        End Sub

        'Mostrar los datos ingresados por el usuario
        Public Sub MostrarDatos()

            Console.WriteLine("Estas serán las posturas que se van a trabajar: " & Posturas)
            Console.WriteLine("Este será el número de Kg que se producirán por hora: " & KgHora)
            Console.WriteLine("Esta será la eficiencia a la que se va a trabajar: " & Eficiencia)


        End Sub

        'Apartado de funciones 
        Public Function Eficienn()

            Dim Eficiencia As Decimal

            Eficiencia = (Eficiencia / 100)
            Return Eficiencia

        End Function

        'Funcion de kg por turno
        Public Function KgTurn()

            Dim KgTurno As Integer

            KgTurno = KgHora * 8
            Return KgTurno

        End Function

        'Funcion de kg por dia
        Public Function KgDay()

            Dim KgDia As Integer

            KgDia = KgTurno * 3
            Return KgDia

        End Function

        'Funcion de kg por semana
        Public Function KgSem()

            Dim KgSemana As Integer

            KgSemana = KgDia * 6
            Return KgSemana

        End Function

        'Funcion de calculo de la poduccion por mes
        Public Function Production()

            Dim Produccion As Double

            Produccion = KgSemana * 4 * Eficiencia / 1000

            Return Produccion

        End Function

    End Class

    'Clase matriz
    Public Class Matriz

        Private mat(5, 2) As Integer

        Public Sub Cargar()

            Dim f, c As Integer

            Console.WriteLine("Hola, en este programa vamos a solicitar datos para una matriz y calculo de produccion")
            Console.WriteLine()
            Console.WriteLine("Los datos de la matriz serán los kg trabajados por turnos (3 al día) y los días trabajados (6 a la semana)")
            Console.WriteLine()
            Console.WriteLine("A continuación se le solicitarán datos para la matriz")
            Console.WriteLine()

            For f = 0 To 5
                For c = 0 To 2
                    Console.Write("Ingrese componente: ")
                    mat(f, c) = Console.ReadLine()
                Next
            Next
        End Sub

        Public Sub Imprimir()
            Dim f, c As Integer
            For f = 0 To 5
                For c = 0 To 2
                    Console.Write(mat(f, c) & " ")
                Next
                Console.WriteLine()
            Next
            Console.ReadKey()
        End Sub

    End Class





    'Librerias utilizadas o cosas finales
    Sub Main(args As String())

        'Delcaración de datos
        Dim Eficien As Integer
        Dim Kturn As Integer
        Dim Kday As Integer
        Dim Ksem As Integer
        Dim Produ As Double

        'Librerias de la matriz
        Dim ma As New Matriz()
        ma.Cargar()
        ma.Imprimir()

        Dim hilatura1 As New Hilatura()
        hilatura1.IngresarDatos()

        'Creando instancias
        Dim Eficienn As New Hilatura()
        Dim KgTurn As New Hilatura()
        Dim KgDay As New Hilatura()
        Dim KgSem As New Hilatura()
        Dim Production As New Hilatura()


        'Asignando el valor de las funciones o eso
        Eficien = hilatura1.Eficienn()
        Kturn = hilatura1.KgTurn()
        Kday = hilatura1.KgDay()
        Ksem = hilatura1.KgSem()
        Produ = hilatura1.Production()


        'Mostrando la información obtenida
        Console.WriteLine("Se obtuvo lo siguiente con los datos ingresados: ")

        Console.WriteLine()
        Console.WriteLine("Eficiencia de trabajo: ")
        Console.Write(Eficien)

        Console.WriteLine()
        Console.WriteLine("Los kg por turno son: ")
        Console.Write(Kturn)


        Console.WriteLine()
        Console.WriteLine("Los kg por día son: ")
        Console.Write(Kday)

        Console.WriteLine()
        Console.WriteLine("Los kg por semana son: ")
        Console.Write(Ksem)

        Console.WriteLine()
        Console.WriteLine("La produccion mensual en toneladas es: ")
        Console.Write(Produ)


    End Sub
End Module
