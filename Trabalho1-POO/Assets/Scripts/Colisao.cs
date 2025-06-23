using System;
using UnityEngine;

public class Colisao : MonoBehaviour
{
    private Fada fada;
    private void OnCollisionEnter(Collision colisao)
    {
        if (gameObject.CompareTag("Player"))
        {
            float energia_atual = fada.Energia()
                                - colisao.gameObject.GetComponent<Ataque>().mago.ForcaAtaque();


            fada.Energia();
           
        Debug.Log("Samilly " + fada.Nome()+" tem agora "+ fada.Energia() + " de energia.");
    }
}

    void Start()
    {
    fada = GetComponent<Fada>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
