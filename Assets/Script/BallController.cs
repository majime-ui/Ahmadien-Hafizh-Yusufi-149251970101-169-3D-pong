using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    public Vector3 resetPosition;
    private Rigidbody rig;
    public float maxSpeed = 20.0f;

    public Collider gawang1,gawang2,gawang3,gawang4;
    public SpawnerController manager;
    public ScoreManager managerScore;
    
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Paddle" || other.gameObject.tag == "BallSpawner")
        {
            if (rig.velocity.magnitude < maxSpeed)
            {
                rig.velocity = rig.velocity.normalized * maxSpeed;
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other == gawang1)
        {
            managerScore.AddP1Score(1);
            manager.RemoveBall(gameObject);
        }
        if (other == gawang2)
        {
            managerScore.AddP2Score(1);
            manager.RemoveBall(gameObject);
        }
        if (other == gawang3)
        {
            managerScore.AddP3Score(1);
            manager.RemoveBall(gameObject);
        }
        if (other == gawang4)
        {
            managerScore.AddP4Score(1);
            manager.RemoveBall(gameObject);
        }
    }
}
