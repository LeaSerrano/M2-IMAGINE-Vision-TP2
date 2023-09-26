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

        if (other.tag == "Dragon")
        {
            LoadMenu();
            
        }
    }

    void LoadMenu()
    {
        SceneManager.LoadScene("terrain");
    }

}
