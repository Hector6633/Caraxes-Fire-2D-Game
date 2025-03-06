using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [Header("Option Panel")]
    [SerializeField] private GameObject OptionPanel;
    private void Awake()
    {
        OptionPanel.SetActive(false);
    }


    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    //Main Menu
    public void Main_menu()
    {
        SceneManager.LoadScene(0);
    }

    //Quit game/exit play mode if in Editor
    public void Quit()
    {
        Application.Quit(); //Quits the game (only works in build)

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; //Exits play mode (will only be executed in the editor)
        #endif
    }

    public void SoundVolume()
    {
        SoundManager.instance.ChangeSoundVolume(0.2f);
    }
    public void MusicVolume()
    {
        SoundManager.instance.ChangeMusicVolume(0.2f);
    }
}
