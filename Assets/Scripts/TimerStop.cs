using UnityEngine;

public class TimerStop : MonoBehaviour
{
    [Header("ポーズ中に表示するCanvas")]
    [SerializeField] private GameObject pauseCanvas;

    [Header("再開に使うキー")]
    [SerializeField] private KeyCode resumeKey = KeyCode.LeftShift;

    private bool isPaused = false;

    void Start()
    {
        pauseCanvas.SetActive(false);
    }

    void Update()
    {
        if (isPaused)
        {
            if (Input.GetKeyDown(resumeKey))
            {
                ResumeGame();
            }

            return;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            PauseGame();
        }
    }

    private void PauseGame()
    {
        isPaused = true;

        Time.timeScale = 0f;

        pauseCanvas.SetActive(true);
    }

    private void ResumeGame()
    {
        isPaused = false;

        Time.timeScale = 1f;

        pauseCanvas.SetActive(false);
    }

    private void OnDestroy()
    {
        Time.timeScale = 1f;
    }
}
