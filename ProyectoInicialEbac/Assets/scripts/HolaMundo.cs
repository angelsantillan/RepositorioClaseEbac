using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Algo pasa");
        
        Debug.LogWarning("Algo esta raro");
        Debug.LogError("Algo trono");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hola Mundo");
    }
}
