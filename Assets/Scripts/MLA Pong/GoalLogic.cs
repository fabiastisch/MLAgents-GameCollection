using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalLogic : MonoBehaviour
{

    [SerializeField] GameObject relatedAgent;

    public void triggered() {
        relatedAgent.GetComponent<PongLife>().isHitted();
        relatedAgent.GetComponent<PongAgent>().AddExternalReward(-1f);
    }

}