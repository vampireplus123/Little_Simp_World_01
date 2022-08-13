using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectColider : MonoBehaviour
{
    public bool openSence = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Door" || other.tag == "Return")
        { 
            openSence = true;
        }
    }
    private void Update()
    {
       if(openSence && Input.GetKey(KeyCode.P))
        {
            SceneManager.LoadScene(1);
        }
    }
}
