using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Drawing;

public class DOT : MonoBehaviour
{
    public Vector3[] waypointsVec;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Transform>().DOPath(waypointsVec, 20f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
