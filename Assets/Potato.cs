using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Potato : MonoBehaviour
{
    public GameObject friedChip;
    public bool isFrying=false;
    
    public GameObject chip;
    public Transform chipGeneratePoint;
    public void ClickPotato()
    {
        if(isFrying)return;
        friedChip.SetActive(true);
        isFrying=true;
    }
    public void ClickMachine()
    {
        if(!isFrying)return;
        friedChip.SetActive(false);
        isFrying=false;
        Instantiate(chip,chipGeneratePoint.position,quaternion.identity);
    }
}
