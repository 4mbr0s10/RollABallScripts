using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    public float velocidad = 20;
    public float turnSpeed = 20;
   
    public float horizontalInput;
    public float verticalInput;
    public GameObject bullet;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


      
      //MOvimiento Player
       horizontalInput = Input.GetAxis("Horizontal");
       verticalInput = Input.GetAxis("Vertical");
       this.transform.Translate(velocidad*Time.deltaTime*Vector3.forward*verticalInput);
       this.transform.Translate(Time.deltaTime * turnSpeed * Vector3.right*horizontalInput);
        this.transform.Rotate(Vector3.zero);

        if (this.transform.position.y<50)
        {
            this.transform.position = new Vector3(181.2f, 71.4f, 196.6f);

        }

        // ACCION

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(bullet,this.transform.position, bullet.transform.rotation);

        }

    }
}
