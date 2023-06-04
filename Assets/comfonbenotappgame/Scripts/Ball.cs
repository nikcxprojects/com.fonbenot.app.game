using UnityEngine;

public class Ball : MonoBehaviour
{
    public int Direction { get; private set; }

    private void Start()
    {
        Direction = Random.Range(0, 100) > 50 ? 1 : -1;
    }
}
