using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    // Start is called before the first frame update

    //public float speedZ;
    //public float speedgiro;
    //bool hasJump;
    //Rigidbody rb;
    //public float JumpForce;
    bool llavebl;
    


    public GameObject llave;
    public GameObject puerta;
    int bienvenidoscounter;
    void Start()
    {
        //hasJump = true;
        llavebl = false;
        bienvenidoscounter = 0;
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))

        //{
        //    transform.Translate(0, 0, speedZ);
        //}
        //if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.Translate(0, 0, -speedZ);
        //}
        //if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Rotate(0, speedgiro, 0);
        //}
        //if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Rotate(0, -speedgiro, 0);
        //}
        //if (Input.GetKeyDown(KeyCode.Space) && hasJump)
        //{
        //    rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        //    hasJump = false;
        //}
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "llave")
        {
            llave.SetActive(false);
            llavebl = true;
        }
        if (col.gameObject.name == "puerta" && llavebl)
        {
            puerta.SetActive(false);
            
        }
        //if (col.gameObject.name == "piso")
        //{
        //    hasJump = true;
        //}
        if (col.gameObject.name == "paso" )
        {
            puerta.SetActive(true);
            
        }

        if (col.gameObject.name == "bienvenidos" && bienvenidoscounter == 0)
        {
            SceneManager.LoadScene("ranzo");

        }
    }
}
