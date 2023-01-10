using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public string state;
    public MapSpawner map;
    public Movement move;
    public Score score;
    public SpriteRenderer sprite;
    public ParticleSystem ps;
    public MusicManager music;
    public Menu menu;
    void Start()
    {
        state = "Idle";
        move.resetGravity(0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") || collision.gameObject.CompareTag("Hole"))
        {
            Die();
        }
    }
    public void Die()
    {
        state = "Dead";
        move.resetGravity(0);
        score.End();
        music.PlayDie();
        sprite.enabled = false;
        ps.Play();
        StartCoroutine(Delay());
    }
    public void Respawn()
    {
        menu.ChangeMenu(true);
        transform.position = new Vector3(-8.09f, 1.23f, 0);
    }
    public void StartGame()
    {
        state = "Playing";
        move.resetGravity(3);
        map.clearStorage();
        sprite.enabled = true;
        menu.ChangeMenu(false);
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1f);
        Respawn();
    }
}
