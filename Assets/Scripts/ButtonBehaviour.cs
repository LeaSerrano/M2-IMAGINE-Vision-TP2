using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    public GameObject lumierePrefab;
    public Vector3 positionLumiere;
    public GameObject dragon;

    // Start is called before the first frame update
    void Start()
    {
        dragon = GameObject.Find("Dragon_Baked_Actions_fbx_7.4_binary");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject lumiereInstance = Instantiate(lumierePrefab, positionLumiere, Quaternion.identity);
            Destroy(dragon);
        }
    }
}
