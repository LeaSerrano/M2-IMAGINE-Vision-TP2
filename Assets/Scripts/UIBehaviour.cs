using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIBehaviour : MonoBehaviour
{
    TMP_Text headText;
    TMP_Text timerText;
    void Start()
    {
        headText = GameObject.Find("lblCats").GetComponent<TMPro.TMP_Text>();
        timerText = GameObject.Find("lblTime").GetComponent<TMPro.TMP_Text>();
        StartCoroutine(TimerTick());
    }
    void Update()
    {
    }
    public void AddHit()
    {
        GameVariables.nbCats++;
        headText.text = "Catbots touchés : " + GameVariables.nbCats;
    }
    public IEnumerator TimerTick()
    {
        while (GameVariables.currentTime > 0)
        {
            // attendre une seconde
            yield return new WaitForSeconds(1);
            GameVariables.currentTime--;
            timerText.text = "Time : " + GameVariables.currentTime.ToString();
        }
        // game over
        SceneManager.LoadScene("sceneCatBots"); // le nom de votre scene
    }
}