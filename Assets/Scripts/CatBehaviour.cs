using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CatBehaviour : MonoBehaviour
{
    public GameObject fx;
    void Start()
    {
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
                Instantiate(fx, transform.position, Quaternion.identity);
                Destroy(gameObject);
        }
    }
}
