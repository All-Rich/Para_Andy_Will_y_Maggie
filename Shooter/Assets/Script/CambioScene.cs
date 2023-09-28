using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void LevelMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    public void Level1()
    {
        SceneManager.LoadScene(1);
    }
    public void Credits()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
