using System;

namespace task_DEV2._1
{
    class TaskDoneEventArgs : EventArgs
    {
        public string Text { get; private set; }
        public string Data { get; private set; }
        public string SecondData { get; private set; }
        public TaskDoneEventArgs(string dataText, string data)
        {
            Data = data;
            Text = dataText;
        }
        public TaskDoneEventArgs(string dataText, string data, string secondData)
        {
            Data = data;
            SecondData = secondData;
            Text = dataText;
        }
    }
}
