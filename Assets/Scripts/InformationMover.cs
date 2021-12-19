using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationMover : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - Camera.main.transform.position, Vector3.up);
    }
}
