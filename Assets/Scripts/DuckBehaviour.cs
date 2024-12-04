using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class DuckBehaviour : MonoBehaviour
{
    public GameObject Duck;

    

    void Start()
    {

    }


    void FixedUpdate()
    {
        Spawn();
    }

    void Spawn()
    {
        var Ducks = Instantiate(Duck);
        Destroy(Ducks, 5.0f);
    }

    
}
