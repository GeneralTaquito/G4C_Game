using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject ShopMenu;
    public bool Shopzone;

    void Update()
    {
        if (Shopzone && Input.GetKeyDown(KeyCode.E))
        {
            if (ShopMenu != null)
            {
                ShopMenu.SetActive(!ShopMenu.activeSelf);
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

            if (ShopMenu != null && ShopMenu.activeSelf)
            {
                ShopMenu.SetActive(false);
            }
        }
    }
}
