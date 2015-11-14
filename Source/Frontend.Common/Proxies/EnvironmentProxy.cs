﻿using System;

namespace Frontend.Common.Proxies
{
    public class EnvironmentProxy : IEnvironmentProxy
    {
        public string GetFrontendWorkingDirectory()
        {
            return Environment.CurrentDirectory;
        }

        public string GetUsersFolder()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
}