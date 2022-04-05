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
        Debug.Log("Nombre:" + persona1 + "capital aportado: $" + capitalpersona1 + "Porcentaje del capital: %" + porcentaje1 + "Monto total aportado: $" + montototal);

}

    // Update is called once per frame
    void Update()
    {
        
    }
}
