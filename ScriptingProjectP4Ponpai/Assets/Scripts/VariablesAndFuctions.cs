using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFuctions : MonoBehaviour
{
    //Create a variable of type int
    int myint = 777;
    // Start is called before the first frame update
    void Start()
    {
        myint = MultiplyByTwo(myint);
        Debug.Log(myint);
    }

    // Update is called once per frame
    void Update()
    {

    }

    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}

