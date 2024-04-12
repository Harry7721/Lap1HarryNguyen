using UnityEngine;
using System.Collections;

public class Forces : MonoBehaviour
{
    public float speed;
    // Use this for initialization
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
             
        Vector3 move = new Vector3(hor, 0.0f, ver);
        GetComponent<Rigidbody>().AddForce(move * speed * Time.deltaTime);
    }
}
