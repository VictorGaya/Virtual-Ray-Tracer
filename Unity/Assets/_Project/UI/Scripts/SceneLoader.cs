using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private static SceneLoader instance;

    [SerializeField]
    private Animator transition;

    [SerializeField]
    private float transitionTime = 1f;

    /// <summary>
    /// Get the current SceneLoader instance.
    /// </summary>
    /// <returns>The current SceneLoader instance</returns>
    public static SceneLoader Get()
    {
        return instance;
    }

    public void LoadScene(int index)
    {
        StartCoroutine(LoadSceneInternal(index));
    }

    public void LoadScene(string name)
    {
        StartCoroutine(LoadSceneInternal(name));
    }

    IEnumerator LoadSceneInternal(int index)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadSceneAsync(index);
    }

    IEnumerator LoadSceneInternal(string name)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadSceneAsync(name);
    }

    private void Awake()
    {
        instance = this;
    }
}
