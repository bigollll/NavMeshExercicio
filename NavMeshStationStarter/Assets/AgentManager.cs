using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    GameObject[] agents;
    
    void Start () 
    {
        agents= GameObject.FindGameObjectsWithTag("ai"); //verifica a tag ai para o agent andar
        
    }
    void Update () 
    {
        if(Input.GetMouseButtonDown(0)) //verifica o click no mapa para realizar o deslocamento
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                foreach(GameObject a in agents)
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
            }
        }
    }
}
