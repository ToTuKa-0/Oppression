using UnityEngine;
using static UnityEditor.PlayerSettings;

public class PLayerMove : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0f)
            return;

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
