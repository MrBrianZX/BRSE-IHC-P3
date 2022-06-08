using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float force = 150;
    private Renderer rend;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 vector = new Vector3(h,0.5f,v);

        rb.AddForce(vector * force * Time.deltaTime);
    }

    private void OnTriggerStay(Collider collision){
        if (Input.GetKey (KeyCode.R)) {
            if(collision.gameObject.CompareTag("Yellow")){
                GetComponent<Renderer> ().material.color = Color.yellow;
            }
            else if(collision.gameObject.CompareTag("Blue")){
                GetComponent<Renderer> ().material.color = Color.blue;
            }
            else if(collision.gameObject.CompareTag("Red")){
                GetComponent<Renderer> ().material.color = Color.red;
            }
        }
    }
}
