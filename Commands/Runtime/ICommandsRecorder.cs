using System;

namespace Skipper.Commands.Runtime
{
    /// <summary>
    /// Contract For The Any Commands Stack's Concrete...
    /// </summary>
    /// <typeparam name="TCommand">Current Phase Of <see cref="ICommand"/></typeparam>
    public interface ICommandsRecorder<in TCommand> where TCommand : ICommand
    {
        /// <summary>
        /// CallBack For <see cref="Execute"/>'s Operation..
        /// </summary>
        Action OnExecute { get; set; }

        /// <summary>
        /// CallBack For <see cref="Rewind"/>'s Operation..
        /// </summary>
        Action OnRewind { get; set; }

        /// <summary>
        /// Current Command's Stack Count...
        /// </summary>
        int Count { get; }

        /// <summary>
        /// <see cref="Execute"/> Given <see cref="ICommand"/> & Push It's Record On Stack...
        /// </summary>
        /// <param name="command"><see cref="TCommand"/>'s Instance..</param>
        void Execute(TCommand command);

        /// <summary>
        /// <see cref="Rewind"/> will Pop & <see cref="Execute"/> The <see cref="ICommand"/>
        /// </summary>
        bool Rewind();

        /// <summary>
        /// <see cref="Reset"/> this Recorder & Clean Everything....
        /// </summary>
        void Reset();
    }
}