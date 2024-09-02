using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableBall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Boundary") || other.gameObject.CompareTag("Dog"))
        {
            gameObject.SetActive(false);
        }
    }
}
