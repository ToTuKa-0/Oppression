using UnityEngine;

public class Buff_SizeDown : MonoBehaviour
{
    // èâä˙ë¨ìx(v0)
    public float initialSpeed = 0.7f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * initialSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
