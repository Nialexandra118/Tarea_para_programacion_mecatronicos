using Microsoft.VisualBasic;
using System;


/*
       Nicole Alexandra Méndez Pérez
        Pagina de informacion de enfermedades: https://www.cdc.gov/antibiotic-use/sp/common-illness.html
 */
namespace MedicalNIICOLE
{

}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enfermedades comunes:");

        Console.WriteLine("1. Resfriado");
        Console.WriteLine("2. Gripe");
        Console.WriteLine("3. Sinusitis");
        Console.WriteLine("4. Dolor de garganta");
        Console.WriteLine("5. Infección de oído");

        Console.WriteLine("Selecione una por favor: ");
        int seleccion = int.Parse(Console.ReadLine());


        switch (seleccion)
        {
            case 1:
                Console.WriteLine("Sintomas de Resfriado");

                resfriado(); //Metodo

                break;

            case 2:
                Console.WriteLine("Sintomas Gripe");

                Gripe();
                break;

            case 3:
                Console.WriteLine("Sintomas Sinusitis");

                Sinusitis();
                break;

            case 4:
                Console.WriteLine("Sintomas Dolor de garganta");

                dolorGarganta();
                break;

            case 5:

                Console.WriteLine("Sintomas de Infección de oído");

                InfeccionOido();

                break;

            default:
                Console.WriteLine("Elija una enfermedad porfavor!");
                break;
        }
        static void resfriado()
        {
            Console.WriteLine("Responda las siguientes preguntas para saber el grado de complejidad.");

            Console.Write("¿Has estado experimentando estornudos frecuentes últimamente? (Si/No):");
            string refriado = Console.ReadLine().ToLower();

            Console.Write("¿Sientes congestión nasal, es decir, dificultad para respirar por la nariz? (si/no): ");
            string dificultadRespiratoria = Console.ReadLine().ToLower();

            Console.Write("¿Notas un aumento en la producción de mucosidad, tiene dolor de pecho (si/no): ");
            string dolorPecho = Console.ReadLine().ToLower();

            Console.Write("¿Has experimentado fiebre durante este período? ¿Si sí, cuál ha sido la temperatura máxima que has tenido? (Digita el numero en grado) ");
            int fiebre = int.Parse(Console.ReadLine());

            Console.Write("Siente que estas teniendo sintomas pero no tan leves?");
            string normal = Console.ReadLine().ToLower();


            if (refriado == "si" || dificultadRespiratoria == "si" || dolorPecho == "si")
            {
                Console.WriteLine("Ve al medico!");
            }
            else if (fiebre <= 45)
            {
                Console.WriteLine("Toma un anargesico");
            }
            else if (normal == "no")
            {
                Console.WriteLine("Tomalo con carma");
            }
            else
            {
                Console.WriteLine("Esta comenzando a tener gripe, no se asuste");
            }
        }
    }
    static void Gripe()
    {
        Console.WriteLine("Responda las siguientes preguntas para saber el grado de complejidad de los síntomas de la gripe.");

        Console.Write("¿Tienes fiebre? (si/no): ");
        string fiebreRespuesta = Console.ReadLine().ToLower();

        Console.Write("¿Tienes tos? (si/no): ");
        string tosRespuesta = Console.ReadLine().ToLower();

        Console.Write("¿Tienes dolores corporales? (si/no): ");
        string doloresCorporalesRespuesta = Console.ReadLine().ToLower();

        Console.Write("¿Tienes dolor de garganta? (si/no): ");
        string dolorGargantaRespuesta = Console.ReadLine().ToLower();

        Console.Write("¿Tienes moqueo o congestión nasal? (si/no): ");
        string moqueoCongestionRespuesta = Console.ReadLine().ToLower();

        Console.Write("¿Tienes dolor de cabeza? (si/no): ");
        string dolorCabezaRespuesta = Console.ReadLine().ToLower();

        Console.Write("¿Sientes escalofríos? (si/no): ");
        string escalofriosRespuesta = Console.ReadLine().ToLower();

        Console.Write("¿Te sientes fatigado/a? (si/no): ");
        string fatigaRespuesta = Console.ReadLine().ToLower();

        Console.Write("¿Has tenido vómitos o diarrea? (si/no): ");
        string vomitosDiarreaRespuesta = Console.ReadLine().ToLower();

        if (fiebreRespuesta == "si" || tosRespuesta == "si" || doloresCorporalesRespuesta == "si" ||
            dolorGargantaRespuesta == "si" || moqueoCongestionRespuesta == "si" ||
            dolorCabezaRespuesta == "si" || escalofriosRespuesta == "si" ||
            fatigaRespuesta == "si" || vomitosDiarreaRespuesta == "si")
        {
            Console.WriteLine("Puede ser recomendable consultar a un médico.");
        }
        else
        {
            Console.WriteLine("No parece haber síntomas graves de gripe, pero mantente alerta.");
        }
    }

    static void Sinusitis()
    {
        Console.WriteLine("Responde las siguientes preguntas para evaluar la posibilidad de tener síntomas de sinusitis.");

        Console.Write("¿Tienes moqueo? (si/no): ");
        string moqueoRespuesta = Console.ReadLine().ToLower();

        Console.Write("¿Sientes congestión nasal? (si/no): ");
        string congestionNasalRespuesta = Console.ReadLine().ToLower();

        Console.Write("¿Tienes dolor o presión en la cara? (si/no): ");
        string dolorCaraRespuesta = Console.ReadLine().ToLower();

        Console.Write("¿Tienes dolor de cabeza? (si/no): ");
        string dolorCabezaRespuesta = Console.ReadLine().ToLower();

        Console.Write("¿Sientes goteo de mucosidad en la garganta? (si/no): ");
        string goteoPosnasalRespuesta = Console.ReadLine().ToLower();

        Console.Write("¿Tienes dolor de garganta? (si/no): ");
        string dolorGargantaRespuesta = Console.ReadLine().ToLower();

        Console.Write("¿Tienes tos? (si/no): ");
        string tosRespuesta = Console.ReadLine().ToLower();

        Console.Write("¿Tienes mal aliento? (si/no): ");
        string malAlientoRespuesta = Console.ReadLine().ToLower();

        if ((moqueoRespuesta == "si" && congestionNasalRespuesta == "si") ||
            (dolorCaraRespuesta == "si" && dolorCabezaRespuesta == "si") ||
            (goteoPosnasalRespuesta == "si" && dolorGargantaRespuesta == "si") ||
            (tosRespuesta == "si" && malAlientoRespuesta == "si"))
        {
            Console.WriteLine("Puede haber síntomas de sinusitis. Se recomienda consultar a un médico.");
        }
        else if (moqueoRespuesta == "si" || congestionNasalRespuesta == "si" ||
                 dolorCaraRespuesta == "si" || dolorCabezaRespuesta == "si" ||
                 goteoPosnasalRespuesta == "si" || dolorGargantaRespuesta == "si" ||
                 tosRespuesta == "si" || malAlientoRespuesta == "si")
        {
            Console.WriteLine("Podría haber síntomas de infección respiratoria. Consulta a un médico si es necesario.");
        }
        else
        {
            Console.WriteLine("No parece haber síntomas graves, pero presta atención a cualquier cambio.");
        }
    }

    static void dolorGarganta()
    {

        Console.WriteLine("Responde las siguientes preguntas para evaluar tus síntomas de dolor de garganta.");

        Console.Write("¿Tienes tos? (si/no): ");
        string toses = Console.ReadLine().ToLower();

        Console.Write("¿Tienes moqueo? (si/no): ");
        string moqueoRespuesta = Console.ReadLine().ToLower();

        Console.Write("¿Tienes ronquera en la voz? (si/no): ");
        string ronquera = Console.ReadLine().ToLower();

        Console.Write("¿Tienes conjuntivitis (pink eye)? (si/no): ");
        string conjuntivitis = Console.ReadLine().ToLower();

        if (toses == "si" && moqueoRespuesta == "si" && ronquera == "si" && conjuntivitis == "si")
        {
            Console.WriteLine("Podría haber un cuadro viral o alérgico. Si los síntomas persisten, es recomendable consultar a un médico.");
        }
        else if (ronquera == "si" && conjuntivitis == "si")
        {
            Console.WriteLine("La combinación de ronquera y conjuntivitis podría indicar una infección viral o bacteriana. Consulta a un médico.");
        }
        else if (toses == "si" && moqueoRespuesta == "si")
        {
            Console.WriteLine("Tos y moqueo podrían indicar un resfriado común. Descansa y mantente hidratado/a.");
        }
        else
        {
            Console.WriteLine("No parece haber síntomas graves. Siempre es recomendable estar alerta y consultar a un médico si persisten los síntomas.");
        }


    }

    static void InfeccionOido()
    {
        Console.WriteLine("Responde las siguientes preguntas para evaluar la posibilidad de tener una infección de oído.");

        Console.Write("¿Tienes dolor de oído? (si/no): ");
        string dolorOido = Console.ReadLine().ToLower();

        Console.Write("¿Tienes fiebre? (si/no): ");
        string fiebre = Console.ReadLine().ToLower();

        Console.Write("¿Te sientes nervioso/a o irritable? (si/no): ");
        string nerviosismo = Console.ReadLine().ToLower();

        Console.Write("¿Has notado que te frotas o jalas una oreja con frecuencia? (si/no): ");
        string frotarOreja = Console.ReadLine().ToLower();

        Console.Write("¿Tienes dificultad para dormir? (si/no): ");
        string dificultadDormir = Console.ReadLine().ToLower();

        if (dolorOido == "si" && fiebre == "si")
        {
            Console.WriteLine("Podría haber una infección de oído que necesita atención médica. Consulta a un médico para una evaluación adecuada.");
        }
        else if (frotarOreja == "si" || nerviosismo == "si" || dificultadDormir == "si")
        {
            Console.WriteLine("Los síntomas que mencionaste podrían indicar la posibilidad de una infección de oído o una molestia. Si persisten, considera consultar a un médico.");
        }
        else
        {
            Console.WriteLine("No parece haber síntomas graves de infección de oído. Mantente atento/a a cualquier cambio y consulta a un médico si persisten los síntomas.");
        }
    }





}
