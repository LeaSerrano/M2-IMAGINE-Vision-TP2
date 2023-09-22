using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class UIBehaviour : MonoBehaviour
{
    TMP_Text headText;
    int nbCats = 0;
    void Start()
    {
        headText = GameObject.Find("lblCats").GetComponent<TMPro.TMP_Text>();
    }
    void Update()
    {
    }
    public void AddHit()
    {
        nbCats++;
        headText.text = "Catbots touchés : " + nbCats;
    }
}