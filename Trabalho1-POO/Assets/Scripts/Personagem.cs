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
    private int forcaAtaque;
    private string HabilidadeEspecial;

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
    
    
    public void setforcaAtaque(int forcaAtaque)
    {
        this.forcaAtaque = forcaAtaque;
    }


    public int ForcaAtaque()
    {
        return this.forcaAtaque;
    }
    
    public void setHabilidadeEspecial(string HabilidadeEspecial)
    {
        this.HabilidadeEspecial = HabilidadeEspecial;
    }

    public string Habilidadeespecial()
    {
        return this.HabilidadeEspecial;
    }
    
    
    void Start()
    {
        
    }

 
    void Update()
    {
        
    }
}
