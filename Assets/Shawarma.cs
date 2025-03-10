using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Shawarma : MonoBehaviour
{
    public GameObject chip;
    public GameObject cucumber;
    public GameObject salad;
    public GameObject meat;
    public int progress=0;
    public GameObject shawarma;

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Chip"))
        {
            if(!chip.activeSelf)
            {
                Destroy(other.gameObject);
                chip.SetActive(true);
                progress++;
            }
        }
        if(other.gameObject.CompareTag("Cucumber"))
        {
            if(!cucumber.activeSelf)
            {
                Destroy(other.gameObject);
                cucumber.SetActive(true);
                progress++;
            }
        }
        if(other.gameObject.CompareTag("Salad"))
        {
            if(!salad.activeSelf)
            {
                Destroy(other.gameObject);
                salad.SetActive(true);
                progress++;
            }
        }
        if(other.gameObject.CompareTag("Meat"))
        {
            if(!meat.activeSelf)
            {
                Destroy(other.gameObject);
                meat.SetActive(true);
                progress++;
            }
        }
        if(other.gameObject.CompareTag("Paper"))
        {
            if(progress>=4)
            {
                Instantiate(shawarma,this.gameObject.transform.position,quaternion.identity);
                Destroy(other.gameObject);
                Destroy(gameObject);
            }
        }
    }
}
