using System;

public class Main
{
    public static void Main(string[] args)
    {
        int[] array = new int[] {-2, 1, -3, 4, -1, 2, 1, -5, 4};
        Console.Write(""+subSumMayor(array,9));
    }
    
    public static int subSumMayor(int[] arreglo, int tam){
    int aux = arreglo[0];
    int cont;
    for (int i = 0; i < tam; i++){
        cont = 0;
        for (int j = i; j < tam; j++){
            cont = cont + arreglo[j];
            if (cont > aux){
                aux = cont;
            }
        }
    }
    return aux;
    }
}