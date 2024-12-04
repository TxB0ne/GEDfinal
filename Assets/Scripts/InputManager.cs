using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public GameObject Zap;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        

        if (Input.GetKeyDown(KeyCode.A))
        {
            var bullet = Instantiate(Zap);
            Debug.Log("Zap");

            Destroy(bullet, 3.0f);
        }
    }
}
