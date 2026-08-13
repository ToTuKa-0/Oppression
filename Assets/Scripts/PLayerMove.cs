using UnityEngine;

public class PLayerMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Vector2 pos = transform.position;
            pos.x += 0.07f;
            transform.position = pos;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Vector2 pos = transform.position;
            pos.x -= 0.07f;
            transform.position = pos;
        }
    }
}
