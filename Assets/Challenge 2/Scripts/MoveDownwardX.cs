using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDownwardX : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speed * Time.deltaTime * Vector3.up, Space.World);
    }
}