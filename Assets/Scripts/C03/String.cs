using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class String : MonoBehaviour
{
    enum DialogResult {YES, NO, CANCEL, CONFIRM , OK}


    void Start()
    {
        //Enum
        {
        Debug.Log((int)DialogResult.YES);
        Debug.Log((int)DialogResult.NO);
        Debug.Log((int)DialogResult.CANCEL);
        Debug.Log((int)DialogResult.CONFIRM);
        Debug.Log((int)DialogResult.OK);   
        }
        //Enum2
        {
        DialogResult result = DialogResult.YES; // result 값고 DialogResult 값과 같은지 비교 함. ->

        Debug.Log(result == DialogResult.YES);
        Debug.Log(result == DialogResult.NO);
        Debug.Log(result == DialogResult.CANCEL);
        Debug.Log(result == DialogResult.CONFIRM);
        Debug.Log(result == DialogResult.OK);
        }

        {
        string a = "안녕하세요?";
        string b = "최성빈 입니다.";
        
        

        Debug.Log(a);
        Debug.Log(b);
        }
    
    
        {   
        int a = 123;
        string b= a.ToString();
        Debug.Log(b);

        float c = 3.14f;
        string d = c.ToString();
        Debug.Log(d);

        string e = "123456";
        int f = Convert.ToInt32(e);
        Debug.Log(f);

        string g = "1.2345";
        float h = float.Parse(g);
        Debug.Log(h);
        }
    {
        const int MAX_INT = 2147483647;
        const int MIN_INT = -2147483647;

        Debug.Log(MAX_INT);
        Debug.Log(MIN_INT);
    }    
    }
}
