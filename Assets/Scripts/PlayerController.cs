using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    //misc components
    public GameObject spotLight;
    public float hp = 0;
    private Animator anim;
    private GameObject g;
    private Rigidbody2D rb2d;
    private PlayerControll controls;
    private SpriteRenderer sprite;
    private float colorChange = 0.1f;
    
    //movement
    public float speed = 4f;
    private Vector2 move;
    private Vector2 movelight;

    //shooting
    public GameObject shuriken;
    public GameObject firePoint;
    private float lastFireTime = 0f;
    private float bulletInterval = 0.5f;

    //invincibility frames
    private bool invincible;
    public float Itime = 2;
    private float ItimeStart = 0f;

    // Start is called before the first frame 
    private void Awake()
    {
        controls = new PlayerControll();

        controls.Gameplay.move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.move.canceled += ctx => move = Vector2.zero;

        controls.Gameplay.moveLight.performed += ctx => movelight = ctx.ReadValue<Vector2>();
        controls.Gameplay.moveLight.canceled += ctx => movelight = Vector2.zero;
        rb2d = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();

    }

    void Start()
    {
        anim = GetComponent<Animator>();
        g = Instantiate(spotLight, transform.position, Quaternion.identity);
        g.transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Gamepad.current.name);   
        controls.Gameplay.shoot.canceled += ctx => Shoot();

        anim.SetFloat("Xspeed", move.x);
        anim.SetFloat("Yspeed", move.y);
        anim.SetFloat("Speed", move.magnitude);

        if (invincible) {
            if (Time.time > colorChange) {
                colorChange = Time.time + 0.1f;
                sprite.color = sprite.color * -1;
            }
            if( Time.time - ItimeStart > Itime)
            {
                Debug.Log("vincible");
                invincible = false;
                sprite.color = Color.white;
            }
        }
    }

    private void FixedUpdate()
    {
        Vector2 fixedVelocity = rb2d.velocity;

        if (move.magnitude == 0)
        {
            fixedVelocity = rb2d.velocity * 0.85f;
        }
        Mathf.Clamp(fixedVelocity.x, 0f, speed);
        Mathf.Clamp(fixedVelocity.y, 0f, speed);
        rb2d.AddForce(move * speed);
        g.transform.Translate(movelight * 0.05f, Space.World);
        rb2d.velocity = fixedVelocity;
    }

    void Shoot()
    {
        float timeSinceLastShot = Time.time - lastFireTime;
        //bullets = GameObject.FindGameObjectsWithTag("PlayerBullet").Length;

        //if (bullets < bulletAmount && timeSinceLastShot > bulletInterval)
          if (timeSinceLastShot > bulletInterval)
            {
            GameObject bulletObj = Instantiate(shuriken, firePoint.transform.position, firePoint.transform.rotation);
            //bulletObj.tag = "PlayerBullet";
            lastFireTime = Time.time;
        }
    }

    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    private void Disable()
    {
        controls.Gameplay.Disable();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy" && !invincible) {
            Debug.Log("ouch");
            hp -= 20f;
            ItimeStart = Time.time;
            invincible = true;
            sprite.color = Color.red;
        }

        if (hp == 0) {
            Destroy(gameObject);
        }
    }
}
