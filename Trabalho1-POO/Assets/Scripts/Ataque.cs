using UnityEngine;

public class Ataque : MonoBehaviour
{
    public Personagem mago;
    private float ataque;
    

    public float AtaqueDoInimigo()
    {
        ataque = mago.ForcaAtaque();
        return ataque;
    }
    
}
