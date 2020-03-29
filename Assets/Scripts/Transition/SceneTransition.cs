using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{

    public Animator transitionAnim;

    // Update is called once per frame
    void Update()
    {
    }

    public void LoadGame()
    {
        StartCoroutine(StartGame());
    }

    public void LoadCredits() 
    {
        StartCoroutine(StartCredits());
    }
    IEnumerator StartGame()
    {
        transitionAnim.SetTrigger("endMainMenu");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("SampleScene");
    }

    IEnumerator StartCredits()
    {
        transitionAnim.SetTrigger("endMainMenu");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Credits");
    }
}
