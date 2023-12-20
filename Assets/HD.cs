using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fixed : MonoBehaviour
{
    private void Start()
    {
        SetResolution(); 
    }
    
    /// <summary>

    /// </summary>
    public void SetResolution()
    {
        int setWidth = 630;
        int setHeight = 1280;


        Screen.SetResolution(setWidth, setHeight, true);
    }
}

