using UnityEngine;

public class Tomater : MonoBehaviour
{
    public bool GrownTomato = false;
    public SpriteRenderer TomatoSR;
    public Sprite[] sprites;
    private int currentSpriteIndex = 0;


    void OnMouseDown()
    {
        currentSpriteIndex++;

        if (currentSpriteIndex >= 3)
        {
            GrownTomato = true;
            Debug.Log("Finished growing");
        }
        if (sprites.Length > 0 && sprites[currentSpriteIndex] != null)
        {
            TomatoSR.sprite = sprites[currentSpriteIndex];
        }
    }
}
