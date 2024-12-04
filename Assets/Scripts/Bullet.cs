using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject Duck;
    int points = 0;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        points = points + 1;
        Debug.Log("Points:" + points);
    }
}
