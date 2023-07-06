using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagemMovimento : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sp;

    [SerializeField]private Sprite spParado;
    [SerializeField] private Sprite spMovendo;


    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * 150);
            sp.sprite = spMovendo;

            StopAllCoroutines();
            StartCoroutine(MudarParaSpriteParado());
        }
    }


    private IEnumerator MudarParaSpriteParado()
    {
        yield return new WaitForSeconds(0.8f);
        sp.sprite = spParado;
    }

}
