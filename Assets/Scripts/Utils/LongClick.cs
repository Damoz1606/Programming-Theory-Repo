using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class LongClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool pointerDown;
    [SerializeField] private UnityEvent OnLongClick;
    public void OnPointerDown(PointerEventData eventData)
    {
        this.pointerDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        this.pointerDown = false;
    }

    private void Update() {
        if (this.pointerDown) {
            if (OnLongClick != null) {
                OnLongClick.Invoke();
            }
        }
    }
}
