using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 40.0f;

    public GameObject projectilePrefab;
    public GameObject pizzaPrefab;
    public GameObject bonePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Create leftBoundary and keep the player in the bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //Create rightBoundary
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        } 
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        
        if (Input.GetKeyDown(KeyCode.P))
        {
            //Launch a pizza from the player
            Instantiate(pizzaPrefab, transform.position, pizzaPrefab.transform.rotation);
        }
        
        if (Input.GetKeyDown(KeyCode.B))
        {
            //Launch a bone from the player
            Instantiate(bonePrefab, transform.position, bonePrefab.transform.rotation);
        }
    }
}
