using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Vector2DThing : MonoBehaviour
{
    public Transform atf;
    public Transform btf;
    public float abDistance;
    
    private void OnDrawGizmos() 
    {
        Vector2 a = atf.position;
        Vector2 b = btf.position;
        Gizmos.DrawLine(a,b);
        Vector2 pt = transform.position;
        float ptLength = pt.magnitude;
        //Distance
        abDistance=Vector2.Distance(a, b);
        Vector2 dirToPt = pt.normalized;
        Gizmos.DrawLine(Vector2.zero, dirToPt);
    }
}
