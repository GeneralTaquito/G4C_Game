using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class The_Menu : MonoBehaviour
{
    public Animator transition;

    public float transitiondelay = 1f;
    public void StartGame()
    {
        StartCoroutine(LoadGame(SceneManager.GetActiveScene().buildIndex + 1));
    }
    public void Credits()
    {
        // lol
    }

    IEnumerator LoadGame(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitiondelay);

        SceneManager.LoadScene(levelIndex);
    }
}
