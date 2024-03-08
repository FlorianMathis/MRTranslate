using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calibration : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject surface;
    GameObject leftfingertip;
    void Start()
    {
        surface = GameObject.Find("RealitySurface");
        leftfingertip = GameObject.Find("b_l_index_null");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            surface.transform.position = leftfingertip.transform.position;
            Debug.Log("calibration complete");

        }
    }
}
