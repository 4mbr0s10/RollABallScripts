using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruyeEnemigo : MonoBehaviour
{
    public GameObject enemy;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Proyectil"))
        {
            DestroyObject(enemy);
        }
    }
}
