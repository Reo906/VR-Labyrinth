using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFalseTrigger : MonoBehaviour
{
    public GameObject element;

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            element.SetActive(false);
        }
    }
}
