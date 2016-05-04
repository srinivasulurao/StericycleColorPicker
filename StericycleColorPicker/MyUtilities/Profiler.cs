namespace MyUtilities
{
    using System;
    using System.Diagnostics;

    public class Profiler : IDisposable
    {
        private Stopwatch _stopWatch;

        public Profiler() : this("Untitled")
        {
        }

        public Profiler(string title)
        {
            Debug.WriteLine(title);
            this._stopWatch = new Stopwatch();
            this._stopWatch.Start();
        }

        public void Dispose()
        {
            this._stopWatch.Stop();
            Debug.WriteLine("  " + this._stopWatch.ElapsedMilliseconds + " ms - Total");
            this._stopWatch = null;
        }

        public void Print(string comment)
        {
            Debug.WriteLine(string.Concat(new object[] { "  ", this._stopWatch.ElapsedMilliseconds, " ms - ", comment }));
        }
    }
}

