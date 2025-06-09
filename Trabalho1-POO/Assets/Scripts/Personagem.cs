using UnityEngine;

public class Personagem : MonoBehaviour
{
    public string nome;
    public int energia;
    public float velocidade;
    public float forcaAtaque;

    public void setnome(string nome)
    {
        this.nome = nome;
    }

    public string Nome()
    {
        return this.nome;
    }


    public void setenergia(int energia)
    {
        this.energia = energia;
    }


    public int Energia()
    {
        return this.energia;
    }


    public void setvelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }


    public float Velocidade()
    {
        return this.velocidade;
    }
    
    
    public void setforcaAtaque(float forcaAtaque)
    {
        this.forcaAtaque = forcaAtaque;
    }


    public float ForcaAtaque()
    {
        return this.forcaAtaque;
    }
    
    
    void Start()
    {
        
    }

 
    void Update()
    {
        
    }
}
