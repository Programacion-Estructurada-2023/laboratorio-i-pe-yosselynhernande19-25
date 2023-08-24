﻿using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {

             //Declaración de variable de texto desde consola
            string? departamento;
            string? municipio;
            string? ciudad;

            //Declaración de variable de texto desde codigo
            string?  recidencia_donde_vive = " Barrio de Arriba ";
            string? color_vivienda = " Azul";

            //Declaración de variable entera desde consola
            int tiem_vivir;
            int edad_actual;

            //Declaración de variable de tipo dateTime
            DateTime fecha_Actual = DateTime.Now;
            DateTime fecha_nacimiento = new DateTime(2000,9,19);


            //Obtener los datos de la terminal
            Console.WriteLine("Ingrese el departamento donde vive: ");
            departamento = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese el municipio donde vive: ");
            municipio= Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese la ciudad donde vive: ");
            ciudad= Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese cuantos años tiene  de vivir en su residencia actual: ");
            tiem_vivir= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese su edad actual: ");
            edad_actual= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Asignar Funciones
            //Función para comparar cadena
            bool cadena_Comparativa = departamento == municipio;

            //Función de concatenar texto
            string? cadena_Concatenada = departamento + "," + municipio + "," + recidencia_donde_vive;

            //Función Mayuscula
            string? Función_Mayuscula = ciudad.ToUpper();
            
            //Función de limpiado de cadena
            string? Función_Limpiado = recidencia_donde_vive.Trim();

            //Función de longitud de cadena
            int longitudCadena1 = recidencia_donde_vive.Length;
            int longitudCadena2 = color_vivienda.Length;

            //Función de fecha formateada
            string? fecha_Formateada = fecha_Actual.ToString("dd/MM/yyyy");

            //Función adicionar 2 semanas
            DateTime fecha_2semanas = fecha_nacimiento.AddDays(14);

            //Función Comparar fechas
            bool fechas_iguales = fecha_Actual == fecha_nacimiento;
            bool fechaActua1 = fecha_Actual < fecha_nacimiento;
            bool fecha_nacimiento1 = fecha_Actual  > fecha_nacimiento;

            //Impresión de valores de valores ingresados de las variables de texto
            Console.WriteLine("********************************************************");
            Console.WriteLine("Información Capturada y Asignada");
            Console.WriteLine("------Capturada------");
            Console.WriteLine("Departamento: " + departamento);
            Console.WriteLine("Municipio: " + municipio);
            Console.WriteLine("Ciudad: " + ciudad);
            Console.WriteLine("Años de vivir en recidencia actual: " + tiem_vivir);
            Console.WriteLine("Edad actual: " + edad_actual);
            Console.WriteLine("");
            Console.WriteLine("------Asignada------");
            Console.WriteLine("Lugar donde vive: " + recidencia_donde_vive);
            Console.WriteLine("Color de casa: " + color_vivienda);
            Console.WriteLine("Fecha de nacimiento: " + fecha_nacimiento);
            Console.WriteLine("Fecha actual: " + fecha_Actual);
            Console.WriteLine("");

            //Impresión de valores de las variables de texto
            Console.WriteLine("********************************************************");
            Console.WriteLine("Impreción de valores de las variales de texto: ");
            Console.WriteLine("Departamento: " + departamento);
            Console.WriteLine("Municipio: " + municipio);
            Console.WriteLine("Ciudad: " + ciudad);
            Console.WriteLine("Colonia: " + recidencia_donde_vive);
            Console.WriteLine("Color de casa: " + color_vivienda);
            Console.WriteLine("");

            //Impresión de valores de las variables enteras
            Console.WriteLine("********************************************************");
            Console.WriteLine("Impreción de valores de las variales enteras: ");
            Console.WriteLine("Años de vivir en recidencia actual: " + tiem_vivir);
            Console.WriteLine("Edad actual: " + edad_actual);
            Console.WriteLine("");

            //Impresión de valores ingresados en la comparación de cadena
            Console.WriteLine("********************************************************");
            Console.WriteLine("Comparación de cadena entre Departamento y municipio: " + cadena_Comparativa);
            Console.WriteLine("");

            //Impresión de funciones mayúscula
            Console.WriteLine("********************************************************");
            Console.WriteLine("------Funciones------");
            Console.WriteLine("Función Mayúscula: " + Función_Mayuscula);
            Console.WriteLine("Concatenar Cadena : "+ cadena_Concatenada);
            Console.WriteLine("Longitud de cadena: " +" (" + recidencia_donde_vive + ") "+ longitudCadena1);
            Console.WriteLine("Longitud de cadena: " + "("+ color_vivienda+ ")" + longitudCadena2);


            //Impresión de valores en la funcionse de fecha
            Console.WriteLine("********************************************************");
            Console.WriteLine("Fecha formateada: " + fecha_Formateada);
            Console.WriteLine("Fechas iguales: " + fechas_iguales);
            Console.WriteLine("Fecha actual mayor a fecha de nacimiento: " + fecha_nacimiento1);
            Console.WriteLine("Fecha actual menor a fecaha de nacimiento: " + fechaActua1);
            Console.WriteLine("Fecha de nacimiento con 2 semanas sumadas: " + fecha_2semanas);
            Console.WriteLine("");
            Console.WriteLine("********************************************************");

            //AUTOEVALUACION 10

        }
    }
}
