using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TargetMove : MonoBehaviour
{

    public Transform target;

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 5f * Time.deltaTime);
        target.position = transform.position;
    }
}
