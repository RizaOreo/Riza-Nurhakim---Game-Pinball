using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public Color color;
    public float score;

    public AudioManager audioManager;
    public VFXManager vfxManager;
    public ScoreManager scoreManager;

    private Renderer rend;
    private Animator anim;

    public void Start()
    {
        rend = GetComponent<Renderer>();
        anim = GetComponent<Animator>();

        rend.material.color = color;
    }
    private void OnCollisionEnter (Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            anim.SetTrigger("Hit");

            audioManager.PlaySFX(collision.transform.position);

            vfxManager.PlayVFX(collision.transform.position);

            scoreManager.AddScore(score);
        }
    }
}