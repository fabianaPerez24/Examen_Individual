using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public GameObject bulletPrefab;
    public GameObject bulletPrefab2;
    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj = Instantiate(bulletPrefab);
            obj.transform.position= transform.position;
            obj.GetComponent<Bullet>().SetDirection(gameObject.transform.up);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            GameObject obj = Instantiate(bulletPrefab2);
            obj.transform.position = transform.position;
            obj.GetComponent<Bullet>().SetDirection(gameObject.transform.up);
        }
    }
}
