using UnityEngine;

public class Barrier : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
            Destroy(gameObject);
    }
}