using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWhiteLife : MonoBehaviour
{

    // Update is called once per frame
    public void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("BalaBlanca"))
        {
            Destroy(gameObject,3f);
        }
    }
}
