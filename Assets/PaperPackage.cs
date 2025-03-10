using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PaperPackage : MonoBehaviour
{
    public GameObject paper;
    public Transform paperGeneratePoint;
    public void ClickPaper()
    {
        Instantiate(paper,paperGeneratePoint.position,quaternion.identity);
    }
}
