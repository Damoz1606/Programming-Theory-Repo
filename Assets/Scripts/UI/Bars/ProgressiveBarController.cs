using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class ProgressiveBarController : MonoBehaviour
{
    [SerializeField] protected Slider _slider;

    public abstract void SetMaxValue(float maxValue);

    public abstract void SetValue(float value);
}
