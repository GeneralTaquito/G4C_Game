using System.Collections;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public bool Shopzone;
    public Player Player;
    public GameManager GM;
    public AudioSource AS;
    public AudioClip SFXAttain;

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
                AS.PlayOneShot(SFXAttain, 1.0f);
                Floating1.SetActive(!Floating1.activeSelf);
                Player.Dairy_Spirit = true;
                Debug.Log("Gained Dairy Spirit");
                StartCoroutine(GoawayText());
            }
            if (Player.Grain_Spirit == false && GM.Dairy_Complete == true)
            {
                AS.PlayOneShot(SFXAttain, 1.0f);
                Floating2.SetActive(!Floating2.activeSelf);
                Player.Grain_Spirit = true;
                Debug.Log("Gained Grain Spirit");
                StartCoroutine(GoawayText());
            }
            if (Player.Fruit_Spirit == false && GM.Grain_Complete == true)
            {
                AS.PlayOneShot(SFXAttain, 1.0f);
                Floating3.SetActive(!Floating3.activeSelf);
                Player.Fruit_Spirit = true;
                Debug.Log("Gained Fruit Spirit");
                StartCoroutine(GoawayText());
            }
            if (Player.Veggie_Spirit == false && GM.Fruit_Complete == true)
            {
                AS.PlayOneShot(SFXAttain, 1.0f);
                Floating4.SetActive(!Floating4.activeSelf);
                Player.Veggie_Spirit = true;
                Debug.Log("Gained Veggie Spirit");
                StartCoroutine(GoawayText());
            }
            if (Player.Protein_Spirit == false && GM.Veggie_Complete == true)
            {
                AS.PlayOneShot(SFXAttain, 1.0f);
                Floating5.SetActive(!Floating5.activeSelf);
                Player.Protein_Spirit = true;
                Debug.Log("Gained Protein Spirit");
                StartCoroutine(GoawayText());
            }
        }
    }

    IEnumerator GoawayText()
    {
        yield return new WaitForSeconds(1.5f);
        Floating1.SetActive(false);
        Floating2.SetActive(false);
        Floating3.SetActive(false);
        Floating4.SetActive(false);
        Floating5.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Player_In_ShopZone");
            Shopzone = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Shopzone = false;
            Debug.Log("Player_Left_ShopZone");
        }
    }
}
