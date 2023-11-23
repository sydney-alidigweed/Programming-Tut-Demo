using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Chicken : MonoBehaviour
{
    float _timer = 0.0f;
    float waitTime = 3.0f;
    [SerializeField] GameObject _egg;
    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer > waitTime)
        {
            _timer = _timer - waitTime;
            layEgg();
            transform.Translate(Random.Range(-1, 1), 0, Random.Range(-1, 1));
        }
    }

    void layEgg()
    {
        Vector3 offset = new Vector3(1, 0 ,0) + transform.position;
        Debug.Log("Laid");
        Instantiate(_egg, offset, Quaternion.identity);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Egg")
        {
            Destroy(_egg);
        }
    }



}


