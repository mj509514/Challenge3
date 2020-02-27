using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelWallController : MonoBehaviour
{
    //public GameObject finalWall;
    //public GameObject wheel;

    public Transform wallTransform;

    float zRot = 0;

    [Range(0.0f, 100.0f)]
    public float wheelRot;


    private void Start()
    {


    }


    private void Update()
    {
        transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, zRot, transform.rotation.w);
    
        Debug.Log(zRot);
    }























    //Vector3 wallPos;
    //Quaternion wheelRot;
    //float wallY;
    // float wheelZ;


    // Start is called before the first frame update
    // void Start()
    //{
    //finalWall.transform.position = transform.position;
    //    this.transform.rotation = Quaternion.Euler(wheelZ, 0, 0);
    //wallPos.y = wallY;
    //wheelRot.z = wheelZ;
    //}

    // Update is called once per frame
    //void Update()
    //{
    //wheelZ = wallY;
    /* finalWall.transform.position = transform.position;
     wheel.transform.rotation = transform.rotation;
     wallPos.y = wallY;
     wheelRot.z = wheelZ;
     wheelZ = finalWall.transform.position.y; */

    // wheelZ = wheelRot;

    //}
}
