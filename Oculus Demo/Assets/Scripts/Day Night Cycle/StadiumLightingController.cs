using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StadiumLightingController : MonoBehaviour
{
    [SerializeField]
    GameObject testObj;

    [SerializeField]
    float sunsetPosition = 30.1f; //while greater than this it is night time
    [SerializeField]
    float sunsetAngle = .751f;
    [SerializeField]
    float sunrisePos = -42f;
    [SerializeField]
    float sunriseAngle = -4.834f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
