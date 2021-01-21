using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Script : MonoBehaviour
{
    // Start is called before the first frame update

    public Text Score_Text;
    public GameObject Panel;
    static int count;



    void Start()
    {
   
        count = 0;
        Score_Text.text = "Счёт: 0";
        Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Score_Text.text = "Счёт: " + count.ToString();
            
    }

    public static void Plus_Score()
    {
        count ++;
    }

    public void Game_Over()
    {
        Panel.SetActive(true);
    }


}
