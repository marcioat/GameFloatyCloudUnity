using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagemColisao : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite spritePersonagemGameOver;
    [SerializeField] private GameObject transicaoGameOver;
    [SerializeField] private GameObject painelGameOver;
    [SerializeField] private AudioSource  soundGameOver;
    [SerializeField] private AudioSource musicBackground;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Inimigo" || collision.gameObject.tag == "Limite")
        {
            GameOver();

        }
    }

    private void GameOver()
    {
        Time.timeScale = 0;

        spriteRenderer.sprite = spritePersonagemGameOver;
        transicaoGameOver.transform.position = transform.position;
        transicaoGameOver.SetActive(true);
        soundGameOver.Play();
        musicBackground.Stop();

        StartCoroutine(ExibirPainelGameOver());

    }

    private IEnumerator ExibirPainelGameOver()
    {
        yield return new WaitForSecondsRealtime(1f);
        painelGameOver.SetActive(true);
    }
}
