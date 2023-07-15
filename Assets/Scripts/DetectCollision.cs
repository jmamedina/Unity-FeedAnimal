using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public GameManager gameManager;
    public float animalPoint;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    //this function is already provided by MonoBehavior class
    private void OnTriggerEnter(Collider other)
    {
        gameManager.UpdateScore(animalPoint);

        //destroy the game object when collided
        Destroy(gameObject); 
        //destroy other game objects that collided on the game object
        Destroy(other.gameObject); 
    }
}
