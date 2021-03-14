using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObstacle : MonoBehaviour
{
    gamemanager gm;
    Transform transf;
    public Transform newTransf;
    public Transform oldTransf;

    void Start()
    {
        gm = FindObjectOfType<gamemanager>();
        transf = this.gameObject.transform;
        oldTransf = transf;
    }

    void Update()
    {
        if (gm.pressed)
        {
            transf.position = newTransf.position;
        }
        if (!gm.pressed)
        {
            transf.position = oldTransf.position;
        }
    }
}
