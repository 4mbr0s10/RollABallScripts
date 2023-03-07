using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(-50, 50, -50);

    private void Update()
    {
        this.transform.position = player.transform.position + offset;
        if (Input.GetKey(KeyCode.C))
        {
            
            this.transform.position = player.transform.position;
        }
    }

}
