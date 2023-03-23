using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PostAnimate()
    {
        SceneManager.LoadScene("Final Scene");
    }
}