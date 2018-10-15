using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {

    public GameObject Platform;
    public GameObject PlatformSize;
    public Transform generationPoint;
    public float distanceBetween;
    private float platformWidth;
    private List<GameObject> PlatformList = new List<GameObject>();
    private GameObject plat;
    // Use this for initialization
    void Start () {

        platformWidth = PlatformSize.GetComponent<Renderer>().bounds.size.x;
        PlatformList.Add(GameObject.Find("Platform")); 

    }

    // Update is called once per frame
    void Update ()
    {
       
        if (transform.position.x < generationPoint.position.x)
        {
           transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween,transform.position.y,transform.position.z);
           plat = Instantiate(Platform, transform.position, transform.rotation); PlatformList.Add(plat);
        }

           if (PlatformList.Count>3) { Destroy(PlatformList[0]); PlatformList.RemoveAt(0); }
      

    }
}
    