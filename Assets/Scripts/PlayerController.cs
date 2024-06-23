using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 25.0f;
    private float turnspeed = 50.0f;
    private float hosrizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update() 
 {
        hosrizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    //we will move vehicle forward
    transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //transform.Translate(Vector3.right * Time.deltaTime * turnspeed * hosrizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * hosrizontalInput);
}
}
