using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class coin_picker : MonoBehaviour
{
  private float coin =0;
  
  public TextMeshProUGUI score;

  private void OnTriggerEnter(Collider other)
  {
      if(other.transform.tag == "coin")
      {
          Destroy(other.gameObject);
          coin++;
          score.text = coin.ToString();
      }
  }
}
