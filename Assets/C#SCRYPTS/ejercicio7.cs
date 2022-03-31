using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio7 : MonoBehaviour
{
    public int num1;
    public int num2;
    public int num3;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 > num2 && num1 > num3) {
            Debug.Log("num1 es el numero mas grande");
        }
        if (num2 > num1 && num2 > num3)
        {
            Debug.Log("num2 es el numero mas grande");
        }
        if (num3 > num2 && num3 > num1)
        {
            Debug.Log("num3 es el numero mas grande");
        }
        else if (num1 == num2 && num1 == num3)
        {

            Debug.Log("todos los numeros son iguales");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}