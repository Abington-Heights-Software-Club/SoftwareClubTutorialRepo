using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MikeMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("m"))
        {
            transform.position = transform.position +  new Vector3(5, 0);
        }
    }
}
