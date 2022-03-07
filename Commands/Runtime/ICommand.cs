namespace Skipper.Commands.Runtime
{
    /// <summary>
    /// Sync <see cref="ICommand"/> To Run On Thread...
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Execute This <see cref="ICommand"/>....
        /// </summary>
        void Execute();
    }
}