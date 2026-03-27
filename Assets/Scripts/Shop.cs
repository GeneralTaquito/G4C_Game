using UnityEditor.Build;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public bool Shopzone;
    public Player Player;
    public GameManager GM;

    public GameObject Floating1;
    public GameObject Floating2;
    public GameObject Floating3;
    public GameObject Floating4;
    public GameObject Floating5;

    void Update()
    {
        if (Shopzone && Input.GetKeyDown(KeyCode.E))
        {
            if (Player.Dairy_Spirit == false)
            {
                Player.Dairy_Spirit = true;
                Debug.Log("Gained Dairy Spirit");
            }
            if (Player.Grain_Spirit == false && GM.Dairy_Complete == true)
            {
                Player.Grain_Spirit = true;
                Debug.Log("Gained Grain Spirit");
            }
            if (Player.Fruit_Spirit == false && GM.Grain_Complete == true)
            {
                Player.Fruit_Spirit = true;
                Debug.Log("Gained Fruit Spirit");
            }
            if (Player.Veggie_Spirit == false && GM.Fruit_Complete == true)
            {
                Player.Veggie_Spirit = true;
                Debug.Log("Gained Veggie Spirit");
            }
            if (Player.Protein_Spirit == false && GM.Veggie_Complete == true)
            {
                Player.Protein_Spirit = true;
                Debug.Log("Gained Protein Spirit");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("PLAYERRRR");
            Shopzone = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Shopzone = false;
            Debug.Log("noplaya");
        }
    }
}
