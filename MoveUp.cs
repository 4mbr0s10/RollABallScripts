using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public GameObject puerta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

	// Update is called once per frame
	void OnTriggerEnter(Collider other)
	{

        if (other.CompareTag("Proyectil"))
        {
            this.transform.Translate(Vector3.left*5*Time.deltaTime);
            //DestroyObject(puerta);
        }
    }
}
