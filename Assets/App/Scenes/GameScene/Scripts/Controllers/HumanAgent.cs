using UnityEngine;
using UnityEngine.AI;

namespace App.Scenes.GameScene.Controllers
{
    public class HumanAgent : MonoBehaviour
    {
        public Transform Goal;

        void Start()
        {
            var agent = GetComponent<NavMeshAgent>();
            agent.destination = Goal.position;
        }

    }
}