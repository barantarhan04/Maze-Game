using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "top") 
        {
            CoinText.coinAmount += 10;
            Destroy(gameObject);
        }
    }
}