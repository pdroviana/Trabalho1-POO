using UnityEngine;

public class Fada : Personagem
{
    
    public enum HabilidadesDoPersonagem
    {
        MAGIADANATUREZA, VOO, PÓDEFADA
    }

    [SerializeField]
    private HabilidadesDoPersonagem habilidade;
    
    public void setHabilidade(HabilidadesDoPersonagem habilidade)
    {
        this.habilidade = habilidade;
    }

    public HabilidadesDoPersonagem getHabilidade()
    {
        return habilidade;
    }

    public float DanoDaFada()
    {
        float buff = 0;

        switch (habilidade)
        {
            case HabilidadesDoPersonagem.VOO:
                buff = Velocidade() + 40;
                break;

            case HabilidadesDoPersonagem.MAGIADANATUREZA:
                buff = Energia() + 30;
                break;

            case HabilidadesDoPersonagem.PÓDEFADA:
                buff = ForcaAtaque() + 40;
                break;
        }

        return buff;

    }





    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
