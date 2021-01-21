using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Coin : MonoBehaviour
{
    // Start is called before the first frame updatepublic GameObject Moneys;
    public int Coin_Chance = 50;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(Random.Range(0, 101) <= Coin_Chance);
    }
}
