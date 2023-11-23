using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Transactions;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    public int Score = 0;

    [SerializeField] private float speed;
    [SerializeField] private TextMeshProUGUI _text;

    private Vector3 _moveDir;

    //should be putting UI info in PlayerUI script that talks to the player
    [Header("Player UI")]
    [SerializeField] private Image healthBar;
    [SerializeField] private TextMeshProUGUI shotsFired;

    [SerializeField] private float maxHealth;
    private int shotsFiredCounter;
    private float _health;

    //shooting and reload
    [Header("Gun")]
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public GameObject muzzleFlash;
    public float bulletSpeed = 10;
    public int currentMag = 20;
    public int maxMagSize = 20;
    public int currentAmmo = 40;
    public int maxAmmoSize = 40;

    private AudioSource shot;

    [SerializeField] private EMovementState currentMoveState;
    public enum EMovementState
    {
        Idle,
        Moving,
        Jumping
    }

    //private float Health 
    //{ 
      //  get => _health;
        //set
        //{
            //_health = value;
          //  healthBar.fillAmount = _health / maxHealth;
      //  }
    //}
    
    void Start()
    {
        InputManager.init(this);
        InputManager.GameMode();

        rb = GetComponent<Rigidbody>();

        shot = GetComponent<AudioSource>();

        setState(EMovementState.Idle);

        //_text.text = "Player Score: " + Score;

        //Health = maxHealth;

    }

    void Update()
    {
        transform.position += (speed * Time.deltaTime * _moveDir);

        //part of the health bar (should be done in PlayerUI script)
        //Health -= Time.deltaTime * 5;


    }

    public void Shoot()
    {
        if (currentMag > 0)
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
            GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);
            Instantiate(muzzleFlash, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            currentMag--;
            HUDManager.instance.SetAmmoText(currentMag, maxMagSize);
        }
    }
    public void Reload()
    {
        int reloadAmmo = maxMagSize - currentMag;
        if (reloadAmmo > currentAmmo) 
        {
            reloadAmmo = currentAmmo;
        }
        currentMag += reloadAmmo;
        currentAmmo -= reloadAmmo;
        HUDManager.instance.SetAmmoText(currentMag, maxMagSize);
    }
    public void AddAmmo(int ammoAmount)
    {
        currentAmmo += ammoAmount;
        if (currentAmmo > maxAmmoSize)
        {
            currentAmmo = maxAmmoSize;
        }
    }

    public void setState(EMovementState newState)
    {
        currentMoveState = newState;
    }

    public void SetMovementDirection(Vector3 newDirection)
    {
        _moveDir = newDirection;
    }

    public void SetJump()

    {
        rb.AddForce(Vector3.up * 250);
    }

    public void AddPoints(int Points)
    {
        Score += Points;
        _text.text = "Player Score: " + Score.ToString();
    }

   

}
