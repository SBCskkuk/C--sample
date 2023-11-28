using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


namespace C0301
{

public class IntegarlTypes : MonoBehaviour
    {
    // Start is called before the first frame update
    void Start()
        {
        sbyte a = -10;
        byte b = 40;

        Debug.Log($"a={a}, b={b}");

        short c = -30000;
        ushort d = 60000;

        Debug.Log($"c={c}, d={d}");
    
        int e = -1000_0000;
        uint f = 3_0000_0000;

        Debug.Log($"e={e}, f={f}");

        long g = -50000_0000_0000;
        ulong h = 200_0000_0000_0000_0000;

        Debug.Log($"g={g}, h={h}");
    
      //--- 
        byte a_1 = 255;
        sbyte b_2 = (sbyte)a;

        Debug.Log(a_1);
        Debug.Log(b_2);
    
            {
        uint a_2 = uint.MaxValue;

        Debug.Log(a_2);
        a_2 = a_2 + 1;
        Debug.Log(a_2);

            }
        
            {
                float a_4 = 3.1415_9265_3589_7932_3846f;
                Debug.Log(a_4);

                double b_4 = 3.1415_9265_3589_7932_3846f;
                Debug.Log(b_4);
            }
        }

    }


}


