using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fortloops : MonoBehaviour
{
    int numEnemies = 3;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating Enemy number: " + i);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
