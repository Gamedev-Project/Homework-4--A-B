using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    //[SerializeField] string wallTag;
    [SerializeField] string lives;
    
    float live=0f;
    private Renderer[] Component;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            if(lives=="Player"){
                live++;
                if(live==3f){
                    Destroy(this.gameObject);
                }
                else{
                    Component= gameObject.GetComponentsInChildren<Renderer>();
                    switch(live){
                    case 0:
                        Component[2].enabled=false;
                        break;
                    case 1:
                        Component[3].enabled=false;
                        break;
                    case 2:
                        Component[4].enabled=false;
                        break;
                }
                }
                Destroy(other.gameObject);
            }
            else{
                Destroy(this.gameObject);  //me
                Destroy(other.gameObject); //leyzer
            }    
        }
        if (other.tag == "DownWall" && this.tag=="Enemy") {
        //    Debug.Log("i am "+this.tag +"Start CollisionLogger on "+other.tag);
            Destroy(this.gameObject);
        }
    }
}