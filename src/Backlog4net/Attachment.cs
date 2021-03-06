﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Backlog4net
{
    /// <summary>
    /// Backlog attachment file.
    /// </summary>
    public interface Attachment
    {
        long Id { get; }

        string IdAsString { get; }

        string Name { get; }

        bool IsImage { get; }

        long Size { get; }

        User CreatedUser { get; }

        DateTime? Created { get; }
    }
}
