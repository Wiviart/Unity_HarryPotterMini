using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Scale : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        BgScale();
    }

    void BgScale(){
        SpriteRenderer bg = GetComponent<SpriteRenderer>();
        float maxScale = 2f;

        float bg_x = bg.bounds.size.x;
        float bg_y = bg.bounds.size.y;

        float screen_y = Screen.height;
        float screen_x = Screen.width;

        float x = screen_x/bg_x;
        float y = screen_y/bg_y;

        float rate = Mathf.Min (Mathf.Max(x,y),maxScale);

        transform.localScale = new Vector3(rate,rate,1);
    }
}
