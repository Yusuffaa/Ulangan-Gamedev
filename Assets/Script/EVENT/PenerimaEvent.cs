using UnityEngine;

public class PenerimaEvent : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        PemancarEvent.saatTombolDiTekan += Respon;
    }

    private void OnDisable()
    {
        PemancarEvent.saatTombolDiTekan -= Respon;
    }

    void Respon()
    {
        Debug.Log("Tombol Ditekan");
    }
}