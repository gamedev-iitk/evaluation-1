  using UnityEngine;
  using System.Collections;
      
      public class Jump : MonoBehaviour {
      
          public Vector3 jump;
          public float jumpForce = 2.0f;
      
          public bool isGrounded;
          Rigidbody rb;
          void Start(){
              rb = GetComponent<Rigidbody>();
              jump = new Vector3(0.0f, 2.0f, 0.0f);
          }
      
          void OnCollisionStay()
          {
              isGrounded = true;
          }
          void OnCollisionExit(){
            isGrounded = false;
      }
          void Update(){
              if(Input.GetKey("w") && isGrounded){
      
                  rb.AddForce(jump * jumpForce, ForceMode.Impulse);
                  isGrounded = false;
              }
          }
      }
