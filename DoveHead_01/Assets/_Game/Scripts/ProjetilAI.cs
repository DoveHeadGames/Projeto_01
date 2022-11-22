using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilAI : MonoBehaviour
{
    public int dano;
    public float tempoDeVida;
    public float distancia;
    public LayerMask layerInimigo;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestruirProjetil", tempoDeVida); //Chamar função destruir projetil depois do tempo de vida dele;
    }

    // Update is called once per frame
    void Update()
    {
            RaycastHit2D hitInfo = Physics2D.Raycast(gameObject.transform.position, gameObject.transform.forward, distancia, layerInimigo); //iniciação da variavel intInfo vai armazenar as informações Linha de origen, direção, distancia e layerinimigo é pra bater apenas em inimigo    

            if (hitInfo.collider != null)
            {
                if (hitInfo.collider.CompareTag("Inimigo")) //projetil vai colidir apenas com esse inimigos com essa TAG Inimigo
                {
                hitInfo.collider.GetComponent<InimigoIA>().DanoAplicado(dano); //Busca o script vinculado ao inimigo o InimigoIA função publica DANOAPLICADO passando o dano do projetil, ou seja, escolhemos o dano aplicado no projetil da arma.
                }

                DestruirProjetil();

            }
    }


    void DestruirProjetil()
    {
        Destroy(gameObject);
        //som de destruir projetil
        //talvez animação ?
    }
}
