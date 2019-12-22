using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jpg : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load<Sprite>

        ("pixiv頭貼");
    }

}
