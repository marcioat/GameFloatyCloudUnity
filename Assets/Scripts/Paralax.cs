using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    private Material mat;
    private Vector2 offSet;

    [SerializeField]
    [Range(0, 1)]
    float velocidade;
    // Start is called before the first frame update
    void Awake()
    {
        mat = GetComponent<MeshRenderer>().material;

    }

    // Update is called once per frame
    void Update()
    {
        var x = offSet.x >= 1 ? 0 : (offSet.x + Time.deltaTime * velocidade);
        offSet.Set(x, 0);
        mat.mainTextureOffset = offSet;
    }
}
