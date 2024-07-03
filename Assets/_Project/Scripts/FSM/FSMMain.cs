using AxGrid;
using AxGrid.Base;
using AxGrid.FSM;
using AxGrid.Model;
using UnityEngine;

namespace FunnyBlox.fsm
{
    public class FSMMain : MonoBehaviourExtBind
    {
        [OnStart]
        private void CreateFSM()
        {
            Settings.Fsm = new FSM();
            Settings.Fsm.Add(new FSMInitState());
            Settings.Fsm.Add(new FSMDelayState());
            Settings.Fsm.Add(new FSMScrollingState());
            Settings.Fsm.Add(new FSMSStoppingState());
            
            Settings.Fsm.Start("SlotInit");
        }
        
        [OnUpdate]
        private void UpdateThis()
        {
            Settings.Fsm.Update(Time.deltaTime);
        }

        [Bind("OnButtonStartClick")]
        private void OnStartScroll()
        {
            Settings.Fsm.Change("SlotScrolling");
        }
        
        [Bind("OnButtonStopClick")]
        private void OnStopScroll()
        {
            Settings.Fsm.Change("SlotStopping");
        }
        
        
    }
}