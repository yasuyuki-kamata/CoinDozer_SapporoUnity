using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScore : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        ScoreManager.Score += 10;
    }
}
