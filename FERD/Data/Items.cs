using FERD.Helpers;
using FERD.Models;

namespace FERD.Data
{
    public class Items
    {

        // Items CSV Header Index
        public static class ICHI
        {
            public static readonly int NAME = 0;
            public static readonly int RANK = 1;
            public static readonly int RANGE = 2;
            public static readonly int USES = 3;
            public static readonly int WT = 4;
            public static readonly int MT = 5;
            public static readonly int HIT = 6;
            public static readonly int CRT = 7;
            public static readonly int WEX = 8;
            public static readonly int COST = 9;
            public static readonly int EFFECTS = 10;
            public static readonly int TYPE = 11;
        }

        private static Dictionary<String, Item> _itemMap = new Dictionary<string, Item>();

        public static Dictionary<String, Item> ItemMap
        {
            get
            {
                if (_itemMap.Count() == 0)
                {
                    string csvContent = ResourceHelper.GetCsvContent("items");

                    using (StringReader reader = new StringReader(csvContent))
                    {
                        string? row = reader.ReadLine(); // Pop the first row (the header row) here so it gets skipped
                        string[] rowSplit;
                        while ((row = reader.ReadLine()) != null)
                        {
                            rowSplit = row.Split(',');
                            Item obj = new Item()
                            {
                                Name = rowSplit[ICHI.NAME],
                                Rank = rowSplit[ICHI.RANK],
                                Range = rowSplit[ICHI.RANGE],
                                Wt = int.Parse(rowSplit[ICHI.WT]),
                                Mt = int.Parse(rowSplit[ICHI.MT]),
                                Hit = int.Parse(rowSplit[ICHI.HIT]),
                                Crt = int.Parse(rowSplit[ICHI.CRT]),
                                Cost = int.Parse(rowSplit[ICHI.COST]),
                                Effects = rowSplit[ICHI.EFFECTS],
                                Type = rowSplit[ICHI.TYPE]
                            };

                            _itemMap.Add(obj.Name, obj);
                        }
                    }
                }

                return _itemMap;
            }
        }

        private static List<Item>? _all = null;

        public static List<Item> All => ItemMap.Values.OrderBy(i => i.Name).Prepend(Empty).ToList();

        public static Item Empty => new Item()
        {
            Name = " - ",
            Rank = " - ",
            Range = " - ",
            Wt = 0,
            Mt = 0,
            Hit = 0,
            Crt = 0,
            Cost = 0,
            Effects = " - ",
            Type = " - "
        };
    }
}
