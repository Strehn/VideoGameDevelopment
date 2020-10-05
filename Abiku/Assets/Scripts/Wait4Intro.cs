using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wait4Intro : MonoBehaviour
{
    public float wait_time = 5f;

    void Start()
    {
        StartCoroutine(WaitTime());
        
    }
    IEnumerator WaitTime()
    {
        //Debug.Log("Waiting for Intro");
        yield return new WaitForSeconds(wait_time);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    


}
