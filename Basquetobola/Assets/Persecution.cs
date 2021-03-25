using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Persecution : MonoBehaviour
{
    GameObject player;
    NavMeshAgent nav;

    void Start()
    {
    }

    private void Update()
    {
        nav = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        if (nav != null && player != null && nav.isActiveAndEnabled)
            nav.SetDestination(player.transform.position);
    }
}
