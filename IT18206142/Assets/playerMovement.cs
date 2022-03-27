using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed;
    public float Yinc;
    public float maxHeight;
    public float center;
    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        center = 0;
        maxHeight = Yinc;
        movement = new Vector2(transform.position.x, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        //Mobile Input System
        if (Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touch_pos = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch_pos.y > 0 && transform.position.y == center)
            {
                movement = new Vector2(transform.position.x, transform.position.y + Yinc);
            }
            else if (touch_pos.y < 0 && transform.position.y == center)
            {
                movement = new Vector2(transform.position.x, transform.position.y - Yinc);
            }

            if (touch_pos.y > 0 && transform.position.y == -maxHeight || transform.position.y == maxHeight)
            {
                movement = new Vector2(transform.position.x, center);
            }
        }

        //Desktop Input System
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y == center)
        {
            movement = new Vector2(transform.position.x, transform.position.y + Yinc);
        }
        else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y == center)
        {
            movement = new Vector2(transform.position.x, transform.position.y - Yinc);
        }

        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y == -maxHeight || Input.GetKey(KeyCode.DownArrow) && transform.position.y == maxHeight)
        {
            movement = new Vector2(transform.position.x, center);
        }
    }

    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, movement, speed * Time.fixedDeltaTime);

        Vector3 clampPosition = transform.position;
        clampPosition.y = Mathf.Clamp(clampPosition.y, -maxHeight, maxHeight);
        transform.position = clampPosition;
    }
}
