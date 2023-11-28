using System;
using UnityEngine;

class HelloWorld : MonoBehaviour  // 아래 괄호 안애 변수


{
    string name = "Choi"; // 없어지지 않는 , 유지가 되는 변수  -> 변수에 경우 ;으로 end 
    void Start() 
{
    int age;
    age = 25;
    
    Run();

    Debug.Log("START");
}
    void Run()  
    {
        Debug.Log("Run");
        
    }

}