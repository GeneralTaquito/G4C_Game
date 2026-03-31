using UnityEngine;

public class Bread : MonoBehaviour
{
    public float requiredHoldTime = 5.0f; 
    private float Mousedown;
    private bool isMouseHeld = false;
    public bool CookedBread = false;
    public SpriteRenderer BreadSR;
    public Sprite Dough;
    public Sprite BakedBread;

    void OnMouseDown()
    {
        Mousedown = Time.time; 
        isMouseHeld = true;
        Debug.Log("Started baking");
    }
    void Start()
    {
        BreadSR.sprite = Dough;
    }

    void OnMouseDrag()
    {
        if (isMouseHeld)
        {
            float holdDuration = Time.time - Mousedown;
            if (holdDuration >= requiredHoldTime)
            {
                FinishedBake();
            }
        }
    }
    void OnMouseUp()
    {
        isMouseHeld = false;
        float holdDuration = Time.time - Mousedown;
        Debug.Log("Baking Stopped: " + holdDuration);
    }
    void FinishedBake()
    {
        BreadSR.sprite = BakedBread;
        CookedBread = true;
        Debug.Log("Baked!");
    }
}
