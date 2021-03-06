﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Backlog4net
{
    /// <summary>
    /// Backlog disk usage data.
    /// </summary>
    public interface DiskUsageDetail
    {
        long ProjectId { get; }

        long Issue { get; }

        long Wiki { get; }

        long File { get; }

        long Subversion { get; }

        long Git { get; }
    }
}
