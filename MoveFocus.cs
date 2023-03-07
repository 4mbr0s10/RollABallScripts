using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFocus : MonoBehaviour
{
    public int speed = 1;
    public Transform player;
   

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(player);
        this.transform.Translate(Vector3.forward*speed*Time.deltaTime);
    }
}
