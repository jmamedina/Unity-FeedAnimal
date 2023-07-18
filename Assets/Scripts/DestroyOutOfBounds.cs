using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private float sideBound = 20;

    // Start is called before the first frame update
    void Start()
    {
        //border = GameObject.FindWithTag("Detector");
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.z > topBound)
        {
            // if the pizza passed the top bound it will be destroyed
        }
        else if (transform.position.z < lowerBound)
        {
            //if the animals passed the lower bound it will be destroyed
            Destroy(gameObject);
        }
        else if (transform.position.x < -sideBound)
        {
            //
            Destroy(gameObject);
        }
        else if (transform.position.x > sideBound)
        {
            //
            Destroy(gameObject);
        }
    }
}
