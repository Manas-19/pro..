using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Sc;
    private void GroundSpawn()
    {
        Instantiate(Sc);
    }

void OnTriggerEnter(Collider other)
    {
        GroundSpawn();
    }
}
