using System.Collections.Generic;
using System.IO;

namespace DBCViewer
{
    interface IWowClientDBReader
    {
        int RecordsCount { get; }
        int FieldsCount { get; }
        int RecordSize { get; }
        int StringTableSize { get; }
        bool HasSeparateIndexColumn { get; }
        bool HasInlineStrings { get; }
        Dictionary<int, string> StringTable { get; }
        IEnumerable<BinaryReader> Rows { get; }

        string GetIntLength(int index);
    }
}
