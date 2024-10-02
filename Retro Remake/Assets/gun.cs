using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public GameObject bulletPrefab2; 
    public GameObject bulletPrefab3;
    public float bulletSpeed = 10;
    public float distance = 1;

    float elaspedTime;
    public float delayTime = 0.1f;
      

    void Update()
    {

        elaspedTime += Time.deltaTime;

        //tank shell
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
        //Need cooldown check<<
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;

            bullet.transform.position = transform.position + transform.forward * distance;
            //need cooldown timer<<
        }
        //Machine gun
        if (Input.GetKey(KeyCode.Mouse1))
        {
           /* GetComponent<AudioSource>().Play();
            if (elaspedTime < delayTime) return;
            elaspedTime = 0;*/

            var Bullet2 = Instantiate(bulletPrefab2, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            Bullet2.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;

            Bullet2.transform.position = transform.position + transform.forward * distance;
            //Need delay<<
           
           
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            /* GetComponent<AudioSource>().Play();
             if (elaspedTime < delayTime) return;
             elaspedTime = 0;*/

            var Bullet3 = Instantiate(bulletPrefab3, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            Bullet3.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;

            Bullet3.transform.position = transform.position + transform.forward * distance;
            //Need delay<<


        }
    }
}