using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio6 : MonoBehaviour
{
    public int num1;
    // Start is called before the first frame update
    void Start()
    {
        int num2 = 2;
        int num3;
        num3 = num1 % num2;
     if (num3 > 0)
        {
            Debug.Log("el numero es impar");
        }
        else
        {
            Debug.Log("El numero es par");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
