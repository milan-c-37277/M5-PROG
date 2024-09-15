using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TriggerEnd : MonoBehaviour
{
    public Animator animC;
    public timer timerScript;

    public Rigidbody m_Rigidbody;
    float m_Speed;
    // Start is called before the first frame update
    void Start()
    {
        m_Speed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Victory();
            m_Rigidbody.velocity = transform.forward * 0 * 0;
        }
    }

    private void Defeat()
    {
        animC.SetTrigger("Defeat");

    }

    private void Victory()
    {
        animC.SetTrigger("Victory");
    }
}
