using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class FlatBread : MonoBehaviour
{
    public GameObject flatBread;
    public Transform flatBreadGeneratePoint;
    public void ClickFlatBread()
    {
        Instantiate(flatBread,flatBreadGeneratePoint.position,quaternion.identity);
    }
}
