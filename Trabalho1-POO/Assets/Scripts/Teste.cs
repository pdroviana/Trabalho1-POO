using UnityEngine;

public class Teste : MonoBehaviour
{
    
    Fada fada = new Fada();
    Personagem mago = new Personagem();
    
    void Start()
    {
        fada.setvelocidade(30);
        fada.setenergia(70);
        fada.setforcaAtaque(20);
        fada.setnome("Samilly");
        fada.setvida(75);
        Debug.Log(fada.Nome() + " tem " + fada.Energia() + " de energia, " + fada.ForcaAtaque() + " força de ataque, " + fada.Velocidade() + " de velocidade e " + fada.Vida() + " de vida.");
        
        mago.setvelocidade(20);
        mago.setenergia(60);
        mago.setforcaAtaque(30);
        mago.setnome("Pedro");
        Debug.Log(mago.Nome() + " tem " + mago.Energia() + " de energia, " + mago.ForcaAtaque() + " força de ataque, " + mago.Velocidade() + " de velocidade e " + mago.Vida() + " de vida.");


        if (fada.ForcaAtaque() > mago.ForcaAtaque())
        {
            Debug.Log(fada.Nome() + "é mais forte que " + mago.Nome());
        }
        
        if (mago.ForcaAtaque() > fada.ForcaAtaque())
        {
            Debug.Log(mago.Nome() + "é mais forte que " + fada.Nome());
        }
    }

    
    void Update()
    {
        
    }
}
