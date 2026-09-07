using UnityEngine;
using System;
using UnityEngine.InputSystem;


public class PemancarEvent : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static event Action saatTombolDiTekan;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        if(Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Debug.Log("Tombol Space ditekan");
            saatTombolDiTekan?.Invoke();
        }
    }
}
