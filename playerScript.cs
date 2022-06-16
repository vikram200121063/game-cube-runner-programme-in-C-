using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public Rigidbody body;
    public float force = 1000f;
    public float speed = 10f;
    public float minX ;
    public float maxX ;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("hello world");
        

        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x, minX, maxX );
        // if(playerPos.x < minX)
        // {
        //     playerPos.x = minX;
        // }
        // if(playerPos.x > maxX)
        // {
        //     playerPos.x = maxX;
        // }
        transform.position = playerPos;
        
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(speed*Time.deltaTime, 0, 0 );
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position - new Vector3(speed*Time.deltaTime, 0, 0 );
        }
        
    }
     private void FixedUpdate() {
        body.AddForce(0, 0, 1000f*Time.deltaTime);
    }
}
