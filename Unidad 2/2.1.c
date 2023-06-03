#include <stdio.h>

/*Promedio curso
El progrma, al recibir como dato promedio de un alumno en un curso universitario, escribe aprobando si su promedio es mayor o igual a 6.

PRO: Variable de tipo real */

void main(void)
{
    float PRO;

    printf("Ingrese el promedio del estudiante: ");
    scanf("%f", &PRO);

    if (PRO >= 6)
    printf("\nAprobada");
}