using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float rotationSpeed = 200;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // we spin the propeller of the plane
        transform.Rotate(new Vector3(0, 0, 360) * rotationSpeed * Time.deltaTime);

    }
}
