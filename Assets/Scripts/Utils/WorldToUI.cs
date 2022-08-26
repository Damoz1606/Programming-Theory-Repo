using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldToUI
{
    public static Vector2 ScreenPosition(Vector3 worldPosition, float scaleFactor)
    {
        Vector2 screenPoint = RectTransformUtility.WorldToScreenPoint(Camera.main, worldPosition);
        return screenPoint;
    }
}
