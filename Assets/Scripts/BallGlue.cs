using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGlue: MonoBehaviour
{
    public int objCounter = 0;
    public float scale = 1;
    float dScale = -1;

    void OnCollisionEnter(Collision col)
    {
            if (col.gameObject.tag == "SceneObj")
            {
                objCounter = col.contactCount + objCounter;
                scale += objCounter * dScale;
                gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x + dScale, gameObject.transform.localScale.y + dScale, gameObject.transform.localScale.z + dScale);
            }


    }
    
}



  /* 
         * I would love to have a jump, but it doesn´t look to well when the plyer does it, so for now is gone 
        else if ((onEarth == true) && (Input.GetKeyDown(KeyCode.Space)))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 12, 0), ForceMode.Impulse);
            //oneJump=false;
        }*/
    
    /*
    private void Collisionobj(Collision collision)
    {
        if (collision.transform.tag == "onEarth")
        {s
            onEarth = true;
        }
        //I want to change the tag for glued in order to take it 
        else if (collision.transform.tag == "Glued")
        {
            attachedObjects++;
            scale += attachedObjects * dScale;
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x + dScale, gameObject.transform.localScale.y + dScale, gameObject.transform.localScale.z + dScale);
        }
     
        
    }*/