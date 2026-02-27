using System.Collections;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float Timer = 200;
    public TextMeshProUGUI timeText;
    public GameObject Player;
    public Sprite[] BGS;
    void Update()
    {
        Timer -= Time.deltaTime;
        timeText.text = Timer.ToString("00:00");

        if (Timer < 0)
        {
            Timer = 200;
        }
    }
}
