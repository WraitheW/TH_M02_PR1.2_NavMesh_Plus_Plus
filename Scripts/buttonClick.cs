using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonClick : MonoBehaviour
{
    Color green;
    Color red;
    gamemanager gm;

    // Start is called before the first frame update
    void Start()
    {
        red = Color.red;
        green = Color.green;
        this.gameObject.GetComponent<Renderer>().material.color = red;

        gm = FindObjectOfType<gamemanager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (this.gameObject.GetComponent<Renderer>().material.color == red)
            {
                this.gameObject.GetComponent<Renderer>().material.color = green;
                gm.buttonPressed();
            }
        }
    }
}
