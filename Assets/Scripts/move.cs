//Keywords, these are "namespaces" that allow us to use built in methods
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This is a class, C# is a object oriented coding language
//It is a blueprint for an object
//The word "public" means it accessible by other things in the project
//"monobehavior" is a built in class in unity, which means its giing us built in methods
public class move : MonoBehaviour
{
    public int testInteger = 5;
    public int testInteger2 = 10;
    public string testString = "Hello World!";
    public float testFloat = 3.14f;
    public bool testBoolean = true;
    // Start is called before the first frame update
    void Start()
    {
        //output "Hello World!" to console
        Debug.Log(testString);

        if(testBoolean){
            Debug.Log("The boolean is true.");
        }else {
            Debug.Log("The boolean is false.");
        }

        Debug.Log(addIntegers(testInteger, testInteger2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //custom method to add two integers together
    int addIntegers(int a, int b){
        int sum = a + b;
        return sum;
    }
}
