using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class Shooting : NetworkBehaviour
{
    public int force = 200;
    public GameObject projectile;
    public bool cooldown;
    public float fireRate = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
//        if(isLocalPlayer){
//            if ((OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) > 0.0f && !cooldown)||(Input.GetMouseButtonDown(0)) && !cooldown)
//            {
//                Fire();
//                cooldown = true;
//                Invoke("FireRate", fireRate);
//            }
//
//        }
    }

    public void Fire()
    {
        GameObject bullet = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * force);
    }

    public void FireRate()
    {
        cooldown = false;
    }
}
