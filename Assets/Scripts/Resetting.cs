using UnityEngine;
using UnityEngine.SceneManagement;

public class Resetting : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("r"))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}
