using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 20;

    // with prefab object, whenever you fire the object it will create a new object
    // if you used the object on the hierarchy window it will only use that object again
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //prevent character from falling

        //left
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        };

        //right
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        };

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //create copy of objects
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
