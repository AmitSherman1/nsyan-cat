using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
   public void MenuPlay ()
   {
    SceneManager.LoadSceneAsync(1);
   }
}
