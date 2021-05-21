﻿using DatabaseOperations.DataTransferObjects;
using DatabaseOperations.Extensions;
using DatabaseOperations.Interfaces;

namespace DatabaseOperations.ConnectionRules
{
    internal class ApplicationConnectionRule : IConnectionRule
    {
        private const string ApplicationNameLookUp = "application name";

        public bool Check(string item)
        {
            return item.ToLower().Contains(ApplicationNameLookUp);
        }

        public ConnectionOptions ApplyChange(ConnectionOptions options, string item)
        {
            if(string.IsNullOrWhiteSpace(options.ApplicationName)) options.ApplicationName = ApplicationNameLookUp.ToValue(item);
            return options;
        }
    }
}