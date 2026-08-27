using UnityEngine;

public class Block : MonoBehaviour
{
    // èâä˙ë¨ìx(v0)
    public float initialSpeed = 0.1f;

    private void Update()
    {
        transform.position += Vector3.down * initialSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}