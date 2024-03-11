using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetakip : MonoBehaviour
{
    public Rigidbody kamera;

    void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))     // veya " if(Input.GetKey("d")) "
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 2f);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))     // veya " if(Input.GetKey("a")) "
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, -2f);
        }
        else
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        }
    }
}

