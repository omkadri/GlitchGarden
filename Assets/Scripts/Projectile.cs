using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float movementSpeed = 1;
    void Update()
    {
        transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
    }
}
