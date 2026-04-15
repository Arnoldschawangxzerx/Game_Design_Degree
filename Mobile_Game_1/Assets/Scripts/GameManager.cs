using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playButton;

    void Start()
    {
        Time.timeScale = 0f; // pause game at start
    }

    public void StartGame()
    {
        playButton.SetActive(false); // hide button
        Time.timeScale = 1f; // start game
    }
}