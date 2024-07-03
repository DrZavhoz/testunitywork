using AxGrid.Base;
using AxGrid.Model;
using DG.Tweening;
using FunnyBlox.Data;
using UnityEngine;

namespace FunnyBlox
{
    public class SlotScroller : MonoBehaviourExtBind
    {
        [SerializeField] private Settings settings;
        [SerializeField] private SlotsContainer slotsContainer;
        [SerializeField] private Transform moveContainer;
        [SerializeField] private ParticleSystem onSelectSlotParticles;

        private bool isRun;
        
        [Bind("RunScrollSlot")]
        private void RunScroll()
        {
            onSelectSlotParticles.Stop();
            isRun = true;
            moveContainer.DOLocalMoveY(-250f, settings.SpeedScrollingSlot)
                .SetEase(Ease.InCubic)
                .OnComplete(MoveScroller);
        }

        [Bind("StopScrollSlot")]
        private void StopScroll() => isRun = false;

        private void MoveScroller()
        {
            moveContainer.localPosition = new Vector3(0f, 250f, 0f);
            slotsContainer.ReorderSlots();
            moveContainer.DOLocalMoveY(-250f, settings.SpeedScrollingSlot)
                .SetEase(Ease.Linear)
                .OnComplete(Repeat);
        }

        private void Repeat()
        {
            if (isRun)
                MoveScroller();
            else
                StopScroller();
        }

        private void StopScroller()
        {
            moveContainer.localPosition = new Vector3(0f, 250f, 0f);
            slotsContainer.ReorderSlots();
            moveContainer.DOLocalMoveY(0f, settings.SpeedScrollingSlot * 6f)
                .SetEase(Ease.OutElastic)
                .OnComplete(onSelectSlotParticles.Play);
        }
        
    }
}