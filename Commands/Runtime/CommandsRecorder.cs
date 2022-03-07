using System;
using System.Collections.Generic;

namespace Skipper.Commands.Runtime
{
    /// <summary>
    /// Base Class For Basic <see cref="ICommand"/>'s Recorder & It's Default Operations...
    /// </summary>
    /// <typeparam name="TCommand"></typeparam>
    public abstract class CommandsRecorder<TCommand> : ICommandsRecorder<TCommand> where TCommand : ICommand
    {
        private readonly Stack<TCommand> _commandsStack = new Stack<TCommand>();
        public Action OnRewind { get; set; } = null;
        public Action OnExecute { get; set; } = null;
        public virtual int Count => _commandsStack.Count;

        public virtual void Execute(TCommand command)
        {
            _commandsStack.Push(command);
            command.Execute();
            if (OnExecute != null) OnExecute();
        }

        public virtual bool Rewind()
        {
            if (Count == 0) return false;
            var command = _commandsStack.Pop();
            command.Execute();
            if (OnRewind != null) OnRewind();
            return true;
        }

        public void Reset()
        {
            OnRewind = null;
            OnExecute = null;
            _commandsStack.Clear();
        }
    }
}