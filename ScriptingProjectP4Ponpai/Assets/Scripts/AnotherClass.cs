using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    public int apples;
    public int bananas;
    private int stapler;
    private int sellottape;


    public void FruitMachine(int a, int b)
    {
        int answer;
        answer = a + bananas;
        Debug.Log("Fruit total: " + answer);
    }


    private void OfficeSort(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies total: " + answer);
    }
}
