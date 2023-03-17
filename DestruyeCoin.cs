using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruyeCoin : MonoBehaviour
{
    public GameObject pickup;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DestroyObject(pickup);
        }
    }
}
