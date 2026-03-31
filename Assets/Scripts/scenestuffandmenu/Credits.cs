using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public GameObject Creditstext;
    public void Creditss()
    {
        Creditstext.SetActive(!Creditstext.activeSelf);
    }

    public void Update()
    {
        if ((Input.GetKey(KeyCode.E)))
        {
            Creditstext.SetActive(false);
        }
    }
}
