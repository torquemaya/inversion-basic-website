﻿using System;
using System.Collections.Generic;

using Inversion.Process;
using Inversion.Process.Pipeline;

namespace HelloInversion.Code
{
    public class Storage : IPipelineProvider
    {
        public void Register(IServiceContainerRegistrar registrar, IDictionary<string, string> settings)
        {
            
        }
    }
}