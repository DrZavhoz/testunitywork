using UnityEngine;

namespace FunnyBlox.Data
{
    [CreateAssetMenu(fileName = "Settings", menuName = "Data/Settings", order = 52)]     
    public class Settings : ScriptableObject
    {
        public float SpeedScrollingSlot = 1f;
    }
}