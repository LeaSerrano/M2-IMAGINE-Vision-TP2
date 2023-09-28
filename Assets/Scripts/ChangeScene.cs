using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        print(other.tag);

        if (other.tag == "Dragon" && GameVariables.nbCats >= 2)
        {
            LoadTerrain();
            
        }
    }

    void LoadTerrain()
    {
        SceneManager.LoadScene("terrain");
    }

}
