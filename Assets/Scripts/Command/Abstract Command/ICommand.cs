namespace Command.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    public struct CommandData
    {
        public int ActorUnitID;
        public int TargetUnitID;
        public int ActorPlayerID;
        public int TargetPlayerID;

        public CommandData(int ActorUnitID, int TargetUnitID, int ActorPlayerID, int TargetPlayerID)
        {
            this.ActorUnitID = ActorUnitID;
            this.TargetUnitID = TargetUnitID;
            this.ActorPlayerID = ActorPlayerID;
            this.TargetPlayerID = TargetPlayerID;
        }
    }
}
