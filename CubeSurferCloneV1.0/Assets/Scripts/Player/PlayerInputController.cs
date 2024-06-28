using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    private float horizantalValue;

    public float HorizantalValue
    {
        get { return horizantalValue; }
    }
    void Update()
    {
        HandleHeroHorizantalInput();
    }

    private void HandleHeroHorizantalInput()
    {
        if (Input.GetMouseButton(0))
        {
            horizantalValue = Input.GetAxis("Mouse X");
        }
        else
        {
            horizantalValue = 0;
        }
    }
}
