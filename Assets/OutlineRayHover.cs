using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineRayHover : MonoBehaviour
{
    private Outline outline;
    private void Start() {
        outline=gameObject.GetComponent<Outline>();
    }
    public void HoverOn()
    {
        outline.OutlineWidth=10;
    }
    public void HoverOff()
    {
        outline.OutlineWidth=0;
    }
}
