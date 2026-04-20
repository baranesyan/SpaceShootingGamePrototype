using UnityEngine;

public class MoveForwardController : MonoBehaviour
{
    public float speed = 80.0f;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
