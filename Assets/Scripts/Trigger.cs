using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private Cube _building;

    private void Awake()
    {
        _building = transform.parent.GetComponent<Cube>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _building.ShowInformation();
    }

    private void OnTriggerExit(Collider other)
    {
        _building.Hide();
    }
}
