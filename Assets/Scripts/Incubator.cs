using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.U2D;

public class Incubator : MonoBehaviour
{
    public bool IncZone;
    public Player Player;
    public GameManager GM;
    public GameObject Incpov;
    public GameObject DairyGame;
    public GameObject GrainGame;
    public GameObject FruitGame;
    public GameObject VeggieGame;
    public GameObject ProteinGame;

    public SpriteRenderer MilkSR;
    public Sprite Milk;
    public Sprite Cheese;

    public bool DGameinProgress;
    public bool GGameinProgress;
    public bool FGameinProgress;
    public bool VGameinProgress;
    public bool PGameinProgress;

    public TextMeshProUGUI TimeNumber;
    public float Remainingtime;

    public SpriteRenderer MeatSR;
    public Sprite Rawmeat;
    public Sprite Cookedmeat;

    public AudioSource AS;
    public AudioClip Completion;

    void Start()
    {
        MilkSR.sprite = Milk;
        MeatSR.sprite = Rawmeat;
    }

    void Update()
    {
        if (IncZone && Input.GetKeyDown(KeyCode.E))
        {
            if (Player.Dairy_Spirit && GM.Dairy_Complete == false)
            {
                DairyGame.SetActive(!DairyGame.activeSelf);
                DGameinProgress = true;
            }
            if (Player.Grain_Spirit && GM.Grain_Complete == false)
            {
                GrainGame.SetActive(!GrainGame.activeSelf);
                GGameinProgress = true;
            }
            if (Player.Fruit_Spirit && GM.Fruit_Complete == false)
            {
                FruitGame.SetActive(!FruitGame.activeSelf);
                FGameinProgress = true;
            }
            if (Player.Veggie_Spirit && GM.Veggie_Complete == false)
            {
                VeggieGame.SetActive(!VeggieGame.activeSelf);
                VGameinProgress = true;
            }
            if (Player.Protein_Spirit && GM.Protein_Complete == false)
            {
                ProteinGame.SetActive(!ProteinGame.activeSelf);
                PGameinProgress = true;
            }
        }
        if (DGameinProgress == true)
        {
            if (Orb1.Charged == true && Orb2.Charged == true && Orb3.Charged == true && Orb4.Charged == true)
            {
                AS.PlayOneShot(Completion, 1f);
                MilkSR.sprite = Cheese;
                GM.Dairy_Complete = true;
                Debug.Log("Dairygame Completed");
                DGameinProgress = false;
                StartCoroutine(Minigame1());
            }
        }
        if (GGameinProgress == true)
        {
            if(bread.CookedBread == true)
            {
                AS.PlayOneShot(Completion, 1f);
                GM.Grain_Complete = true;
                Debug.Log("Graingame Completed");
                GGameinProgress = false;
                StartCoroutine(Minigame2());
            }
        }
        if (FGameinProgress == true)
        {
            if (Tomater.GrownTomato == true)
            {
                AS.PlayOneShot(Completion, 1f);
                GM.Fruit_Complete = true;
                Debug.Log("FruitGame Completed");
                FGameinProgress = false;
                StartCoroutine(Minigame3());
            }    
            
        }
        if (VGameinProgress == true)
        {
            if (Onion.OnionGood == true)
            {
                AS.PlayOneShot(Completion, 1f);
                GM.Veggie_Complete = true;
                Debug.Log("VeggieGame Completed");
                VGameinProgress = false;
                StartCoroutine(Minigame4());
            }
        }
        if (PGameinProgress == true)
        {
            int seconds = Mathf.FloorToInt(Remainingtime % 60);
            TimeNumber.text = string.Format("{00}", seconds);
            if (Remainingtime > 0)
            {
                Remainingtime -= Time.deltaTime;
            }
            else if (Remainingtime < 0)
            {
                AS.PlayOneShot(Completion, 1f);
                MeatSR.sprite = Cookedmeat;
                Remainingtime = 0;
                GM.Protein_Complete = true;
                Debug.Log("ProteinGame Completed");
                PGameinProgress = false;
                StartCoroutine(Minigame5());
            }
                
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player_In_IncZone");
            IncZone = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            IncZone = false;
            Debug.Log("Player_Left_IncZone");
        }
    }

    public Orbs Orb1;
    public Orbs Orb2;
    public Orbs Orb3;
    public Orbs Orb4;
    public Bread bread;
    public Tomater Tomater;
    public Onion Onion;


    IEnumerator Minigame1()
    {
        yield return new WaitForSeconds(2f);
        DairyGame.SetActive(false);
    }

    IEnumerator Minigame2()
    {
        yield return new WaitForSeconds(2f);
        GrainGame.SetActive(false);
    }
    IEnumerator Minigame3()
    {
        yield return new WaitForSeconds(2f);
        FruitGame.SetActive(false);
    }
    IEnumerator Minigame4()
    {
        yield return new WaitForSeconds(2f);
        VeggieGame.SetActive(false);
    }
    IEnumerator Minigame5()
    {
        yield return new WaitForSeconds(2f);
        ProteinGame.SetActive(false);
    }
}
