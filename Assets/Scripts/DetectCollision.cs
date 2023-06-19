using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }

    //this function is already provided by MonoBehavior class
    private void OnTriggerEnter(Collider other)
    {
        //destroy the game object when collided
        Destroy(gameObject); 
        //destroy other game objects that collided on the game object
        Destroy(other.gameObject); 
    }
}
