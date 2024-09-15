using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.ShaderData;

public class run : MonoBehaviour
{
    private float runMutliplayer = 0.2f;
    public Animator animC;
    public GameObject end;
    public bool FirstRun = false; 

    Rigidbody m_Rigidbody;
    float m_Speed;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Speed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            animC.SetBool("Run", true);
            m_Rigidbody.velocity = transform.forward * m_Speed * runMutliplayer;
            runMutliplayer += 0.1f;
            if(FirstRun == false)
            {
                FirstRun = true;
            }
        }
        if(m_Rigidbody.velocity.x == 0)
        {
            animC.SetBool("Run", false);

        }
    }
}
