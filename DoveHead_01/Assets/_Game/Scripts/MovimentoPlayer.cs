using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class MovimentoPlayer : MonoBehaviour
{

    public float velocidadePlayer;
    public float forcaDoPuloPlayer;
    private Rigidbody2D playerRb;
    
    //Controle de animaca
    //private bool estaAtirando = false;

    //Quanto tempo passou desde o ultimo tiro
   // private float tempoUltimoTiro;

    //Cano da arma, onde vai disparar o projetil
    public Transform olhoLaser;
    // public Transform armaAndando;

    //Objeto do projetil

    public GameObject projetilPrefab;

    //valocidade do projetil
    public float velocidadeProjetil;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
        Atirar();
       
    }

    void Movimento()
    {
        Vector3 movimento = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        transform.position += movimento * Time.deltaTime * velocidadePlayer;

    }

    //void Pulo()
    //{
     //   if(Input.GetButtonDown("Jump"))
     //   {

      //      playerRb.AddForce(transform.up * forcaDoPuloPlayer);
      // 
        
      //  }

    //}
    
    void Atirar()
    {
        if (Input.GetMouseButtonDown(0)) // Clicar o o botão Esquerdo do Mouse
        {
            Transform shotPoint;
            shotPoint = olhoLaser;

             

            //if (Mathf.Abs(playerRb.velocity.x) > 0)
            //    shotPoint = armaAndando;
            //else
            //    shotPoint = armaParado;

            GameObject laserVermelho = Instantiate(projetilPrefab, shotPoint.position, transform.rotation);

            //estaAtirando = true;
            //tempoUltimoTiro = .7f;

            //if (facingRight)
            laserVermelho.GetComponent<Rigidbody2D>().velocity = new Vector2(velocidadeProjetil, 0);
           // else
            //    projectile.GetComponent<Rigidbody2D>().velocity = new Vector2(-velocidadeProjetil, 0);

        }

        //tempoUltimoTiro -= Time.deltaTime;

       // if (tempoUltimoTiro <= 0 ) estaAtirando = false;
        
    }

}


