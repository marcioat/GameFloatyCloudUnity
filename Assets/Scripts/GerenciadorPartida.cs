using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorPartida : MonoBehaviour
{
    private bool partidaIniciada = false;

    void Awake()
    {
        Time.timeScale = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (partidaIniciada) return;

        if (Input.GetMouseButtonDown(0))
        {
            partidaIniciada = true;
            Time.timeScale = 1;
        }
        
    }
}
