using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool bGameEnded = false;
    public void EndGame(bool killed = false)
    {
        if (bGameEnded == false)
        {
            bGameEnded = true;
            Invoke("Restart", killed ? 0.0f : 0.5f);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
