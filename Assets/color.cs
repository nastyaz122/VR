using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{
    // Start is called before the first frame update
    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }

    // Update is called once per frame
    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
