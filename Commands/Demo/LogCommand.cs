using Skipper.Commands.Runtime;
using UnityEngine;

namespace Skipper.Commands.Demo
{
    public class LogCommand : ICommand
    {
        private readonly string _log;
        public LogCommand(string log) => _log = log;
        public void Execute() => Debug.Log(_log);
    }
}