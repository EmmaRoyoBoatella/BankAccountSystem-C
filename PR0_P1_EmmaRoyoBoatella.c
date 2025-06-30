/******************************************************************************

Ejercico del banco
Emma Royo Boatella

*******************************************************************************/
#include <stdio.h>
#include <stdlib.h>

//Prototipos
void PedirDatos(int codigos[], float saldos[], int num_cli);
void Movimientos(int codigos[], float saldos[], int num_cli);
int Menu();
void EscribirDatos(int codigos[], int num);
void BuscarClientes(int codigos[], float saldos[], int num_cli, float cant_lim);
void VerDatos(int codigos[], float saldos[], int num_cli);
void Limpiar();

int main (void)
{
	int codigos[100], num_cli, opc;
	float saldos[100], cant_lim;


	printf("Indique el número de clientes: ");
    scanf("%d", &num_cli);
    
    // Función que pide los datos al usuario
	PedirDatos(codigos, saldos, num_cli);
	

	do{
	    opc = Menu();
	    
	    // Los diferentes casos dentro del menú
	    switch(opc){
		case 1:
			Movimientos(codigos, saldos, num_cli);
			break;
		case 2:
			BuscarClientes(codigos, saldos, num_cli, cant_lim);
			break;
		case 3:
			VerDatos(codigos, saldos, num_cli);
			break;
		case 4:
			printf("\nFin del programa.");
			break;
		default:
			printf("\nOpcion Incorrecta.");
		}
	}while(opc!=4);
	return 0;
}

// Función no usuada
void Limpiar()
{
    // Esta función se encontraba en la plantilla y no la he utilizado, puesto que no aparecia en el enunciado
}

// Función del caso 2
void BuscarClientes(int codigos[], float saldos[], int num_cli, float cant_lim)
{
	int limite;
	
	// Se le pide al usuario que introduzca una cantidad de dinero límite
	printf("\n\nIntroduzca la cantidad límite: ");
	scanf("%f", &cant_lim);
	
	// Se buscan los clientes con una cantidad de dinero límite superior a la introducida
	for(int i = 0; i < num_cli; i++){
	    if(cant_lim < saldos[i]){
	        limite = 1;
	        printf("\nEl cliente %d tiene un saldo superior a %.2f €", codigos[i], cant_lim);

	    }
	
	// En caso de no haber ningún usuario por encima de esa cantidad, se lo comunica al usuario   
	}if(limite != 1){
	    printf("\nNo hay clientes con un saldo superior a %.2f €", cant_lim);
	}

}

// Función del caso 3
void VerDatos(int codigos[], float saldos[], int num_cli)
{
    
    // Imprime un reporte con todos los códigos de los clientes y sus respectivos saldos
    for(int i = 0; i < num_cli; i++){
        printf("\n\n");
        printf("\n----------------------------");
        printf("\nCódigo:   %d", codigos[i]);
        printf("\nSaldo:    %.2f €", saldos[i]);
    }

}

// Función no usuada
void EscribirDatos(int codigos[], int num)
{
    // Esta función se encontraba en la plantilla y no la he utilizado, puesto que no aparecia en el enunciado

}

// Función del caso 1
void Movimientos(int codigos[], float saldos[], int num_cli)
{
	int num, buscar_cod, cod_encontrado;
	float cantidad, saldo_rest, saldo_fin;
	
	printf("\n\nIngrese el código del cliente: ");
	scanf("%d", &buscar_cod);
	
	
	for(int i=0; i < num_cli; i++)
	{
	    // Busca el código del cliente, en caso de encontrarlo pide al usuario que elija una opción
	    if(codigos[i] == buscar_cod){
	        cod_encontrado = 1;
	        printf("\n\nIndique que movimiento desea realizar: ");
	        printf("\n1. Sacar dinero");
	        printf("\n2. Depositar dinero");
	        printf("\n\nIntroduzca una opción (1-2)");
	        scanf("%d", &num);
	        
	        // En la opción 1, el usuario saca dinero
	        if(num == 1){
	            printf("\n\nIntroduzca la cantidad de dinero que desea sacar: ");
	            scanf("%f", &cantidad);
	            
	            // Si saca una cantidad acorde a su saldo, le indica el movimeinto que ha hecho y el saldo restante
	            if(cantidad <= saldos[i]){
	                saldos[i]-=cantidad;
	                printf("\nHa sacado un total de %.2f €, y su saldo final es de %.2f €", cantidad, saldos[i]);
	            
	            // En caso contrario, le dice que la cantidad de dienro introducido no vale
	            }else{
	                printf("\nLa cantidad de dinero introducida es inválida");
	            }
	        
	        // En la opción 2, el usuario mete dinero
	        }else{
	            // El usuario intoduce la cantidad y se le imprime el saldo que tiene en la cuenta
	            printf("\n\nIntroduzca la cantidad de dinero que desea depositar: ");
	            scanf("%f", &cantidad);
	            saldos[i]+=cantidad;
	            printf("\nSu saldo actual es de %.2f €", saldos[i]);
	        }
	    }
	
	// Busca el código del cliente, en caso de no encontrarlo indica al usuario que ese código no se encuentra
	}if(cod_encontrado != 1){
	    printf("\nEl código no se ha encontrado");
	}

}

// Función que pide al usuario el código del cliente y el saldo
void PedirDatos(int codigos[], float saldos[], int num_cli)
{
    for(int i=0; i < num_cli; i++){
        printf("\nIntroduzca el código del cliente: ");
        scanf("%d", &codigos[i]);
        printf("\nIntroduzca el saldo del cliente: ");
        scanf("%f", &saldos[i]);
    }

}

// Función que imprime el menú y escanea la opción introducida por el usuario
int Menu()
{
    int opc;
    
    printf("\n\n1. Ingresar y Sacar dinero.");
    printf("\n2. Buscar clientes.");
    printf("\n3. Ver datos.");
    printf("\n4. Salir.");
    printf("\n\n Introduzca una opción (1-4)");
    scanf("%d", &opc);
    
    return opc;
}



















