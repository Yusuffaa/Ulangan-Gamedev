using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public float kecepatan = 5f;
    private Vector2 arahGerak;
    public int score = 0;
    private GameManager gameManager;
    public TextMeshProUGUI scoreText;


    void OnMove(InputValue value)
    {
        arahGerak = value.Get<Vector2>();
    }

    void Update()
    {
        Vector3 arah = new Vector3(arahGerak.x, arahGerak.y, 0);
        transform.position += arah * kecepatan * Time.deltaTime;
    }

    // Dipanggil otomatis saat Player menyentuh objek ber-Trigger
   void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("coin"))
    {
        
        Destroy(other.gameObject);
         score++; // Tambahkan skor
        Debug.Log("Score: " + score); // Tampilkan skor di console
        scoreText.text = "" + score;
        FindFirstObjectByType<GameManager>().AmbilKoin();
    }
}
}
   