using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public int totalKoin;
    private int koinTerkumpul = 0;
    public TextMeshProUGUI TextMenang;

    void Start()    
    {
        // Hitung jumlah koin di scene saat mulai
        totalKoin = GameObject.FindGameObjectsWithTag("coin").Length;
    }

    public void AmbilKoin()
    {
        koinTerkumpul++;

        // Jika semua koin sudah diambil, panggil Menang()
        if (koinTerkumpul == totalKoin)
            Menang();
    }

    void Menang()
    {
        Debug.Log("KAMU MENANG!");
        TextMenang.gameObject.SetActive(true);
    }

}