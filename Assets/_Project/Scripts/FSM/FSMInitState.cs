using AxGrid.FSM;

namespace FunnyBlox.fsm
{
    [State("SlotInit")]
    public class FSMInitState : FSMState
    {
        [Enter]
        public void EnterThis()
        {
            Parent.Change("SlotDelay");
        }
    }
}