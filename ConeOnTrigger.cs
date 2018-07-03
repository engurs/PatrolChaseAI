using UnityEngine;
using System.Collections;

public class ConeOnTrigger : MonoBehaviour {

    public ZombieAi zombieAi;

   
    void OnTriggerEnter2D(Collider2D o)
    {

        
        if (o.gameObject.tag == "Player")
        {
            zombieAi.inViewCone = true;
        }
    }
    
    void OnTriggerExit2D(Collider2D o)
    {


        if (o.gameObject.tag == "Player")
        {
            zombieAi.inViewCone = false;
        }
    }
}
