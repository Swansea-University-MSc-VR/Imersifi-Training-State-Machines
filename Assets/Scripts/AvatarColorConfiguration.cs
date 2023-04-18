using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// This component is used to set the skin colors and trim colors on the customglove example shadergraph.
public class AvatarColorConfiguration : MonoBehaviour
{
    [SerializeField] Material CustomGloveMaterial;


    #region General functions to set the exposed color parameters of our material and shader.
    
    public void SetSkinColor(Color color)
    {
        CustomGloveMaterial.SetColor("_SkinColor", color);
    }

    public void SetTrimColor(Color color)
    {
        CustomGloveMaterial.SetColor("_GloveTrimColor", color);
    }

    #endregion



    
    #region Specific functions that allow us to get the color of the button pressed to assign the correct color

    public void SkinButton(Button button)
    {
        // Get the color of the button that called this function
        Color DesiredSkinColor = button.colors.normalColor;

        // Used our general material function to set this on the gloves
        SetSkinColor(DesiredSkinColor);
    }
    
    public void TrimButton(Button button)
    {
        // Get the color of the button that called this function
        Color DesiredTrimColor = button.colors.normalColor;

        // Used our general material function to set this on the gloves
        SetTrimColor(DesiredTrimColor);
    }

    #endregion


}
