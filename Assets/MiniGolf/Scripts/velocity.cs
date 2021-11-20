using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velocity : MonoBehaviour
{
    private float rgvel;
    // Start is called before the first frame update
    void Start()
    {
        rgvel =   GetComponent<Rigidbody>().velocity.magnitude;
    }

    // Update is called once per frame
    void Update()
    {
        rgvel =   GetComponent<Rigidbody>().velocity.magnitude;
        print(rgvel);
    }
}
