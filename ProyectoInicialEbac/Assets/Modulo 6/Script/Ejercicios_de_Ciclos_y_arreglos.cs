using Mono.Cecil;
using UnityEngine;

public class Ejercicios_de_Ciclos_y_arreglos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] arr1 = new int[4];
        int[] arr2 = new int[4];
        int[] arr3 = new int[4];
        string[] arr4 = new string[] { "Hola", "Mundo", "como", "estan" };
        string cadenaCompleta = "";

        for (int x = 0; x < arr1.Length; x++)
        {
            arr1[x] = Random.Range(0, x + 1);
            arr2[x] = Random.Range(0, x + 2);
        }
        for (int x = 0; x < arr1.Length; x++)
        {
            arr3[x] = arr1[x] + arr2[x];
            Debug.Log("arr 3 pos x =" + arr1[x] + "+" + arr2[x] + "=" + arr3[x]);
        }
        foreach (string palabra in arr4)
        {
            cadenaCompleta += palabra + " ";
        }
        Debug.Log("cadena completa:" + cadenaCompleta);

        int[,] arr5 = new int[2, 3];
        arr5[0, 0] = 1;
        arr5[0, 1] = 2;
        arr5[0, 2] = 3;
        arr5[1, 0] = 4;
        arr5[1, 1] = 5;
        arr5[1, 2] = 6;
        int[] arr6 = new int[3];
        arr6[0] = 7;
        arr6[1] = 8;
        arr6[2] = 9;
        int[,] arr7 = new int[2, 1];
        for (int x = 0; x < 2; x++)
        {
            int suma = 0;
            for (int y = 0; y < 3; y++)
            {
                suma = suma + (arr5[x,y] * arr6[y]);
            }
            arr7[x, 0] = suma;
        }

        for(int i=0; i<2;i++)
        {
            Debug.Log("Array " + i + ",0=" + arr7[i,0]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
