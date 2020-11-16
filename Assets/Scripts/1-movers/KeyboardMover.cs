using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component moves its object when the player clicks the arrow keys.
 */
public class KeyboardMover: MonoBehaviour {
    [Tooltip("Speed of movement, in meters per second")]
    [SerializeField] float speed = 1f;

    void Update() {
float horizontal = Input.GetAxis("Horizontal"); // +1 if right arrow is pushed, -1 if left arrow is pushed, 0 otherwise
        float vertical = Input.GetAxis("Vertical");     // +1 if up arrow is pushed, -1 if down arrow is pushed, 0 otherwise
        Vector3 movementVector = new Vector3(horizontal, vertical, 0).normalized;// * speed * Time.deltaTime;

        
        Vector3 targetMovePosition = transform.position + movementVector * speed * Time.deltaTime ;

        RaycastHit2D raycastHit= Physics2D.Raycast(transform.position,movementVector, speed * Time.deltaTime,1 << 8);
        if(raycastHit.collider == null){
            //can move
            transform.position = targetMovePosition;
        }
        else
        {
            //cannot move (hit)
            Vector3 testMoveDir = new Vector3(movementVector.x,0f).normalized;
            targetMovePosition = transform.position + testMoveDir * speed * Time.deltaTime ;
            raycastHit= Physics2D.Raycast(transform.position,testMoveDir, speed * Time.deltaTime,1 << 8);
            if(raycastHit.collider == null){
            //can move horizontly
            transform.position = targetMovePosition;
            }
            else
            {  
                testMoveDir = new Vector3(0f , movementVector.y).normalized;
               targetMovePosition = transform.position + testMoveDir * speed * Time.deltaTime ;
               raycastHit= Physics2D.Raycast(transform.position,testMoveDir, speed * Time.deltaTime,1 << 8);
               if(raycastHit.collider == null){
               //can move vertically    
              transform.position = targetMovePosition;
              }
               else
               {  
               }
            }
            
        }
        }
}