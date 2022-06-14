using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funciones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        
        {
            EscribirHolaMundoEnConsola();

        }

        if (Input.GetKeyDown(KeyCode.Alpha2))

        {
            EscribirCadenaEnConsola("ACÁ TENES TU ARGUMENTO");
        }
    }

    public void DestuirObjeto()
    {
        Destroy(gameObject);
    }

    public void EscribirHolaMundoEnConsola()
    {
        Debug.Log("Hola Mundo");
    }


    void EscribirCadenaEnConsola(string cadena)
    {
        Debug.Log(cadena);
    }

}
