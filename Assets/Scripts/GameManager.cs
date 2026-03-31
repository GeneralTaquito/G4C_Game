using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool Dairy_Complete = false;
    public bool Grain_Complete = false;
    public bool Fruit_Complete = false;
    public bool Veggie_Complete = false;
    public bool Protein_Complete = false;

    bool Mark1 = false;
    bool Mark2 = false;
    bool Mark3 = false;
    bool Mark4 = false;
    bool Mark5 = false;

    public GameObject Dairy;
    public GameObject Grain;
    public GameObject Fruit;
    public GameObject Veggie;
    public GameObject Protein;


    public GameObject Player;
    public Plating Plating;
    void Update()
    {
        if (Dairy_Complete != false && !Mark1)
        {
            Dairy.SetActive(!Dairy.activeSelf);
            Mark1 = true;
            Debug.Log("DAIRY IS FINISHED");

        }
        if (Grain_Complete != false && !Mark2)
        {
            Grain.SetActive(!Grain.activeSelf);
            Mark2 = true;
            Debug.Log("Grain IS FINISHED");

        }
        if (Fruit_Complete != false && !Mark3)
        {
            Fruit.SetActive(!Fruit.activeSelf);
            Mark3 = true;
            Debug.Log("Fruit IS FINISHED");

        }
        if (Veggie_Complete != false && !Mark4)
        {
            Veggie.SetActive(!Veggie.activeSelf);
            Mark4 = true;
            Debug.Log("Veggie IS FINISHED");

        }
        if (Protein_Complete != false && !Mark5)
        {
            Protein.SetActive(!Protein.activeSelf);
            Mark5 = true;
            Debug.Log("Protein IS FINISHED");

        }

        if (Dairy_Complete ==true && Grain_Complete == true && Fruit_Complete == true && Veggie_Complete == true && Protein_Complete == true)
        {
            Plating.Allhere();
        }
    }
}
