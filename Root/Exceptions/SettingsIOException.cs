﻿using System;

namespace Root.Exceptions
{
    public sealed class SettingsIOException : Exception
    {
        public SettingsIOException(string message) : base(message)
        {
        }

        public SettingsIOException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}