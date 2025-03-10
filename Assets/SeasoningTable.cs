using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SeasoningTable : MonoBehaviour
{
    public GameObject cucumber;
    public Transform cucumberGeneratePoint;

    public GameObject salad;
    public Transform saladGeneratePoint;



    public void ClickCucumber()
    {
        Instantiate(cucumber,cucumberGeneratePoint.position,quaternion.identity);
    }
    public void ClickSalad()
    {
        Instantiate(salad,saladGeneratePoint.position,Quaternion.Euler(new Vector3(-90,0,0)));
    }
    public void ClickMachine()
    {
        
        Instantiate(salad,saladGeneratePoint.position,quaternion.identity);
    }
}
