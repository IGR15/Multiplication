using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    int Multiply(int a, int b)
    {
        return a * b;
    }
    void Start()
    {
        int number =5;
        for (int i = 1; i <= 10; i++)
        {
            int mResult = Multiply(number, i);  
            Debug.Log(number + " x " + i + " = " + mResult);  
            Debug.Log($"{number} x {i} = {mResult}");//using string interpolation :)
        }
    }
}
