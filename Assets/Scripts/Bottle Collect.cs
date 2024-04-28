using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleCollect : MonoBehaviour
{
    private void OnCollisionEnter (Collision collision)
    {
        //if(Input.GetKeyDown(KeyCode.E))
        //{
            Destroy(this.gameObject);
        //}
    }
}
