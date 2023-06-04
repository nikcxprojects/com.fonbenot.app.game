using System;
using UnityEngine;

public class Box : MonoBehaviour
{
    public static Action<Ball> OnCollisionAction { get; set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        OnCollisionAction?.Invoke(collision.GetComponent<Ball>());
        Destroy(collision.gameObject);
    }
}
