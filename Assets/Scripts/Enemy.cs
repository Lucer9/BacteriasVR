using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy: MonoBehaviour {

    GameObject player;
    NavMeshAgent enemy;
    Animator anim;

    // Use this for initialization
    void Start() {
        anim = GetComponent <Animator> ();
        player = GameObject.FindGameObjectWithTag("Player");

        if (player == null) {
            Debug.Log("Did u forgot to tag your player or FPS Controller");
        }


        enemy = GetComponent <NavMeshAgent> ();


    }

    // Update is called once per frame
    void Update() {

        if (player != null)
            enemy.destination = player.transform.position;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter(Collider collider) {
        if (collider.gameObject.tag == "Player") // this string is your newly created tag
        {
            Debug.Log("Did u forgot to tag your player or FPS Controller");
            anim.SetBool("attack",true);
        }
    }
}