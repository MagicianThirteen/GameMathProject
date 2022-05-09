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
        //Gizmos.DrawLine(a,b);
        //a到b的方向
        Vector2 atob = b - a;
        Vector2 atobDir = atob.normalized;
        Gizmos.DrawLine(a,a+atobDir);
        //Gizmos.DrawLine(Vector2.zero+a,atobDir+a);
        //Gizmos.DrawLine(a,atob);

        /*Vector2 pt = transform.position;
        float ptLength = pt.magnitude;*/
        //Distance
        /*abDistance=Vector2.Distance(a, b);
        Vector2 dirToPt = pt.normalized;
        Gizmos.DrawLine(Vector2.zero, dirToPt);*/
    }
}
