using System;
using UnityEngine;
using UnityEngine.UI;

public class Drive : MonoBehaviour
{
    public float speed = 10.0f;
    public Slider healthBar;

    void Update()
    {
        float translation = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        transform.Translate(translation, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject b = Pool.singleton.Get("Bullet");
            if (b!=null)
            {
                b.transform.position = transform.position;
                b.SetActive(true);
            }
        }

        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position)+ new Vector3(0,-210,0);
        healthBar.transform.position = screenPos;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag=="Asteroid")
        {
            other.gameObject.SetActive(false);
            healthBar.value--;
        }
    }
}