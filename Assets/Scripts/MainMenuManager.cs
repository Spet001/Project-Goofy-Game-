
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class MainMenuManager : MonoBehaviour
{
    [Header("Cenas")]
    [Tooltip("Nome da cena da cutscene de introdução")]
    public string introCutsceneSceneName = "IntroCutscene";
    [Tooltip("Nome da cena do Level 1")]
    public string level1SceneName = "LEVEL1";

    [Header("Eventos dos Botões")]
    public UnityEvent onNewGame;
    public UnityEvent onOptions;
    public UnityEvent onExit;

    // Chamada pelo botão "New Game"
    public void OnNewGame()
    {
        if (onNewGame != null)
            onNewGame.Invoke();
        else
            SceneManager.LoadScene(introCutsceneSceneName);
    }

    // Chamada pelo botão "Options"
    public void OnOptions()
    {
        if (onOptions != null)
            onOptions.Invoke();
        else
            Debug.Log("Options menu ainda não implementado.");
    }

    // Chamada pelo botão "Exit"
    public void OnExit()
    {
        if (onExit != null)
            onExit.Invoke();
        else
        {
            Application.Quit();
            Debug.Log("Saindo do jogo...");
        }
    }

    // Métodos utilitários para serialização no Inspector
    public void LoadIntroCutsceneScene()
    {
        SceneManager.LoadScene(introCutsceneSceneName);
    }

    public void LoadLevel1Scene()
    {
        SceneManager.LoadScene(level1SceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Saindo do jogo...");
    }
}
