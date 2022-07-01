using UnityEngine;

namespace Game
{
    [CreateAssetMenu(menuName = "ScriptableObject/Stats/PatrolAI")]
    public class ParamsPatrolAI : ScriptableObject
    {
        [SerializeField] private GameObject[] patrolPoints;
        [SerializeField] private float timePlayerDetection;
    }
}