using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerButton : MonoBehaviour
{
    bool isTriggered;
    public GameObject[] paths;

    void Start()
    {
        foreach (GameObject p in paths)
        {
            p.SetActive(false);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            foreach (GameObject p in paths)
            {
                p.SetActive(true);
            }
        }
    }
}
