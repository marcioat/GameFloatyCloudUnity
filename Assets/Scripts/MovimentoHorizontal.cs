using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoHorizontal : MonoBehaviour
{
    [SerializeField]
    [Range(0, 2)]
    private float velocidade;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -6)
        {
            Destroy(gameObject);
        }
        else
        {
            transform.position -= new Vector3(Time.deltaTime * velocidade, 0, 0);
        }
    }
}
