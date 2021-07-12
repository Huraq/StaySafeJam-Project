using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{

    public Animator transitionAnim;

    public void LoadNewScene(string sceneToChange)
    {
        StartCoroutine(ChangeScene(sceneToChange));
    }
    
    IEnumerator ChangeScene(string sceneToChange)
    {
        transitionAnim.SetTrigger("endMainMenu");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneToChange);
    }
}
