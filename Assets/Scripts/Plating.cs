using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Plating : MonoBehaviour
{
    public bool PlateZone;
    public bool AllPresent;
    public Player Player;
    public GameManager GM;
    bool finishgame = false;
    public Animator transition;
    public GameObject LasagnaDog;
    public AudioSource AS;
    public AudioClip Bruh;

    public GameObject Finish_text;

    void Update()
    {
        if (AllPresent == true && PlateZone && Input.GetKeyDown(KeyCode.E) && finishgame == false)
        {
            Finish_text.SetActive(!Finish_text.activeSelf);
            LasagnaDog.SetActive(!LasagnaDog.activeSelf);
            StartCoroutine(ToOutroScene());
            finishgame = true;
        }
    }

    IEnumerator ToOutroScene()
    {
        AS.PlayOneShot(Bruh, 1f);
        yield return new WaitForSeconds(5f);
        StartCoroutine(LoadGame(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadGame(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(levelIndex);
    }
    public void Allhere()
    {
        AllPresent = true;
        Debug.Log("It's all here");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player_In_PlateZone");
            PlateZone = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlateZone = false;
            Debug.Log("Player_Left_PlateZone");
        }
    }
}
