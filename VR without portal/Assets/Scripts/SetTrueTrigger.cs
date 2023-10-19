using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTrueTrigger : MonoBehaviour
{
    public GameObject element;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            element.SetActive(true);
        }
    }
}
