using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enevironmentMovement : MonoBehaviour
{
    public int speed;
    public float xT_Pos, yT_Pos, xN_Pos, yN_Pos;
    Vector3 TargetPos, NewPos;

    // Start is called before the first frame update
    void Start()
    {
        TargetPos = new Vector3(xT_Pos, yT_Pos, 0f);
        NewPos = new Vector3(xN_Pos, yN_Pos, 0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, TargetPos, speed * Time.fixedDeltaTime);

        if(transform.position == TargetPos)
        {
            transform.position = NewPos;
        }
    }
}
