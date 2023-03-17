using UnityEngine;



using System.Collections;

public class PlayerControllerAsset : MonoBehaviour {
	
	
	public float speed;
	//public Text countText;
	//public Text winText;
	public GameObject bullet;
	
	private Rigidbody rb;
	private int count;
	public GameObject puerta;

	// At the start of the game..
	void Start ()
	{
	
		rb = GetComponent<Rigidbody>();

	

		
	}

	// Each physics step..
	void FixedUpdate ()
	{
	
		float horizontalInput = Input.GetAxis ("Horizontal");
		float verticalInput = Input.GetAxis ("Vertical");
		this.transform.Translate(speed * Time.deltaTime * Vector3.forward * verticalInput);
		this.transform.Translate(Time.deltaTime * speed * Vector3.right * horizontalInput);
		if (this.transform.position.y < 50)
		{
			this.transform.position = new Vector3(181.2f, 71.4f, 196.6f);

		}
        if (speed >= 20f)
        {
			puerta.transform.Translate(Time.deltaTime * Vector3.up);
        }
		
	

		
		

		if (Input.GetKeyUp(KeyCode.Space))
		{
			Instantiate(bullet, this.transform.position, bullet.transform.rotation);

		}
	}

	
	void OnTriggerEnter(Collider other) 
	{
		
		if (other.gameObject.CompareTag ("Pick Up"))
		{
		
			other.gameObject.SetActive (false);
			speed = speed + 10.0f;
		
			count = count + 1;

		
		}
	}

	
}