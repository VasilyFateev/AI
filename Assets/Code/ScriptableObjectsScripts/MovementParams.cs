using UnityEngine;

namespace Game
{
    [CreateAssetMenu(menuName = "ScriptableObject/Stats/Movement")]
    public class MovementParams : ScriptableObject
    {
        [SerializeField] private float moveSpeed;
        [SerializeField] private float rotateSpeed;
    }
}