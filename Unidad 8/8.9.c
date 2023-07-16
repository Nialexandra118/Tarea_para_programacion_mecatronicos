#include <stdio.h>
#include <string.h>

/*Bienes raices.
El programa maneja informacion sobre las propiedades que tiene una empresa
de bienes raices de la ciudad de lima, peru, tanto para venta como para renta. */

typedef struct
{
    /* Declaracion de la estructura ubicacion. */
    char zona[20];
    char calle[20];
    char colo[20]; /* Colonia. */
} ubicacion;

typedef struct
{
    /* Declaracion de la estructura propiedades. */
    char clave[6];
    float scu;      /* Superficie cubierta. */
    float ste;      /* Superficie terreno. */
    char car[50];   /* Características. */
    ubicacion ubi;  /* Observa que este campo es de tipo estructura ubicación. */

    float precio;
    char dispo;     /* Disponibilidad. */
} propiedades;

void Lectura(propiedades *, int);
void F1(propiedades *, int);
void F2(propiedades *, int);

int main(void)
{
    propiedades PROPIE[100];
    /* Se declara una arreglo unidimensional de tipo estructura propiedades. */
    int TAM;
    do
    {
        printf("Ingrese el numero de propiedades: ");
        scanf("%d", &TAM);
    } while (TAM > 100 || TAM < 1);
    /* Se verifica que el tamaño del arreglo sea correcto. */

    Lectura(PROPIE, TAM);
    F1(PROPIE, TAM);
    F2(PROPIE, TAM);
    return 0;
}

void Lectura(propiedades *A, int T)
/* Esta funcion se utiliza para leer una arreglo unidimensional de tipo estructura
propiedades de T elementos. */
{
    int I;
    for (I = 0; I < T; I++)
    {
        printf("\n\tIngrese datos de la propiedad %d", I + 1);
        printf("\nClave: ");
        scanf("%s", A[I].clave);
        printf("Superficie cubierta: ");
        scanf("%f", &A[I].scu);
        printf("Superficie terreno: ");
        scanf("%f", &A[I].ste);
        printf("Caracteristicas: ");
        scanf("%s", A[I].car);
        printf("\tZona: ");
        scanf("%s", A[I].ubi.zona);
        printf("\tCalle: ");
        scanf("%s", A[I].ubi.calle);
        printf("\tColonia: ");
        scanf("%s", A[I].ubi.colo);
        printf("Precio: ");
        scanf("%f", &A[I].precio);
        printf("Disponibilidad (Venta-V Renta-R): ");
        scanf(" %c", &A[I].dispo);
    }
}

void F1(propiedades *A, int T)
/* Esta funcion se utiliza para generar un listado de las propiedades
disponibles para venta en la zona de Miraflores, cuyo valor oscila entre
450,000 y 650,000 nuevos soles. */
{
    int I;
    printf("\n\t\tListado de Propiedades para Venta en Miraflores");
    for (I = 0; I < T; I++)
    {
        if (A[I].dispo == 'V' && strcmp(A[I].ubi.zona, "Miraflores") == 0 && A[I].precio >= 450000 && A[I].precio <= 650000)
        {
            printf("\nClave de la propiedad: %s", A[I].clave);
            printf("\nSuperficie cubierta: %.2f", A[I].scu);
            printf("\nSuperficie terreno: %.2f", A[I].ste);
            printf("\nCaracterísticas: %s", A[I].car);
            printf("\nCalle: %s", A[I].ubi.calle);
            printf("\nColonia: %s", A[I].ubi.colo);
            printf("\nPrecio: %.2f\n", A[I].precio);
        }
    }
}

void F2(propiedades A[], int T)
/* Al recibir como datos una zona geografica de Lima, Peru, y un cierto rango respecto al monto, esta funcion genera un listado de todas las propiedades
disponibles para renta. */
{
    int I;
    float li, ls;
    char zon[20];
    printf("\n\t\tListado de Propiedades para Renta");
    printf("\nIngrese zona geografica: ");
    scanf("%s", zon);
    printf("Ingrese el limite inferior del precio: ");
    scanf("%f", &li);
    printf("Ingrese el limite superior del precio: ");
    scanf("%f", &ls);
    for (I = 0; I < T; I++)
    {
        if (A[I].dispo == 'R' && strcmp(A[I].ubi.zona, zon) == 0 && A[I].precio >= li && A[I].precio <= ls)
        {
            printf("\nClave de la propiedad: %s", A[I].clave);
            printf("\nSuperficie cubierta: %.2f", A[I].scu);
            printf("\nSuperficie terreno: %.2f", A[I].ste);
            printf("\nCaracterísticas: %s", A[I].car);
            printf("\nCalle: %s", A[I].ubi.calle);
            printf("\nColonia: %s", A[I].ubi.colo);
            printf("\nPrecio: %.2f\n", A[I].precio);
        }
    }
}