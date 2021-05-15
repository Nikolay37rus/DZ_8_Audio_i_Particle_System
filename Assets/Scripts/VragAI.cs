using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VragAI : MonoBehaviour
{
    Animator anim;
    public GameObject player;

    public GameObject GetPlayer()
    {
        return player;
    }
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        anim.SetFloat("distance", Vector3.Distance(transform.position,player.transform.position));
    }
}
