using UnityEngine;

public class Onion : MonoBehaviour
{
    public bool OnionGood = false;
    public SpriteRenderer OnionSR;
    public Sprite OnionHappy;
    public Sprite OnionSad;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Tissue"))
        {
            Debug.Log("Rubbing tears away");
            OnionSR.sprite = OnionHappy;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Tissue"))
        {
            OnionGood = true;
            Debug.Log("Tissue away");
        }
    }
}
