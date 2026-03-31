using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Etocontinue : MonoBehaviour
{
    public Animator transition;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(LoadGame(SceneManager.GetActiveScene().buildIndex + 1));
        }
        
    }
    IEnumerator LoadGame(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(levelIndex);
    }
}
