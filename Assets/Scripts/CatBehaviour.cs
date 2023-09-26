using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CatBehaviour : MonoBehaviour
{
    public GameObject fx;
    public GameObject worldObject;
    void Start()
    {
        worldObject = GameObject.Find("World");
    }
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    { // OnCollisionEnter
        AudioSource collisionSound = GameObject.Find("World").GetComponent<AudioSource>();

        if (collisionSound)
        {
            collisionSound.Play();
        }
        if (other.tag == "Player")
        {
            print("test");
            Instantiate(fx, transform.position, Quaternion.identity);
            Destroy(gameObject);
            worldObject.SendMessage("AddHit");
        }
    }
}
