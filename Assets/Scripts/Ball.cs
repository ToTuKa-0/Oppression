using UnityEngine;

public class Ball : MonoBehaviour
{
    // 初期速度(v0)
    public Vector2 initialSpeed = Vector2.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 移動に使用するRigidbodyを取得する
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        // Rigidbodyに初期速度を適用させる
        rb.linearVelocity = initialSpeed;
    }
}
