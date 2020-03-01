using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelWallController : MonoBehaviour
{
    public GameObject finalWall;
 
    [SerializeField]
    float eulerAngX;
    [SerializeField]
    float eulerAngY;
    [SerializeField]
    float eulerAngZ;


    void Update()
    {

        eulerAngX = transform.localEulerAngles.x;
        eulerAngY = transform.localEulerAngles.y;
        eulerAngZ = transform.localEulerAngles.z;


        finalWall.transform.Translate(0, eulerAngZ * 0.001f *Time.deltaTime, 0);
        
    }









}
