using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeahMove : MonoBehaviour
{
    private Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("l"))
        {
            ani.SetBool("IsJumping", true);
            transform.position = transform.position + new Vector3(-1, 0);
        }
        else
        {
            ani.SetBool("IsJumping", false);
        }
        
    }
}
