using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MonsterSpawner : MonoBehaviour
{
    public  GameObject monster;
    public float startTime;
    public float repeatTime;
    void Start()
    {
      InvokeRepeating("Spawn", startTime, repeatTime);
    }

    void Spawn()
    {
        GameObject bullet = Instantiate(monster, transform.position, transform.rotation) as GameObject;

    }
}
