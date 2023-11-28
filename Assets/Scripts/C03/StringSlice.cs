using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringSlice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string greeting = "Good moring.";

        Debug.Log(greeting.Substring(0, 5));
        Debug.Log(greeting.Substring(5));
    // Split() 지정된 문자를 기준으로 현재 문자열을 분리한 다음 분리한 문자열의 배열을 반환.
    // Substring () 현재 문자열의 지정된 위치로부터 지정된 수만큼의 문자로 이루어진 새 문자열을 반환.
        string[] arr = greeting.Split(new string[]  {" "}, System.StringSplitOptions.None); // <-- System ~~ 빈 문자열도 허용한다. 

        foreach (string element in arr)
        Debug.Log($"{element}");
    }

    
    
}
