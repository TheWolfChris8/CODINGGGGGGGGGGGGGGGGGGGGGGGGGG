using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalSwapScript : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other)
   {
    if(other.gameObject.CompareTag("Portal"))
    {
        SceneManager.LoadScene("Level2");
    }
    if(other.gameObject.CompareTag("GoToWin"))
    {
        SceneManager.LoadScene("WIN");
    }
   }
}
