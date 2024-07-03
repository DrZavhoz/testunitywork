using AxGrid.FSM;
using UnityEngine;

namespace FunnyBlox.fsm
{
    [State("SlotScrolling")]
    public class FSMScrollingState : FSMState
    {
        [Enter]
        public void EnterThis()
        {
            Debug.Log("FSMScrollingState enter");
            Model?.EventManager.Invoke("RunScrollSlot");
        }
        
        [One(3f)]
        private void EnableStopButton()
        {
            Model.Set("BtnButtonStopEnable", true);
            Model?.EventManager.Invoke("OnBtnButtonStopEnableChanged","OnItemEnable");
        }
    }
}