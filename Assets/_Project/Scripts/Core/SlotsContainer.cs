using UnityEngine;

namespace FunnyBlox
{
    public class SlotsContainer : MonoBehaviour
    {

        [SerializeField] private Transform container;
        
        public void ReorderSlots()
        {
            container.GetChild(container.childCount - 1).SetSiblingIndex(0);
        }
    }
}