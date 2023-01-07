using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeFlor : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player")){
            Destroy(this.gameObject);
        }
        //if(collision.gameObject.tag == "FakeFlor"){
          //  Debug.Log("tralal");
        //}
        Debug.Log("traal");
    }

}
