using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class MovimentoPlayer : MonoBehaviour
{

    public float velocidadePlayer;
    public float forcaDoPuloPlayer;
    private Rigidbody2D rigidBody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
        
       
    }

    void Movimento()
    {
        Vector3 movimento = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        transform.position += movimento * Time.deltaTime * velocidadePlayer;

    }

    void Pulo()
    {
        if(Input.GetButtonDown("Jump"))
        {
 
           rigidBody2D.AddForce(transform.up * forcaDoPuloPlayer);
       
        
        }

    }
    


}
