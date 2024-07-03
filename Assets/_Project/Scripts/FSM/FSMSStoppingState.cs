using AxGrid.FSM;
using UnityEngine;

namespace FunnyBlox.fsm
{
    [State("SlotStopping")]
    public class FSMSStoppingState : FSMState
    {
        [Enter]
        public void EnterThis()
        {
            Debug.Log("FSMSStoppingState enter");
            Model?.EventManager.Invoke("StopScrollSlot");
            
            Model.Set("BtnButtonStopEnable", false);
            Model?.EventManager.Invoke("OnBtnButtonStopEnableChanged","OnItemEnable");
        }
        
        [One(1f)]
        private void ChangeToDelay()
        {
            Parent.Change("SlotDelay");
        }
    }
}