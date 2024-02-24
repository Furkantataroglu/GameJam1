using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yellow : MonoBehaviour
{
    public Material YellowMet;
    public Material DefaultMet;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material = DefaultMet;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            GetComponent<Renderer>().material = YellowMet;
        }
        //else if (Input.GetKeyUp(KeyCode.X))
        //{
          //  GetComponent<Renderer>().material = DefaultMet;
        //}
    }
}
