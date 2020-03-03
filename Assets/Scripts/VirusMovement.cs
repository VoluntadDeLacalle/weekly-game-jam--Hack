using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusMovement : MonoBehaviour
{
    public float speed = 3;

    void Update()
    {
        transform.position += ((transform.forward * speed) * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Firewall")
        {
            print("Got em!");
            Destroy(gameObject);
        }
    }
}
