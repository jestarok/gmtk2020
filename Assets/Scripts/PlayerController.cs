using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    //misc components
    public float hp = 0;
    private Rigidbody2D rb2d;
    private PlayerControll controls;
    private SpriteRenderer sprite;
    private float colorChange = 0.1f;

    //controls
    //private List<float> inputs;
    private float[] inputs = new float[6];
    Vector2 direction = new Vector2();

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
        controls.Gameplay.Button1.performed += ctx => inputs[0] = (ctx.ReadValue<float>());
        controls.Gameplay.Button1.canceled += ctx => inputs[0] = 0f;
        controls.Gameplay.Button2.performed += ctx => inputs[1] = (ctx.ReadValue<float>());
        controls.Gameplay.Button2.canceled += ctx => inputs[1] = 0f;
        controls.Gameplay.Button3.performed += ctx => inputs[2] = (ctx.ReadValue<float>());
        controls.Gameplay.Button3.canceled += ctx => inputs[2] = 0f;
        controls.Gameplay.Button4.performed += ctx => inputs[3] = (ctx.ReadValue<float>());
        controls.Gameplay.Button4.canceled += ctx => inputs[3] = 0f;
        controls.Gameplay.Button5.performed += ctx => inputs[4] = (ctx.ReadValue<float>());
        controls.Gameplay.Button5.canceled += ctx => inputs[4] = 0f;
        controls.Gameplay.Button6.performed += ctx => inputs[5] = (ctx.ReadValue<float>());
        controls.Gameplay.Button6.canceled += ctx => inputs[5] = 0f;

        controls.Gameplay.move.canceled += ctx => move = Vector2.zero;
        
        rb2d = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();

    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Gamepad.current.name);   
        controls.Gameplay.Button5.canceled += ctx => Shoot();
        float h = inputs[2] + -1 * inputs[3];
        float v = inputs[0] + -1 * inputs[1];

        direction = new Vector2(transform.position.x + h, transform.position.y + v);

        Debug.Log(direction);
         if(h > 0.1f) {
            firePoint.transform.localPosition = new Vector3(0.65f, firePoint.transform.localPosition.y, firePoint.transform.localPosition.z);
        }else if (h < -0.1f)
        {
            firePoint.transform.localPosition = new Vector3(-0.65f, firePoint.transform.localPosition.y, firePoint.transform.position.z);
        }
        if (invincible) {
            if (Time.time > colorChange) {
                colorChange = Time.time + 0.1f;
                sprite.color = sprite.color * -1;
            }
            if( Time.time - ItimeStart > Itime)
            {
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
        transform.position = Vector2.MoveTowards(transform.position, direction, speed * Time.deltaTime);

        //rb2d.AddForce(move * speed);
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
            Vector2 bulletDirection = new Vector2((inputs[2] + -1 * inputs[3]), (inputs[0] + -1 * inputs[1]));

            bulletObj.GetComponent<bulletController>().direction = bulletDirection == Vector2.zero ? Vector2.right : bulletDirection;
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
