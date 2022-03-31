using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio8 : MonoBehaviour
{ public int dia;
    // Start is called before the first frame update
    void Start()
    {
        switch (dia)
        {
            case 1:
                Debug.Log("domingo");
                break;
            case 2:
                Debug.Log("lunes");
                break;
            case 3:
                Debug.Log("martes");
                break;
            case 4:
                Debug.Log("miercoles");
                break;
            case 5:
                Debug.Log("jueves");
                break;
            case 6:
                Debug.Log("viernes");
                break;
            case 7:
                Debug.Log("sabado");
                break;

            default:
                Debug.Log("El dia ingresado no es valido");
                break;
              
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
