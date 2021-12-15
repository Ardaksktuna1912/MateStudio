using UnityEngine;
using UnityEngine.EventSystems;

public class buttonjoy : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [HideInInspector]
    protected bool Pressed;
    void Start()
    {

    }


    void Update()
    {

    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }
}
