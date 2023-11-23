using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Egg : MonoBehaviour
{
    float _timer = 0.0f;
    private float waitTime;
    [SerializeField] GameObject _chicken;

    void Start()
    {
        waitTime = Random.Range(3f, 5f);
    }
    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer > waitTime)
        {
            _timer = _timer - waitTime;
            hatch();
        }
    }
    void hatch()
    {
        Debug.Log("Hatched");
        Instantiate(_chicken, transform.position, transform.rotation);

        Destroy(gameObject);
    }


}
