using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EgoCentricDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(GameObject.Find("CenterEyeAnchor").transform.position.x, GameObject.Find("CenterEyeAnchor").transform.position.y, GameObject.Find("CenterEyeAnchor").transform.position.z);
        transform.eulerAngles = new Vector3(GameObject.Find("CenterEyeAnchor").transform.rotation.eulerAngles.x, GameObject.Find("CenterEyeAnchor").transform.rotation.eulerAngles.y, GameObject.Find("CenterEyeAnchor").transform.rotation.eulerAngles.z);

    }
}
