using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart_Game : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClickButton()
    {
        Debug.Log("клик");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

}
