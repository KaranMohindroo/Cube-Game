using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// This is a reference to the Rigidbody component called "rb"
	public Rigidbody rb;

	public float forwardForce = 10000f;	// Variable that determines the forward force
	public float sidewaysForce = 250f;  // Variable that determines the sideways force
    private float ScreenWidth;
    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.
    void Start()
    {
        ScreenWidth = Screen.width;

    }
    void FixedUpdate ()
	{
		// Add a forward force
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        
        /*  if (Input.GetMouseButtonDown(0))	// If the player is pressing the "d" key
          {
              // Add a force to the right
              rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
          }

          if (Input.GetMouseButtonDown(1))  // If the player is pressing the "a" key
          {
              // Add a force to the left
              rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
          }*/
        // int i = 0;
        //loop over every touch found
        //  while (i <= Input.touchCount)
        // {
        if ((Input.GetKey("d"))||(Input.GetTouch(0).position.x > ScreenWidth / 2))
            {
                //move right
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if ((Input.GetKey("a"))||(Input.GetTouch(0).position.x < ScreenWidth / 2))
            {
                //move left
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
          //  ++i;
     //   }

       /* if (rb.position.y < 0f)
		{
			FindObjectOfType<GameManager>().EndGame();
		}*/
	}
}
