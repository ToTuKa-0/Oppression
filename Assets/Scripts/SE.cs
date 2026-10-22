using UnityEngine;

public class SE : MonoBehaviour
{
    public AudioClip hitSE;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // A以外のオブジェクトに当たったら
        if (collision.gameObject.name != "Ball")
        {
            audioSource.PlayOneShot(hitSE);
        }
    }
}
