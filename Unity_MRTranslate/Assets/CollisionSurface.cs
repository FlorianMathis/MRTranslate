using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSurface : MonoBehaviour
{

    GameObject distanceline;
    GameObject surface;
    public Material greenmaterial;
    public Material redmaterial;

    public Vector3 insituposition;

    // Start is called before the first frame update
    void Start()
    {
        distanceline = GameObject.Find("DistanceLine");
        surface = GameObject.Find("RealitySurface");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Gets called at the start of the collision 
   

    void OnTriggerEnter(Collider objectName)

    {
        
        MeshRenderer meshRenderer = distanceline.gameObject.GetComponent<MeshRenderer>();
        // Get the current material applied on the GameObject
        Debug.Log("Applied Material: " + redmaterial.name);
        // Set the new material on the GameObject
        meshRenderer.material = greenmaterial;
        insituposition = objectName.gameObject.GetComponent<Collider>().ClosestPointOnBounds(transform.position);
        Debug.Log("position in space " + insituposition);
    }
    void OnTriggerExit(Collider objectName)
    {
        MeshRenderer meshRenderer = distanceline.gameObject.GetComponent<MeshRenderer>();
        meshRenderer.material = redmaterial;        
    }

    public Vector3 getInSituPosition()
    {
        return insituposition;
    }


}
