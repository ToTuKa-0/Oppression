using UnityEngine;

public class Buff_SizeDown : MonoBehaviour
{
    // 初期速度(v0)
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
            // フィールドからボールのコンポーネントを取得
            GameObject ballObj = GameObject.Find("Ball");

            if (ballObj != null)
            {
                Ball ball = ballObj.GetComponent<Ball>();
                if (ball != null)
                {
                    ball.SizeDown();
                }

            }


            Destroy(gameObject);
        }
    }
}
