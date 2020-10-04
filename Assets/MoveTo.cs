using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    public GameObject target;
    public GameObject personToReturnTo;
    bool HaveObject;
    public NavMeshAgent agent;//= GetComponent<NavMeshAgent>();
    public TextMeshProUGUI text;
    public float timeSinceLastRet=0;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastRet += Time.deltaTime;
        if (Vector3.Distance(target.transform.position, transform.position) < 1)
        {
            if(HaveObject == false && timeSinceLastRet > .7f)
            {
                text.text = (int.Parse(text.text) + 1).ToString();
                timeSinceLastRet = 0;
            }
            HaveObject = true;
            target.transform.SetParent(transform);
        }
        else
        {
            HaveObject = false;
            target.transform.SetParent(null);
        }

        if (!HaveObject)
        {
            agent.destination = target.transform.position;
            
        }
        else
        {
            agent.destination = personToReturnTo.transform.position;
        }
        
    }
}
