using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GeradorDeInimigo : MonoBehaviour
{
    [SerializeField]
    private PesoInimigo[] inimigos;

    private int totalPesos;
    // Start is called before the first frame update
    void Start()
    {
        totalPesos = inimigos.Sum(e => e.Peso);

        StartCoroutine(GerarInimigos());
    }

    private IEnumerator GerarInimigos()
    {
        while (true)
        {
            int qtdInimigos = Random.Range(1, 4);

            Enumerable.Range(0, qtdInimigos + 1)
                .Select(_ => Instantiate(GetInimigo(), new Vector3(Random.Range(4f, 9f), Random.Range(-4f, 5f), 0), Quaternion.identity))
                .ToList();

            yield return new WaitForSeconds(3f);
        }
    }


    private GameObject GetInimigo()
    {
        int numeroSorteado = Random.Range(0, totalPesos) + 1;
        int pesoProcessado = 0;

        var inimigoData = inimigos.OrderByDescending(e => e.Peso).FirstOrDefault(inimigo =>
        {
            pesoProcessado += inimigo.Peso;
            return numeroSorteado <= pesoProcessado;
        });

        return inimigoData?.Inimigo;
    }
}
