using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movement : MonoBehaviour
{
    public float moveSpeed;
    //public Rigidbody RD;
    public float jumpForce;
    public CharacterController controller;
    private Vector3 moveDirection;

    
    // Start is called before the first frame update
    void Start()
    {
        //RD = GetComponent<Rigidbody>();
        controller= GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {                                    //x ekseni //                      //RD.velocity.y yaptığımız için y ekseni hiç değişmeyecek
       /* RD.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, RD.velocity.y, Input.GetAxis("Vertical") * moveSpeed  );

        if(Input.GetButtonDown("Jump"))
        {
            RD.velocity = new Vector3(RD.velocity.x, jumpForce, RD.velocity.z);
            
        }
        */
         moveDirection = new Vector3 (Input.GetAxis("Horizontal") * moveSpeed, 0f,Input.GetAxis("Vertical") * moveSpeed );
          
          if(Input.GetButtonDown("Jump"))
        {
            moveDirection.y = jumpForce;
            
        }
        controller.Move(moveDirection * Time.deltaTime);
    }
   
    
}
