using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio9 : MonoBehaviour
{ public string persona1;
    public string persona2;
    public string persona3;
    public float capitalpersona3;
    public float capitalpersona1;
    public float capitalpersona2;
    float porcentaje1;
    float porcentaje2;
    float porcentaje3;
    float montototal;

    // Start is called before the first frame update
    void Start()
    {
        montototal = capitalpersona1 + capitalpersona2 + capitalpersona3;
        porcentaje1 = capitalpersona1 / montototal * 100;
        porcentaje2 = capitalpersona2 / montototal * 100;
        porcentaje3 = capitalpersona3 / montototal * 100;
        Debug.Log("Nombre:" + persona1 + "capital aportado: $" + capitalpersona1 + "Porcentaje del capital: %" + porcentaje1 + "Monto total aportado: $" + montototal);
        Debug.Log("Nombre:" + persona2 + "capital aportado: $" + capitalpersona2 + "Porcentaje del capital: %" + porcentaje2 + "Monto total aportado: $" + montototal);
        Debug.Log("Nombre:" + persona3 + "capital aportado: $" + capitalpersona3 + "Porcentaje del capital: %" + porcentaje3 + "Monto total aportado: $" + montototal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
