using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //public Transform bulletSpawnPoint;
    //public GameObject bulletPrefab;
    //public float bulletSpeed = 10;

    //public int currentMag;
    //public int maxMagSize = 20;
    //public int currentAmmo;
    //public int maxAmmoSize = 100;

    //void Update()
    //{
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
            //if(currentMag > 0)
            //{
                //var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                //bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
                //currentMag--;
            //}
        //}

        //if (Input.GetKeyDown(KeyCode.R))
        //{
          //  Reload();
        //}
    //}

    //public void Reload()
    //{
      //  int reloadAmmo = maxMagSize - currentMag;
        //reloadAmmo = (currentAmmo - reloadAmmo) >= 0 ? reloadAmmo : currentAmmo;
        //currentMag += reloadAmmo;
        //currentMag -= reloadAmmo;
    //}

    //public void GetAmmo(int ammoAmount)
    //{
      //  currentAmmo += ammoAmount;
       // if(currentAmmo > maxAmmoSize)
        //{
          //  currentAmmo = maxAmmoSize;
       // }
    //}

}
