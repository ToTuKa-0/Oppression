using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTest : MonoBehaviour
{
    // 遷移先のシーンの名前
    [SerializeField]
    private string sceneName_ = "";

    // Update is called once per frame
    void Update()
    {
        // スペースキーを押したらシーン切り替え
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // シーンを読み込む
            SceneManager.LoadScene(sceneName_);
        }
    }
}
