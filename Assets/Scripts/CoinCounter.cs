using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI exitMsg;

    private float coin = 0;

    public TextMeshProUGUI textCoins;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Coin")
        {
            coin++;
            textCoins.text = coin.ToString() + "/6";

            Destroy(collision.gameObject);

            if(coin == 6)
            {
                
                StartCoroutine(CloseAfterTime());
            }
        }
    }

    IEnumerator CloseAfterTime()
    {
        yield return new WaitForSeconds(1);
        exitMsg.enabled = true;
        yield return new WaitForSeconds(4);
        Application.Quit();
    }
}
