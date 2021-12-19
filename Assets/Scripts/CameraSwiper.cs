using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraSwiper : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    [SerializeField]
    private Transform _camera;

    public void OnBeginDrag(PointerEventData eventData)
    {
       
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 delta = eventData.delta / 10;
        _camera.Rotate(0, delta.x, 0);
    }
}
