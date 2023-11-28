using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullConditionalOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ArrayList a = null; 
        a?.Add("야구");       // a?. 가 null을 반환하여 Add메소드가 호출되지않음 
        a.Add("축구");
        Debug.Log($"Count : {a?.Count}");   // a?가  null을 반환하므로 Count 이외에는 아무것도 출력하지 않음
        Debug.Log($"{a?[0]}");
        Debug.Log($"{a?[1]}");

        a = new ArrayList(); // 더이상 a는 null 이 아니다 . 

        a?.Add("야구");
        a?.Add("축구");
        Debug.Log($"Count : {a?.Count}");
        Debug.Log($"{a?[0]}");
        Debug.Log($"{a?[1]}");


        new Person();


        Person person = new Person();

        person.Walk();
    }

}

public class Person
{
    // 변수 
    int age;
    // + 
    // 함수 
    void Walk()
    {
        
    }

}
