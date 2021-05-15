using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreator : MonoBehaviour
{
    public GameObject BillrtPrefab;
    public float BolletVelocity = 20f;
   

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject newBullet = Instantiate(BillrtPrefab, transform.position, transform.rotation);
            newBullet.GetComponent<Rigidbody>().velocity = transform.forward * BolletVelocity;
        }
    }
}
