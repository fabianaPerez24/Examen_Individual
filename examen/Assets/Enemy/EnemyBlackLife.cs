using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBlackLife : MonoBehaviour
{

    // Update is called once per frame
    public void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("BalaNegra"))
        {
            Destroy(gameObject);
        }
    }
}
