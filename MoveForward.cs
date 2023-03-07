using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 200f;
  


  
  
    void Update()
    {
        
        this.transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }
}
