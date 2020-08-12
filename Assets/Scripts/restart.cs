using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class restart : MonoBehaviour
{
   public void JogarNovamente()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
