using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPack : MonoBehaviour
{
    [SerializeField] private int ammoAmount = 20;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {

            collision.transform.GetComponent<Player>().AddAmmo(ammoAmount);
            Destroy(gameObject);
            

        }
    }
}
