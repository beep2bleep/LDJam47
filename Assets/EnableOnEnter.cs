using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableOnEnter : MonoBehaviour
{
    public List<GameObject> objectsToOnlyAllowActiveInTrigger;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(player.)
    }

    //When the Primitive collides with the walls, it will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "MainCamera")
        {
            foreach(var obj in objectsToOnlyAllowActiveInTrigger)
            {
                obj.active = true;
                obj.SetActive(true);
            }
        }
    }

    //When the Primitive exits the collision, it will change Color
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            foreach (var obj in objectsToOnlyAllowActiveInTrigger)
            {
                obj.SetActive(false);
            }
        }
    }
}
