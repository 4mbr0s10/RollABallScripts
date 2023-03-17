using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecibeImpacto : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            player.transform.position = new Vector3(181.2f, 71.4f, 196.6f);
        }
    }

}
