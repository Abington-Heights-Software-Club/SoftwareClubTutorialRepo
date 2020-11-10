using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvanScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position = transform.position + new Vector3(-1, -1);
        }
    }
}
