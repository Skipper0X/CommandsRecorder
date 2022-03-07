using UnityEngine;

namespace Skipper.Commands.Demo
{
    public class MonoRunCommand : MonoBehaviour
    {
        private readonly LogCommandRecorder _logCommandRecorder = new LogCommandRecorder();


        [ContextMenu("Execute")]
        private void Execute()
        {
            var logCommandOne = new LogCommand("1");
            _logCommandRecorder.Execute(logCommandOne);

            var logCommandTwo = new LogCommand("2");
            _logCommandRecorder.Execute(logCommandTwo);

            var logCommandThree = new LogCommand("3");
            _logCommandRecorder.Execute(logCommandThree);

            var logCommandRewinding = new LogCommand("Rewinding Commands...");
            _logCommandRecorder.Execute(logCommandRewinding);

            while (_logCommandRecorder.Count > 0) _logCommandRecorder.Rewind();
        }
    }
}