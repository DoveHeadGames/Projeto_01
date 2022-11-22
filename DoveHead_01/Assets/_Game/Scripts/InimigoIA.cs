using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoIA : MonoBehaviour
{
   // private Animator animator;

    public int energia; //Vida do personagem.


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (energia <= 0)
        {
           // animator.SetTrigger("death");
            Invoke("DestroyBody", .5F);
        }
    }

    public void DanoAplicado(int dano) //variavel publica para acessarmos de outro script.
    {
        energia -= dano;
    }
    private void DestruirProjetil()
    {
        Destroy(gameObject);
    }



}
