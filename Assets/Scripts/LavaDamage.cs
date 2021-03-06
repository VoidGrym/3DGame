﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaDamage : MonoBehaviour
{
    public GameObject Player;
    private PlayerHealth HP;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            HP = Player.GetComponent<PlayerHealth>();
            HP.TakeDamage(2);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            HP = Player.GetComponent<PlayerHealth>();
            HP.TakeDamage(2);
        }
    }
}
