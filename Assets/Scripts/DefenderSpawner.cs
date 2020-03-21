using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject DefenderType;

    private void OnMouseDown()
    {
        Debug.Log("Mouse was clicked");
        SpawnDefender();
    }

    private void SpawnDefender()
    {
        GameObject newDefender = Instantiate(DefenderType, transform.position, Quaternion.identity) as GameObject; //"as gameObject" allows us to see the instance in the unity inspector, as well as interact with it
    }

}

