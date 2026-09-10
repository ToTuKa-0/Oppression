using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    [Header("接触対象のタグ")]
    [SerializeField] private string targetTag = "Target";

    [Header("接触するたびに消すオブジェクト")]
    [SerializeField] private List<GameObject> objectsToDelete = new List<GameObject>();

    [Header("リストが空になった後に移行するシーン")]
    [SerializeField] private string nextSceneName;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 指定したタグ以外なら何もしない
        if (!collision.gameObject.CompareTag(targetTag))
            return;

        HandleTouch();
    }

    private void HandleTouch()
    {
        // リストにまだ削除対象が残っている場合
        if (objectsToDelete.Count > 0)
        {
            // リストの先頭を取得
            GameObject target = objectsToDelete[0];

            // GameObjectを削除
            if (target != null)
            {
                Destroy(target);
            }

            // リストから削除
            objectsToDelete.RemoveAt(0);
        }
        else
        {
            // リストが全部消えた状態で再度接触
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
