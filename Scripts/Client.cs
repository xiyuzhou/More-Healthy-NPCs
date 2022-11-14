using System;
using System.Collections;
using UnityEngine;

public class Client : MonoBehaviour
{
    public GameObject npc;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            npc.GetComponent<NPC>().TakeDamage(10);
        }
        if (Input.GetMouseButtonDown(2))
        {
            npc.GetComponent<NPC>().TakePoisonDamage(20,5,7,0.5f);
        }
        if (Input.GetMouseButtonDown(1))
        {
            npc.GetComponent<NPC>().TakeHeavyDamage(30);
        }

    }
}
