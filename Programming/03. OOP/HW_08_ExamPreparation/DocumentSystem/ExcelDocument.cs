﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ExcelDocument : OfficeDocument
{
    public long? Rows { get; private set; }
    public long? Cols { get; private set; }

    public override void LoadProperty(string key, string value)
    {
        if (key == "rows")
        {
            this.Rows = long.Parse(value);
        }
        if (key == "cols")
        {
            this.Cols = long.Parse(value);
        }
        base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("rows", this.Rows));
        output.Add(new KeyValuePair<string, object>("cols", this.Cols));
        base.SaveAllProperties(output);
    }
}
