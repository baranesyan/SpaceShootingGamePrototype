using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private bool alreadyHit = false;

    private void OnTriggerEnter(Collider other)
    {
        if (alreadyHit) return;
        alreadyHit = true;
        
        GameManager gm = FindObjectOfType<GameManager>();

        if (other.CompareTag("Enemy"))
        {
            gm.AddScore();
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Player"))
        {
            gm.GameOver();
        }

        if (other.CompareTag("Projectile"))
        {
            gm.AddScore();
        }

        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
