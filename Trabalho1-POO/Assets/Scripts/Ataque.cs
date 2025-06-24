using UnityEngine;

public class Ataque : MonoBehaviour
{
    public Personagem mago;
    private int ataque;
    

    public int AtaqueDoInimigo()
    {
        ataque = mago.ForcaAtaque();
        return ataque;
    }
    
}
