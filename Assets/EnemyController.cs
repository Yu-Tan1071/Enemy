using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Animator animator;
    public GameObject effectPrefab;
    public Vector3 effectRotation;
    public Transform enemy;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            Debug.Log("Hit");

            animator.SetTrigger("damage");

        }
        if (effectPrefab != null)
        {
            Instantiate(
                effectPrefab,
                enemy.transform.position,
                Quaternion.identity);//Quaternion.identity 回転なし
        }
        Destroy(gameObject, 0.1f);
    }
}
