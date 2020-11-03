using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoeMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("j"))
        {
        transform.position += new Vector3(5,0);
        }
    }
}
