using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectColider : MonoBehaviour
{
    public bool openSence = false;
    public bool returnToMain = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Door")
        {
            Debug.Log("Can pass");
            openSence = true;
        }

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "Return")
        {
            Debug.Log("Can return");
            returnToMain = true;
        }
    }
    private void Update()
    {
       if(openSence && Input.GetKey(KeyCode.P))
        {
            SceneManager.LoadScene(1);
        }
       if(returnToMain && Input.GetKey(KeyCode.P))
        {
            SceneManager.LoadScene(0);
        }
    }
}
