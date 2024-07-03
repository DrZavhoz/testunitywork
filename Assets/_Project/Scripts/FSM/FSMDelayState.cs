using AxGrid;
using AxGrid.FSM;
using AxGrid.Model;
using UnityEngine;

namespace FunnyBlox.fsm
{
    [State("SlotDelay")]
    public class FSMDelayState : FSMState
    {
        [Enter]
        public void EnterThis()
        {
            Debug.Log("FSMDelayState enter");
            
            Model.Set("BtnButtonStartEnable", true);
            Model?.EventManager.Invoke("OnBtnButtonStartEnableChanged", "OnItemEnable");
        }

        [Bind("OnButtonStartClick")]
        private void OnStart()
        {
            Debug.Log("OnButtonStartClick");
        }

        [Exit]
        private void ExitThis()
        {
            Model.Set("BtnButtonStartEnable", false);
            Model?.EventManager.Invoke("OnBtnButtonStartEnableChanged", "OnItemEnable");
        }
    }
}