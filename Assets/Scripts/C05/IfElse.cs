using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string input = "3";
        int num = Int32.Parse(input);

        if (num < 0 )
        {
            Debug.Log("擠熱");
        }
        else if (num > 0)
        {
            Debug.Log("曄熱");
        }
        else
        {
            Debug.Log("0");
        }
        if (num % 2 == 0)
        {
            Debug.Log("礎熱");
        }
        else
        {
            Debug.Log("�汝�");
        }
        
    }
}
