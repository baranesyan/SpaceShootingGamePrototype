using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 65;
    private float lowerBound = -65;

    void Update()
    {
        if (transform.transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
