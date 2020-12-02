using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointScript : MonoBehaviour
{
    public Transform sphere1;
    public Transform sphere2;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        Vector3 dir = sphere2.position - sphere1.position;
        transform.position = sphere1.position + 0.5f * dir;
        Vector3 scale = transform.localScale;
        scale.y = dir.magnitude * 0.2f;
        transform.localScale = scale;
        transform.rotation = Quaternion.FromToRotation(Vector3.up, dir);
    }
}
