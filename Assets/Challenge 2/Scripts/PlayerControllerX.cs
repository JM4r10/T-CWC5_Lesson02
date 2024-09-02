using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [SerializeField] GameObject _dogPrefab;
    private GameObject _dogOB;


    private void Start()
    {
        _dogOB = Instantiate(_dogPrefab, transform.position, _dogPrefab.transform.rotation);
        _dogOB.SetActive(false);
    }

    void Update()
    {
        SpawnDog();
    }

    public void SpawnDog()
    {
        if (Input.GetButtonDown("Fire1") && !_dogOB.activeInHierarchy) _dogOB.SetActive(true);        
    }
}
