using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonScale : MonoBehaviour
{
    private Button _button;
    private Vector3 originalScale;

    private void Awake()
    {
        _button = GetComponent<Button>();
        originalScale = _button.transform.localScale;
    }

    
    public void ScaleButton(bool scaleUp)
    {
        // If ScaleUp = True, then increase the size of the button (Used on hover or on select) - Uses LeanTween to smoothly animate/Scale the object
        if(scaleUp)
        {
            LeanTween.scale(this.gameObject, originalScale * 1.3f, 0.1f);
        }
        else
        {
            LeanTween.scale(this.gameObject, originalScale, 0.1f);
        }

    }



}
