namespace Command.Command
{
    public interface ICommand
    {
        void Execute();
    }

    public struct CommandData
    {
        public int ActionUnitID;
        public int TargetUnitID;
        public int ActorPlayerID;
        public int TargetPlayerID;

        public CommandData(int ActionUnitID, int TargetUnitID, int ActorPlayerID, int TargetPlayerID)
        {
            this.ActionUnitID = ActionUnitID;
            this.TargetUnitID = TargetUnitID;
            this.ActorPlayerID = ActorPlayerID;
            this.TargetPlayerID = TargetPlayerID;
        }
    }
}

