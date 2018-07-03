using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private float speed = 4f;
    	
	// Update is called once per frame
	void Update () {

        // Quit if the player presses Escape
        if (Input.GetKey("escape"))
            Application.Quit();

        // Get input from the keyboard or controller
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // Calculate the angle to rotate the player
        Vector3 facing = new Vector3(h, v, 0);
        float angle = Mathf.Atan2(facing.y, facing.x) * Mathf.Rad2Deg;

        // Rotate the player
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));

        // Move the player
        transform.Translate(facing * speed * Time.deltaTime, Space.World);
    }
    
}
