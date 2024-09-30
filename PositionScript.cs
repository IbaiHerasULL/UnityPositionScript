using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionScript : MonoBehaviour
{
    // Un array de objetos cuyos Transform vamos a registrar
    public GameObject[] objetosARegistrar;

    void Start()
    {
        // Iterar sobre cada objeto y escribir su posición en la consola
        foreach (GameObject obj in objetosARegistrar)
        {
            // Obtener la posición del objeto
            Vector3 posicion = obj.transform.position;
            
            // Escribir en la consola el nombre del objeto y su posición
            Debug.Log("Objeto: " + obj.name + " - Posición: " + posicion);

            //Con esto registraremos en la consola la posición inicial de objeto que use este script
        }
    }

    void Update()
    {
        
    }
}
