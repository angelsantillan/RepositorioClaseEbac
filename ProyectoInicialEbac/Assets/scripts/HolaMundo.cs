using UnityEngine;

public class HolaMundo : MonoBehaviour
{

    private void OnEnable()
    {
        Debug.LogWarning("Algo esta raro");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {        
        Debug.LogError("No inicializo como debe de ser");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hola Mundo");
    }
    private void LateUpdate()
    {
        Debug.LogWarning("Casi termino el update");
    }
    private void OnApplicationQuit()
    {
        Debug.LogError("Ya se murio");
    }
}
