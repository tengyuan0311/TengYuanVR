using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BigMeat : MonoBehaviour
{
    public GameObject meatSlice;
    public Transform meatGeneratePoint;
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Knife"))
        {
            Instantiate(meatSlice,meatGeneratePoint.position,quaternion.identity);
        }
        
    }

    
}
