using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance 
    { 
        get => FindObjectOfType<UIManager>(); 
    }

    private GameObject _gameRef;

    [Space(10)]
    [SerializeField] GameObject menu;
    [SerializeField] GameObject settings;
    [SerializeField] GameObject top;
    [SerializeField] GameObject game;
    [SerializeField] GameObject pause;
    [SerializeField] GameObject result;


    private void Start()
    {
        OpenMenu();
    }

    public void StartGame()
    {
        Time.timeScale = 1;

        var _parent = GameObject.Find("Environment").transform;
        var _prefab = Resources.Load<GameObject>("levels");

        _gameRef = Instantiate(_prefab, _parent);

        menu.SetActive(false);
        result.SetActive(false);
        
        game.SetActive(true);
    }

    public void OpenSettings()
    {
        settings.SetActive(true);
        menu.SetActive(false);
    }

    public void OpenTop()
    {
        top.SetActive(true);
        menu.SetActive(false);
    }

    public void SetPause(bool IsPause)
    {
        Time.timeScale = IsPause ? 1 : 0;
        pause.SetActive(IsPause);
    }

    public void OpenMenu()
    {
        if (_gameRef)
        {
            Destroy(_gameRef);
        }

        game.SetActive(false);
        settings.SetActive(false);
        top.SetActive(false);
        pause.SetActive(false);
        result.SetActive(false);

        menu.SetActive(true);
    }

    public void GameOver()
    {
        if (_gameRef)
        {
            Destroy(_gameRef);
        }

        game.SetActive(false);
        result.SetActive(true);
    }
}
