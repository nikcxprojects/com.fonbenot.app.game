using UnityEngine;

public class Player : MonoBehaviour
{
    private static bool IsLaunch { get; set; }

    public static int direction;

    private const float speed = 2.0f;
    private const float upSpeed = 10.0f;

    private void Start()
    {
        IsLaunch = false;
    }

    private void Update()
    {
        if(IsLaunch)
        {
            transform.Translate(Time.deltaTime * upSpeed * Vector2.up);
            return;
        }

        var x = transform.position.x + (direction * speed * Time.deltaTime);
        if(x < -1.772f || x > 1.772f)
        {
            return;
        }

        transform.position = new Vector2(x, transform.position.y);
    }

    public static void Launch()
    {
        IsLaunch = true;
    }
}
