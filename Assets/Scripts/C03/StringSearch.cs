using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringSearch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string greeting = "Good Morning";
        Debug.Log (greeting);
        var result = greeting.IndexOf("Good");
        result = greeting.IndexOf("o");
        
        var result2 = greeting.StartsWith("Good");
        result2 = greeting.StartsWith("Morning");

        result2 = greeting.EndsWith("Good");

        result2 = greeting.EndsWith("Morning");

        result2 = greeting.Contains("Evening");
        result2 = greeting.Contains("Morning");

        var reusult3 = greeting.Replace("Morning", "Evening");

        
        //IndexOf() 지정된 문자 또는 문자열의 위치를 찾기.
        Debug.Log($"IndexOf: 'Good ' : { greeting.IndexOf("Good") }");
        Debug.Log($"IndexOf: 'o' : { greeting.IndexOf("o") }");

        //LastIndexOf() 지정된 문자 또는 문자열의 위치를 뒤에서부터 찾기.
        Debug.Log($"LastIndexOf: 'Good ' : { greeting.LastIndexOf("Good") }");
        Debug.Log($"LastIndexOf: 'g ' : { greeting.LastIndexOf("g") }");

        //StartWith() 지정된 문자열로 시작하는지 
        Debug.Log($"StartWith: 'Good ' : { greeting.StartsWith("Good") }");
        Debug.Log($"StartWith: 'g' : { greeting.StartsWith("Moring") }");

        //EndWith() 지정된 문자열로 끝나는지 
        Debug.Log($"EndWith: 'Good ' : { greeting.EndsWith("Good") }");
        Debug.Log($"EndWith: 'Moring' : { greeting.StartsWith("Moring") }");

        //Contains() 지정된 문자열을 포함하는지 
        Debug.Log($"Contains: 'Evening' : { greeting.Contains("Evening") }");
        Debug.Log($"Contains: 'Moring' : { greeting.Contains("Moring") }");

        //Replace() 지정된 문자열이 다른 지정된 문자열로 모두 바뀐 새 문자열로 반환.
        Debug.Log($"Replaced: 'Moring' with 'Evening'  : { greeting.Replace("Morning", "Evening") }");
        

    }   

        
    
}
