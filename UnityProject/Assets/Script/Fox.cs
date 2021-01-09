using UnityEngine;

public class Fox : MonoBehaviour
{
    [Header("移速速度"), Range(0.0f, 60.0f)]
    public float speed = 20.0f;
    public Rigidbody2D rig;
    public SpriteRenderer spr;
    private float hr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move() {
        hr = Input.GetAxisRaw("Horizontal");
        if (hr > 0)
            spr.flipX = false; // face right side
        else if (hr < 0)
            spr.flipX = true; // face left side

        rig.AddForce(new Vector2(hr*speed,0.0f));
    }
}
