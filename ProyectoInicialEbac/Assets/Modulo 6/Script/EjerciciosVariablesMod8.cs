using System;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    private int valor1i, valor2i, valor3i, valor4i;
    private float valor1f, valor2f, valor3f;
    public string colorToChange, stringFlotante, stringNumero1, stringNumero2;
    private string nombreCompleto, guarda, stringPares;
    private List<string> nombreCompletosLista;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        valor1i = 1;
        valor2i = 2;
        valor3i = 0;
        valor4i = 0;
        valor1f = 1.1f;
        valor2f = 2.5f;
        valor3f = 3.5f;
        nombreCompletosLista = new List<string>();
        nombreCompleto = "Angel Santillan Nuñez";
        stringNumero1 = "1001";
        stringNumero2 = "2025";
        guarda = "";
        stringPares = "";
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void FixedUpdate()
    {
        valor1i++;
        valor1f *= 1.1f;
        Debug.Log("valor1i:" + valor1i);
        Debug.Log("valor1f:" + valor1f);
        valor2i = (int)(valor2f * valor3f);
        Debug.Log("valor2i: " + valor2i);

        var meshRenderer = this.GetComponent<MeshRenderer>().material;
        if (valor1i % 2 == 0) meshRenderer.color = Color.red;
        else meshRenderer.color = Color.blue;

        switch (colorToChange)
        {
            case "red":
                meshRenderer.color = Color.red;
                break;
            case "blue":
                meshRenderer.color = Color.blue;
                break;
            case "green":
                meshRenderer.color = Color.green;
                break;
            default:
                meshRenderer.color = Color.yellow;
                break;
        }
        stringFlotante = valor1f.ToString("n4");
        Debug.Log("string to float: " + stringFlotante);
        nombreCompletosLista = nombreCompleto.Split(' ').ToList();
        Debug.Log("nombre:" + nombreCompletosLista[0]);
        int.TryParse(stringNumero1, out valor3i);
        int.TryParse(stringNumero2, out valor4i);
        Debug.Log(string.Format("number 1: {0} , numer 2: {1} , add: {2}", valor3i, valor4i, valor3i + valor4i));
        stringPares = "";
        for (int x = 0; x < nombreCompleto.Length; x++)
        {
            if (x % 2 == 0) stringPares += nombreCompleto[x];
        }
        Debug.Log(stringPares);
        guarda = nombreCompleto.Remove(0, 5);
        Debug.Log(guarda);
    }
}
