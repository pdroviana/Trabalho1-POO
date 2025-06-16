using UnityEngine;

public class Personagem : MonoBehaviour
{

    [SerializeField]
    private string nome;
    [SerializeField]
    private int energia;
    [SerializeField]
    private float velocidade;
    [SerializeField]
    private float forcaAtaque;
    [SerializeField]
    private float vida;

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
    
    
    public void setvida(float vida)
    {
        this.vida = vida;
    }

    public float Vida()
    {
        return this.vida;
    }
    
    
    void Start()
    {
        
    }

 
    void Update()
    {
        
    }
}
