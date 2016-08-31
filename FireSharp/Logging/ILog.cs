using System;

namespace FireSharp.Logging
{
    public interface ILog
    {
        bool IsDebugEnabled { get; }

        void Debug(string message);

        void Info(string message);

        void Warn(string message);

        void Warn(string message, Exception ex);

        void Error(string message);

        void Error(string message, Exception ex);
    }
}