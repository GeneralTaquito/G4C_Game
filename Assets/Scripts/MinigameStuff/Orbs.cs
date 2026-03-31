using UnityEngine;
using UnityEngine.EventSystems;

public class Orbs : MonoBehaviour
{
    public SpriteRenderer SR;
    public bool Charged = false;

    void OnMouseDown()
    {
        SR.color = Color.purple;
        Debug.Log("Clicked!");
        Charged = true;
    }
    

}
