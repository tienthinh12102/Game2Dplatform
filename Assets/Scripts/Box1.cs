using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box1 : MonoBehaviour
{
    public int Health = 100;
    public SoundsManager sound;

    private void Start()
    {

        sound = GameObject.FindGameObjectWithTag("sound").GetComponent<SoundsManager>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void Damage(int damage)
    {
        sound.Playsound("destroy");
        Health -= damage;
    }
}