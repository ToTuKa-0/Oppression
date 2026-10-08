using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float m_speed = 15;
    [SerializeField] private Vector2 m_direction = new(1, 1);

    private Rigidbody2D m_rigidbody2D;
    private Vector2 m_velocity;

    public GameObject ballPrefab_ = null;

    private void Start()
    {
        m_rigidbody2D = GetComponent<Rigidbody2D>();

        m_direction.Normalize();

        m_velocity = m_direction * m_speed;
        m_rigidbody2D.linearVelocity = m_velocity;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        var inDirection = m_velocity;
        var inNormal = other.contacts[0].normal;

        m_direction = Vector2.Reflect(inDirection, inNormal).normalized;

        m_velocity = m_direction * m_speed;
        m_rigidbody2D.linearVelocity = m_velocity;
    }

    // 速度増加の関数
    public void SpeedUp()
    {
        m_speed += 5;
    }

    // 速度低下の関数
    public void SpeedDown()
    {
        m_speed -= 3;
    }

    // サイズ増加の関数
    public void SizeUp()
    {
        transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
    }

    // サイズ低下の関数
    public void SizeDown()
    {
        transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
    }

    // 個数増加の関数
    public void Increase()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Ball");
        int countBall = objects.Length;

        if (countBall < 4)
        {
            // ボールの生成数を決定する
            int SpownBalls = Random.Range(1, 2);
            
            // 場に存在するボールの数が4個以上になるのなら、生成数を再度ランダムに決定する。
            if (SpownBalls + countBall > 3) return;

            for (int i = 0; i <= SpownBalls; ++i)
            {
                // Ballプレハブから新しいインスタンスを生成
                GameObject ball = Instantiate(ballPrefab_);
                // Ballの場所をボールの位置とする
                ball.transform.position = transform.position;
            }
        }
        else return;
    }

    // 残機増加の関数
    public void Protect()
    {

    }

}