using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUDManager : MonoBehaviour
{
    public static HUDManager instance;
    [SerializeField] private TextMeshProUGUI AmmoCounter;

    public void SetAmmoText(int amount, int maxMagSize)
    {
        AmmoCounter.text = amount + " / " + maxMagSize;
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}
