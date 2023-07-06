using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoVertical : MonoBehaviour
{
    [SerializeField]
    [Range(0, 2)]
    private float velocidade;

    private bool isSubir;

    // Start is called before the first frame update
    private void Start()
    {
        isSubir= Random.Range(0, 2)==1;
    }

    // Update is called once per frame
    void Update()
    {
        isSubir = transform.position.y <= -5 || transform.position.y >= 5 ? !isSubir : isSubir;
        var intY = isSubir ? 1 : -1;

        transform.position += new Vector3(0, Time.deltaTime * velocidade * intY, 0);
    }
}
