using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject newGamePopup;

    
   

public void StartNewGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void OnPlayClicked()
    {
        Debug.Log("Loading Game Scene...");
        SceneManager.LoadScene("GameScene");
    }
    public void OnNewGameClicked()
    {
        Debug.Log("Loading Settings Scene...");
        SceneManager.LoadScene("SettingsScene");
    }
    
     public void OpenPopup()
    {
        newGamePopup.SetActive(true);
    }

    public void ClosePopup()
    {
        newGamePopup.SetActive(false);
    }

    public void OnLoadClicked()
    {
        Debug.Log("Loading Settings Scene...");
        SceneManager.LoadScene("SaveScene");
    }
    public void OnSettingsClicked()
    {
        Debug.Log("Loading Settings Scene...");
        SceneManager.LoadScene("SettingsScene");
    }
    public void OnQuitClicked()
    {
        Debug.Log("Loading Settings Scene...");
        SceneManager.LoadScene("QuitScene");
    }
}