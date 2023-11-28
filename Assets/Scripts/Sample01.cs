using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        int j = 1;

        bool b1 = true;
        bool b2 = false;

        if (i < j)
        {
            Debug.Log("j가 i보다 큼 !");
        }

        if (i > j) 
        {
            Debug.Log("i가 j보다 큼 !");
        }
        {
            string result = (10 % 2) == 0?  "짝수" : "홀수";
            Debug.Log(result);
        }
    }

    
}
